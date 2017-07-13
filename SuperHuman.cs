using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* Name: Gurmanpreet Kaur
* Date: July 11,2017
* DEscription: This is the SuperHuman class that extends the Human Abstract class
* Version: 0.2 - Added _initialize methosd
*/
namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// This is the SuperHuman class
    /// </summary>
   
    public class SuperHuman : Human
    {
        // private instance variables
        private List<Power> _powers;

        // public properties
        public List<Power> Powers {
            get
            {
                return this._powers; // returns a reference
            }
        }
                

        // constructors

            /// <summary>
            /// this is the main constructor for the SuperHuman class
            /// it takes one parameter - name(string)
            ///  </summary>
            /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }


        //private methods
        /// <summary>
        /// this method initializes , instantiates and assigns values to class properties 
        /// </summary>
        /// 
        private void _initialize()
        {
            this._powers = new List<Power>();// creats an empty list
        }




        //public methods
    }
}