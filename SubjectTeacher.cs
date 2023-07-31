using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace inheritance
{
    public class SubjectTeacher : Teacher
    {
        private Subject whichSubject;

        public Subject WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }

    public class Subject
    {
        public string Name { get; internal set; }
    }
}
