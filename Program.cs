using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 11,2017
 * DEscription: This is the driver class for my project
 * Version: 0.3  
 *               - implemented the SuperHero class
 */
 
namespace COMP_123_S2017_Lesson_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhero = new SuperHuman("Super dude");
            superhero.Powers.Add(new Power("Teleportation ", 50));
            superhero.Powers.Add(new Power("Phasing", 40));
            superhero.Powers.Add(new Power("Invisibility Rank ", 30));
            Console.WriteLine(superhero.ToString());
           /* superhero.AddPower("Spider Climbing", 50);
            superhero.AddPower("Webcasting", 40);
            superhero.DisplayPowers();*/
        }
    }
}
