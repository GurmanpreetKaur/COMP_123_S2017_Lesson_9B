using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 13,2017
 * DEscription: this is the SuperHero class which inherits from the SuperHuman class and implements the IHasKarma
 * Version: 0.3  - modified constructor to take Karma value
 */

namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// thisis the SuperHero class
    /// </summary>
    public class SuperHero :SuperHuman , IHasKarma
    {
        //private instance variables 
        private int _karma;
        //public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //constructors
        /// <summary>
        /// this is the main constructor for the SuperHreo class
        /// it takes one argument - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma) :base(name)
        {
            this.Karma = karma;
        }
       // private methods
       //public methods
    }
}