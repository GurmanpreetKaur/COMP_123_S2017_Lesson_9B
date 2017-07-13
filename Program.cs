using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: Demo for Lesson 9
 * Version: 0.3  - Added another Power to the SuperHuman object
 *               - Also Displayed all the powers in the Powers List
 *               - used the ToString methos of the SuperHuman class 
 */
 
namespace COMP_123_S2017_Lesson_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super dude");
            superhuman.Powers.Add(new Power("Teleportation ", 50));
            superhuman.Powers.Add(new Power("Phasing", 40));
            superhuman.Powers.Add(new Power("Invisibility Rank ", 30));
            Console.WriteLine(superhuman.ToString());
           /* superhuman.AddPower("Spider Climbing", 50);
            superhuman.AddPower("Webcasting", 40);
            superhuman.DisplayPowers();*/
        }
    }
}
