/******************************************************************************
* Filename    = SubtitleSystems.cs
*
* Author      = Revanth Juvvala
*
* Project     = Facade
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsystems
{
    /// <summary>
    /// The SubtitleSystem class controlls like a subtitle  
    /// display system. It can display and hide subtitles.
    /// </summary>
    public class SubtitleSystem
    {
        public bool IsDisplaying { get; private set; }

        public void DisplaySubtitles()
        {
            IsDisplaying = true;
            Console.WriteLine("Displaying subtitles...");
        }

        public void HideSubtitles()
        {
            IsDisplaying = false;
            Console.WriteLine("Hiding subtitles...");
        }
    }
}

