using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This class defines a Person
     * 
     * @class Person
     * @field _name {string}
     */
    public class Person
    {
        //Private instance variables********************************************************
        private string _name;
        private int _age;

        //Public properties*****************************************************************
        /**
         * This is the property for _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }

        }
        /**
         * <summary>
         * This is a public property for the private _age field
         * </summary>
         * 
         */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //Constructors**********************************************************************************************

        /**
         * <summary>
         * This is the default empty constructor for the Person class
         * </summary>
         * @Constructor Person
         */
        public Person()
        {
            this._initialize();
        }



        /**
         * This is a constructor that takes name as a paramater and passes it to the _name private instance variable
         * 
         * @Constructor Person
         * @param {string} name
         */
        public Person(string name)
        {
            this._initialize();
            this.Name = name;
        }

        /**
         * <summary>
         * This is a constructor that takes age as a parameter and passes it to the _age private instance variable
         * </summary>
         * 
         * @constructor Person
         * @param {int} age
         */
        public Person(int age)
        {
            this._initialize();
            this.Age = age;
        }

        /**
         * <summary>
         * This is a constructor that takes both name and age as parameter.
         * It assigns the local name value to the Name property
         * It assigns the local age value to the Age property
         * </summary>
         * @constructor Person
         * @param {string} name
         * @param {int} age
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //private methods*******************************************************

        /**
         * <summary>
         *This method initializesthepublic properties Name and Age
         * </summary>
         * 
         * @private
         * @method  _initialize
         * @returns {void}
         */
        private void _initialize()
        {
            //Initialize public properties
            this.Name = "unknown name";
            this.Age = 0;
        }

        //public methods********************************************************

        /**
         * <summary>
         * This method outputs the _name value with " says Hello" to the console
         * </summary>
         * 
         * @method _saysHello
         * @returns {void}
         */
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says Hello!");
        }

        /**
         * <summary>
         * This method outputs the _name and _age value in the following format:
         * _name + " is " + _age + " years old."
         * </summary>
         * 
         * 
         */
        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old.");
        }
    }
}
