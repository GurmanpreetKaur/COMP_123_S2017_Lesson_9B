using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: Demo for Lesson 9
 * Version: 0.3  - Added a Power to the SuperHuman object
 */
 
namespace COMP_123_S2017_Lesson_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super dude");
            superhuman.AddPower("Spider Climbing", 50);
        }
    }
}
