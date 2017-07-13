using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
* Name: Gurmanpreet Kaur
* Date: July 11,2017
* DEscription: This is the Abstract Human class
* Version: 0.2 - Added public Abstract method DisplaySkills
*/
namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// This is the Abstract Human class
    /// </summary>
    public abstract class Human
    {
        // private instance variables (fields)
        private string _name;

        //public properties
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }


        // Constructors-----------------------------------
        /// <summary>
        /// this is the main constructor for the Human class
        /// it takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        // public abstract methods
        public abstract void DisplaySkills();

        //Private Methods

        // Public Methods
    }
}