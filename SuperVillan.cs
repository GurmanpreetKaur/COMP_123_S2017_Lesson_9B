using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: This is the SuperVillan class
 * Version: 0.1 - created the Supervillan class 
 *               
 */

namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// this is the SuperVillan class
    /// </summary>
    public class SuperVillan :SuperHuman , IHasMalice
    {
        //private instance Variables
        private int _malice;
        //public properties 
        public int Karma
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        // constructors 
        public SuperVillan(string name) : base(name)
        {

        }
    }
}