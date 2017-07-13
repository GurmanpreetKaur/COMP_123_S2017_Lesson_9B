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
            SuperHero superhero = new SuperHero("Super dude",67);
              superhero.Powers.Add(new Power("Teleportation ", 50));
              superhero.Powers.Add(new Power("Phasing", 40));
              superhero.Powers.Add(new Power("Invisibility", 30));
              Console.WriteLine(superhero.ToString());
            Console.WriteLine("Karma: " + superhero.Karma);

            SuperVillan supervillan = new SuperVillan("Super Villan",90);
           supervillan.Powers.Add(new Power("Destroy Human", 50));
           supervillan.Powers.Add(new Power("Flying", 40));
           supervillan.Powers.Add(new Power("Invisibility", 30));
           Console.WriteLine(supervillan.ToString());
            Console.WriteLine("Malice: " + supervillan.Malice);


        }
    }
}
