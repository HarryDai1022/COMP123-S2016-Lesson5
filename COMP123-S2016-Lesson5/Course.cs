using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This is the Course class
     */
    class Course
    {
        //private instance variables
        private string _code;
        private string _description;

        //public properties
        public string Code
        {
            get
            {
                return this._code;
            }

            set
            {
                this._code = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }

            set
            {
                this._description = value;
            }
        }

        /**
         * This constructor takes two parameters: Code and Descriptions
         * 
         * @constructor Course
         * @param {string} Code
         * @param {string} Description
         */
        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
