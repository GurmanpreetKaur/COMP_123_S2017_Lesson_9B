using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: Demo for Lesson 9
 * Version: 0.2  - instantiated an object of  type superhuman
 */
 
namespace COMP_123_S2017_Lesson_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super dude");
            superhuman.Powers.Add(new Power("Spider Climibing",50));
        }
    }
}
