using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    class Student : Person
    {
        //private instance variables************************************************************
        private string _studentID;
        private List<Course> _courses = new List<Course>();

        //public properties*********************************************************************
        /**
         * This property, studentID, includes a getter and a setter
         */
        public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
            set
            {
                this._courses = value;
            }
        }

        //Constructors**************************************************************************
        /**
         * <summary>
         * This constructor takes three params
         * </summary>
         * 
         * @constructor Student
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         * 
         */
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        //public methods*************************************************************************

        /**
         * This method enables the studies behavior for the student
         */
        public void Studies()
        {
            Console.WriteLine(this.Name + " studeis.");
        }

        public void ShowCourses()
        {
            Console.WriteLine();

        }
    }
}
