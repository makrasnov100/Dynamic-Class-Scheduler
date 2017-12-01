using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ClassScheduler
{

    /// <summary>
    /// This class defines a course object that has the properties 
    /// courseName, abrvCourseName, and courseLevel.
    /// </summary>
    /// Author: Kostiantyn Makrasnov (variables)
    /// Author: Yuri Fedas (accessor/mutator functions & constructors)
    [Serializable]
    public class SingleCourse
    {
        private string courseName;
        private string abrvCourseName;
        private string courseLevel;
        private string departmentName;
        private int creditAmount;
        private List<string> termsAvaliable = new List<string>();
        private List<string> instructAvaliable = new List<string>();
        private List<SingleSection> sections = new List<SingleSection>();

        public SingleCourse(string courseName, string abrvCourseName, string courseLevel, string departmentName, int creditAmount,
            List<string> termsAvailable, List<string> instructAvailable, List<SingleSection> sections)
        {
            this.courseName = courseName;
            this.abrvCourseName = abrvCourseName;
            this.courseLevel = courseLevel;
            this.departmentName = departmentName;
            this.creditAmount = creditAmount;
            this.termsAvaliable = termsAvailable;
            this.instructAvaliable = instructAvailable;
            this.sections = sections;
        }

        // Accessor and Mutator functions for the SingleCourse class
        public string getCourseName()
        {
            return courseName;
        }
        
        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public string getAbrvCourseName()
        {
            return abrvCourseName;
        }

        public void setAbrvCourseName(string abrvCourseName)
        {
            this.abrvCourseName = abrvCourseName;
        }

        public string getCourseLevel()
        {
            return courseLevel;
        }

        public void setCourseLevel(string courseLevel)
        {
            this.courseLevel = courseLevel;
        }

        public string getDepartmentName()
        {
            return departmentName;
        }

        public void setDepartmentName(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void setCreditAmount(int creditAmount)
        {
            this.creditAmount = creditAmount;
        }

        public int getCreditAmount()
        {
            return creditAmount;
        }

        public List<string> getTermsAvailable()
        {
            return termsAvaliable;
        }

        public void setTermsAvailable(List<string> termsList)
        {
            this.termsAvaliable = termsList;
        }

        public List<string> getInstructAvailable()
        {
            return instructAvaliable;
        }

        public void setInstructAvailable(List<string> instructList)
        {
            this.instructAvaliable = instructList;
        }

        public List<SingleSection> getSections()
        {
            return sections;
        }

        public void setSections(List<SingleSection> sectionList)
        {
            this.sections = sectionList;
        }
    }
}
