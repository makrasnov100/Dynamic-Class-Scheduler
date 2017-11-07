using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ClassScheduler
{
    public class SingleCourse
    {
        public string courseName;
        public string abrvCourseName;
        public List<string> termsAvaliable = new List<string>();
        public List<string> instructAvaliable = new List<string>();
        public List<SingleSection> sections = new List<SingleSection>();
    }
}
