using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
* Name: Gurman Mangat
* Date: July 11,2017
* DEscription: This is the Abstract Human class
* Version: 0.1 - Created the Abstract class
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

        //Private Methods

        // Public Methods
    }
}