using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: Demo for Lesson 9
 * Version: 0.2 - Added a new constructor
 */
namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// this is the power class which will be used as a data type
    /// </summary>
    public class Power
    {
        // public properties 
        public string Name { get; set; }
        public int Rank { get; set; }

        // constructor------------------------
        /// <summary>
        /// this is the main consctrutor for the power class
        /// it takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Rank = rank;
            this.Name = name;
        }
    }
}