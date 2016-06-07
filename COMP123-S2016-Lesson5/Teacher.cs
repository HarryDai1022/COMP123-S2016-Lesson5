using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * The Teacher class is derived from the Person class
     * 
     * @class Teacher
     * @extends Person
     */
    class Teacher : Person
    {
        //private instance variables
        private string _employeeID;

        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }

            set
            {
                this._employeeID = value;
            }
        }

        /**
         * This constructor method takes three parameters; name, age, employeeID
         * 
         * @Constructor Teacher
         * @param {string} name
         */
        public Teacher(string name, int age, string employeeID)
            : base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        //public methods
        /**
         * This method enables the Teaches behavior for the Teacher class
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
