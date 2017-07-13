using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gurmanpreet Kaur
 * Date: July 13,2017
 * DEscription: this is the interface that defines a karma property that must be implemented in any class that subscribes  
 * Version: 0.3  created IHasKarma*/
namespace COMP_123_S2017_Lesson_09
{
    /// <summary>
    /// this is the IHasKarma interface
    /// </summary>
    public interface IHasKarma
    {

        //public properties
        int Karma { get; set; }
    }
}