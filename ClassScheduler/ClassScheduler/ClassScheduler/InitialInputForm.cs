﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduler
{

    /// <summary>
    /// This is a window in which the user is expected to enter initial data 
    /// to be used for the rest of the program proccess.
    /// </summary>
    /// Author: Kostiantyn Makrasnov (Excel Reader Part & Form's Layout/User Input Validation)
    /// Author: Yuriy Fedas (Preview of Selected Excel Data File & Proper control through access/mutator functions)
    /// /// 
    /// Sources for ExcelDataReader: Source code from https://github.com/ExcelDataReader/ExcelDataReader, used methods
    /// from ExcelDataReader and ExcelDataReader.DataSet Nuget packages.

    public partial class InitialInputForm : Form
    {
        //ExcelReader Variables
        private UserConfig userData = new UserConfig() { };
        public List<SingleCourse> courses = new List<SingleCourse>();
        public List<SingleCourse> unneededCourses = new List<SingleCourse>();
        private List<string> sectionIDs = new List<string>();
        private List<string> courseIDs = new List<string>();
        IExcelDataReader excelReader;
        private PreviewForm previewForm = new PreviewForm();

        //Progress Bar Variables
        private float totalCalcNum;
        private float curCalcNum;
        private float precentComplete;
        private DataTable dt;

        public InitialInputForm()
        {
            InitializeComponent();
        }

        //Accessor for userData UserConfig object
        public UserConfig getUserData()
        {
            return userData;
        }

        //[FUNCTION - InputWindow_Load]
        //Mainly Turns OFF Visibility of Error Labels at Start
        private void InputWindow_Load(object sender, EventArgs e)
        {
            FirstNameNeedLabel.Visible = false;
            LastNameNeedLabel.Visible = false;
            TermNeedLabel.Visible = false;
            PreviewStatusLabel.Visible = false;
            LoadingCoursesPanel.Visible = false;
        }

        //[FUNCTION - btnFind_Click]
        //Source: https://github.com/executeautomation/DataReader and ExcelDataReader documentation (README)
        //Performs actions designated for "Find" button click
        private void btnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SelectedFileName = ofd.FileName;
                    DataTable final = ExcelToDataTable(SelectedFileName);

                    previewForm.setFileName(SelectedFileName);
                    previewForm.getPreviewDGV().DataSource = final;

                    FileStream stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    //suggested at http://www.c-sharpcorner.com/forums/datareaders-row-count to get row count
                    DataSet result = excelReader.AsDataSet();
                    dt = result.Tables[0];
                }

                if (excelReader != null)
                {
                    PreviewStatusLabel.Text = "Preview Ready!";
                    PreviewStatusLabel.ForeColor = Color.Green;
                    PreviewStatusLabel.Visible = true;
                }
            }
        }

        //[METHOD - ExcelToDataTable]
        //Return a DataTable with excel file contents
        public static DataTable ExcelToDataTable(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    DataTableCollection table = result.Tables;
                    DataTable resultTable = table["Sheet1"];
                    return resultTable;
                }
            }
        }

        //[FUNCTION - InputToMainButton_Click]
        //Performs actions designated for "InputToMainButton" button click
        private void InputToMainButton_Click(object sender, EventArgs e)
        {
            if (checkInputCompletion() && !BackgroundWorkerCourses.IsBusy)
            {
                //Removes all input error labels
                FirstNameNeedLabel.Visible = false;
                LastNameNeedLabel.Visible = false;
                TermNeedLabel.Visible = false;
                LoadingCoursesPanel.Visible = true;

                //Gathers all input into userData object
                userData.setFirstName(FirstNameTextBox.Text);
                userData.setLastName(LastNameTextBox.Text);
                if (TermComboBox.Text == "Fall")
                    userData.setTermInterest("FA");
                else if (TermComboBox.Text == "Spring")
                    userData.setTermInterest("SP");
                else
                    userData.setTermInterest("JA");

                StartCalcPB();

                //PARTIAL INSTRUCTION FROM LINK (background worker)
                //https://www.youtube.com/watch?v=G3zRhhGCJJA
                BackgroundWorkerCourses.RunWorkerAsync();

            }
            else
            {
                displayInputErrors();
            }
        }

        //[FUNCTION - ReadExcelData)
        //Summarizes the proccess of excel data filtering 
        void ReadExcelData()
        {
            excelReader.Read(); //skips first row
            ProcessCourseData();
            RemoveIrevSections();
            SortCourses();
            WriteDebugFile();
        }

        //[FUNCTION - checkImputCompletion)
        //Returns True if all imputs on this form are completed correctly
        bool checkInputCompletion()
        {
            if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && TermComboBox.Text != "" && excelReader != null)
                return true;
            else
                return false;
        }

        //[FUNCTION - displayInputErrors)
        //Dispays error labels by those fields that are empty or incorrect
        void displayInputErrors()
        {
            if (FirstNameTextBox.Text == "")
                FirstNameNeedLabel.Visible = true;
            else
                FirstNameNeedLabel.Visible = false;

            if (LastNameTextBox.Text == "")
                LastNameNeedLabel.Visible = true;
            else
                LastNameNeedLabel.Visible = false;

            if (TermComboBox.Text == "")
                TermNeedLabel.Visible = true;
            else
                TermNeedLabel.Visible = false;

            if (excelReader == null)
            {
                PreviewStatusLabel.Text = "File not selected.";
                PreviewStatusLabel.ForeColor = Color.Red;
                PreviewStatusLabel.Visible = true;
            }
        }

        //[FUNCTION - ProcessCourseData]
        //Goes through each row in selected excel spreadsheet dynamically populating the course list
        void ProcessCourseData()
        {
            curCalcNum = 0;
            while (excelReader.Read())
            {
                if (Convert.ToInt32(excelReader.GetDouble(12)) == 0)
                    continue;

                precentComplete = (curCalcNum / totalCalcNum) * 100f;
                BackgroundWorkerCourses.ReportProgress((int)precentComplete);

                if (!courses.Exists(s => s.getCourseName() == excelReader.GetString(6) && s.getAbrvCourseName() == TruncatedCourseID()))
                {
                    // SingleCourse constructor to inputs initial data 
                    courses.Add(new SingleCourse
                    (
                        excelReader.GetString(6),
                        TruncatedCourseID(),
                        GetCourseLevel(),
                        excelReader.GetString(3),
                        Convert.ToInt32(excelReader.GetDouble(12)),
                        new List<string> { (excelReader.GetString(2)) },
                        new List<string>(GetRowInstructNames()),
                        new List<SingleSection> { (new SingleSection { }) }
                    ));

                    int courseIndex = courses.Count() - 1;
                    courses[courseIndex].getSections()[0].setTerm(excelReader.GetString(2));
                    courses[courseIndex].getSections()[0].setID(excelReader.GetString(5));
                    courses[courseIndex].getSections()[0].setCourseName(excelReader.GetString(6));
                    courses[courseIndex].getSections()[0].setStartTimes(SplitCellIntoList(17, ", ", " NA"));
                    courses[courseIndex].getSections()[0].setStopTimes(SplitCellIntoList(18, ", ", " NA"));
                    courses[courseIndex].getSections()[0].setMeetDays(SplitCellIntoList(19, ",", "NA"));
                    courses[courseIndex].getSections()[0].FormatTimeToMinutes();
                    courses[courseIndex].getSections()[0].setInstructFirstN(SplitCellIntoList(10, ", ", ""));
                    courses[courseIndex].getSections()[0].setInstructLastN(SplitCellIntoList(9, ", ", "NA"));
                    sectionIDs.Add(excelReader.GetString(5));
                    courseIDs.Add(TruncatedCourseID() + "|" + excelReader.GetString(6));
                }
                else if (DetermineSectionNeed(courseIDs.IndexOf(TruncatedCourseID() + "|" + excelReader.GetString(6))))
                {
                    int courseIndex = courseIDs.IndexOf(TruncatedCourseID() + "|" + excelReader.GetString(6));
                    int sectionIndex = courses[courseIndex].getSections().Count();
                    bool termRecorded = false;
                    bool instructRecorded = false;

                    //Check for a unique term avaliability
                    foreach (var availTerm in courses[courseIndex].getTermsAvailable())
                        if (availTerm == excelReader.GetString(2))
                            termRecorded = true;
                    if (!termRecorded)
                        courses[courseIndex].getTermsAvailable().Add(excelReader.GetString(2));

                    //Check for a unique course instructor
                    List<string> currentInstructs = SplitCellIntoList(9, ",", "NA");
                    foreach (var course in courses)
                    {
                        foreach (var section in course.getSections())
                            foreach (var instruct in section.getInstructLastN())
                                foreach (var currentInstruct in currentInstructs)
                                    if (currentInstruct == instruct)
                                        instructRecorded = true;
                    }
                    if (!instructRecorded)
                    {
                        List<string> lastNames = SplitCellIntoList(9, ", ", "NA");
                        List<string> firstNames = SplitCellIntoList(10, ", ", "NA");
                        int indexCounter = 0;
                        foreach (var lastName in lastNames)
                        {
                            if (firstNames.Count() == 1 && firstNames[0] == "NA")
                                courses[courseIndex].getInstructAvailable().Add(lastName);
                            else if (firstNames.Count() == 1)
                                courses[courseIndex].getInstructAvailable().Add(firstNames[0] + " " + lastName);
                            else
                                courses[courseIndex].getInstructAvailable().Add(firstNames[indexCounter] + " " + lastName);
                            indexCounter++;
                        }
                        indexCounter = 0;
                    }

                    courses[courseIndex].getSections().Add(new SingleSection { });

                    courses[courseIndex].getSections()[sectionIndex].setTerm(excelReader.GetString(2));
                    courses[courseIndex].getSections()[sectionIndex].setID(excelReader.GetString(5));
                    courses[courseIndex].getSections()[sectionIndex].setCourseName(excelReader.GetString(6));
                    courses[courseIndex].getSections()[sectionIndex].setStartTimes(SplitCellIntoList(17, ", ", " NA"));
                    courses[courseIndex].getSections()[sectionIndex].setStopTimes(SplitCellIntoList(18, ", ", " NA"));
                    courses[courseIndex].getSections()[sectionIndex].setMeetDays(SplitCellIntoList(19, ",", "NA"));
                    courses[courseIndex].getSections()[sectionIndex].FormatTimeToMinutes();
                    courses[courseIndex].getSections()[sectionIndex].setInstructFirstN(SplitCellIntoList(10, ", ", ""));
                    courses[courseIndex].getSections()[sectionIndex].setInstructLastN(SplitCellIntoList(9, ", ", "NA"));

                    sectionIDs.Add(excelReader.GetString(5));
                }
                curCalcNum++;
            }
        }

        //[FUNCTION - TruncatedCourseID]
        //Cuts course ID before second slash "-"
        string TruncatedCourseID()
        {
            string fullID = excelReader.GetString(5);
            return fullID.Substring(0, fullID.IndexOf("-", 4));
        }
        //[FUNCTION - DetermineSectionNeed]
        //Finds if a given excel line contains a unique section (returns false if already present)
        bool DetermineSectionNeed(int checkIndex)
        {
            bool needSection = true;

            foreach (var section in courses[checkIndex].getSections())
            {
                if (section.getID() == excelReader.GetString(5) &&
                    section.getStartTimes().SequenceEqual(SplitCellIntoList(17, ", ", " NA")) &&
                    section.getTerm() == excelReader.GetString(2) &&
                    section.getInstructFirstN().SequenceEqual(SplitCellIntoList(10, ", ", "")) &&
                    section.getMeetDays().SequenceEqual(SplitCellIntoList(19, ", ", "")))// &&
                                                                                         //section.stopTimes.SequenceEqual(SplitCellIntoList(18, ", ", " NA")) &&
                                                                                         //section.instructLastN.SequenceEqual(SplitCellIntoList(9, ", ", "")))
                {
                    needSection = false;
                }
                if (needSection == false)
                    break;
            }

            return needSection;
        }

        //[FUNCTION - SplitCellIntoList]
        //Splits data from column index and given delim into a List of strings
        List<string> SplitCellIntoList(int columnIndex, string delim, string nullReplace)
        {
            List<string> result = new List<string>(((excelReader.GetString(columnIndex)) != null ? excelReader.GetString(columnIndex) : nullReplace).Split(new string[] { delim }, StringSplitOptions.None));

            if (delim == ",")
            {
                List<string> trimmedResult = new List<string>();
                int itemCounter = 0;
                foreach (var item in result)
                {
                    trimmedResult.Add(item.Trim());
                    itemCounter++;
                }
                return trimmedResult;
            }

            return result;
        }

        //[FUNCTION - RemoveIrevSections]
        //Cleans up course data by removing irrevelant sections with missing times/days
        void RemoveIrevSections()
        {
            List<int> removeCourseIndexes = new List<int>();
            List<int> removeSectionIndexes = new List<int>();

            //DETEMNINE section need
            foreach (var course in courses)
            {
                foreach (var section in course.getSections())
                    if (section.getMeetDays().Exists(s => s.Contains("NA")) || section.getStartTimes().Exists(s => s.Contains("NA"))
                        || !section.getTerm().Contains(userData.getTermInterest()))
                    {
                        removeCourseIndexes.Add(courses.IndexOf(course));
                        removeSectionIndexes.Add(course.getSections().IndexOf(section));
                    }
            }


            //ADD unneeded courses to secondary list (some may have partial valid data)
            foreach (var index in removeCourseIndexes)
                unneededCourses.Add(courses[index]);

            //REMOVE course entry from primary list
            int indexOffset = 0;
            if (removeCourseIndexes.Count() == 0)
                return;

            int currentCourseIndex = removeCourseIndexes[0];
            for (int i = 0; i < removeCourseIndexes.Count(); i++)
            {
                if (currentCourseIndex != removeCourseIndexes[i])
                {
                    indexOffset = 0;
                    currentCourseIndex = removeCourseIndexes[i];
                }
                Debug.WriteLine("Removing - Course: " + courses[removeCourseIndexes[i]].getCourseName() + " | Section: " + removeSectionIndexes[i]);
                courses[removeCourseIndexes[i]].getSections().RemoveAt(removeSectionIndexes[i] - indexOffset);
                indexOffset++;
            }

            RemoveEmptyCourses();
        }

        //[FUNCTION - RemoveEmptyCourses]
        //Removes courses from the primary list which are without any sections
        void RemoveEmptyCourses()
        {
            int indexOffset = 0;
            List<int> courseRemoveIndexes = new List<int> { };

            foreach (var course in courses)
                if (course.getSections().Count() == 0)
                    courseRemoveIndexes.Add(courses.IndexOf(course));

            foreach (var index in courseRemoveIndexes)
            {
                courses.RemoveAt(index - indexOffset);
                indexOffset++;
            }
        }

        //[FUNCTION - SortCourses]
        //Sorts all leftover courses into alphabetical oder (by Course ID - CO-150)
        void SortCourses()
        {
            courses = courses.OrderBy(f => f.getAbrvCourseName()).ToList<SingleCourse>();
        }

        //[FUNCTION - WriteDebugFile]
        //Controls the creation and content of debug .txt file
        void WriteDebugFile()
        {
            FileStream fs = new FileStream(@"AllSectionTimes.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite); //last parameter needed to open file at end
            StreamWriter file = new StreamWriter(fs);

            string term = "Fall"; //(revise always will be fall cant assess control that was created on different thread)
            WriteTermSections(userData.getTermInterest(), term, file);
            file.Flush();

            Process.Start(@"AllSectionTimes.txt");
            Debug.WriteLine("FILE OPENED");
        }

        //[FUNCTION - WriteTermSections]
        //Formats course information of a specific term and writes to debug .txt file (one course at a time)
        void WriteTermSections(string abrvTerm, string Term, StreamWriter sw)
        {
            sw.WriteLine("****************************[" + Term.ToUpper() + " Term]****************************");
            int courseNum = 0;
            foreach (var course in courses)
            {
                sw.Flush();
                if (course.getTermsAvailable().Any(s => s.EndsWith(abrvTerm)))
                {
                    courseNum++;
                    sw.WriteLine("[" + Term.ToUpper() + " COURSE #" + courseNum + "] - [" + course.getAbrvCourseName() + "] - "
                        + course.getCourseName() + ": ");

                    int indexCount = 0;
                    foreach (var section in course.getSections())
                    {
                        if (section.getTerm().Contains(abrvTerm))
                        {
                            int secTimeIndex = 0;

                            sw.Write("  [SECTION #" + (indexCount + 1) + "] -");
                            foreach (var startTime in section.getStartTimes())
                            {
                                sw.Write(startTime + " -" + section.getStopTimes()[secTimeIndex]);
                                if (secTimeIndex == 0 && section.getStartTimes().Count() != 1)
                                    sw.Write(" and");
                                secTimeIndex++;
                            }
                            sw.Write(" | ");

                            int secFacIndex = 0;
                            foreach (var lastName in section.getInstructLastN())
                            {
                                if (section.getInstructFirstN()[secFacIndex] != "")
                                    sw.Write(section.getInstructFirstN()[secFacIndex] + ", ");
                                else
                                    sw.Write(" ");
                                sw.Write(lastName + " | ");
                                secFacIndex++;
                            }

                            int secDayIndex = 0;
                            foreach (var day in section.getMeetDays())
                            {
                                if (secDayIndex != 0)
                                    sw.Write("-");
                                sw.Write(day);
                                secDayIndex++;
                            }
                            sw.WriteLine(" |");
                            indexCount++;
                        }
                    }
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                }
            }
        }

        //[FUNCTION - GetCourseLevel]
        //Returns the level of course based on excel reader position
        string GetCourseLevel()
        {
            object value = excelReader.GetValue(8);
            string stringValue = value.ToString();
            return (stringValue != "NA") ? stringValue : "000";
        }

        //[FUNCTION - GetRowInstructNames]
        //Formats and returns instructor names
        List<string> GetRowInstructNames()
        {
            List<string> resultNames = new List<string>();
            List<string> lastNames = SplitCellIntoList(9, ", ", "NA");
            List<string> firstNames = SplitCellIntoList(10, ", ", "NA");
            int indexCounter = 0;
            foreach (var lastName in lastNames)
            {
                if (firstNames.Count() == 1 && firstNames[0] == "NA")
                    resultNames.Add(lastName);
                else if (firstNames.Count() == 1)
                    resultNames.Add(firstNames[0] + " " + lastName);
                else
                    resultNames.Add(firstNames[indexCounter] + " " + lastName);
                indexCounter++;
            }
            indexCounter = 0;

            return resultNames;
        }

        //PROGRESS BAR CODE
        //[FUNCTION - StartCalc]
        //Resets all needed variables
        public void StartCalcPB()
        {
            ModifyProgressBarColor.SetState(ProgressBar, 2);
            curCalcNum = 0;
            totalCalcNum = dt.Rows.Count;
        }

        //Accessor/mutator functions (revise by adding more)
        public List<string> getCourseIDs()
        {
            return courseIDs;
        }

        //BACKGROUND WORKER FUNCTIONS (same citation as above)
        private void BackgroundWorkerCourses_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
            PercentCompleteLabel.Text = string.Format("Progress: {0}%", e.ProgressPercentage);
            int iCurAmount = (int)(totalCalcNum * (e.ProgressPercentage / 100f));
            CurrentAmountLabel.Text = "Current: " + iCurAmount;
            TotalAmountLabel.Text = "Total: " + totalCalcNum;
        }

        private void BackgroundWorkerCourses_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadExcelData();
        }

        private void BackgroundWorkerCourses_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Shows course selection form after calculation is complete
            CourseSelectionForm CourseSelection = new CourseSelectionForm(this);
            this.Hide();
            CourseSelection.ShowDialog();
        }

        //Property to hold the selected file name
        public string SelectedFileName { get; set; }

        private void PreviewExcelSheetButton_Click_1(object sender, EventArgs e)
        {
            previewForm.setFilenameLabel();
            previewForm.ShowDialog();
        }
    }
}