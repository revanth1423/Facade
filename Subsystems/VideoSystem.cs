/******************************************************************************
* Filename    = VideoSystems.cs
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
    /// The VideoSystem class controlls like a video playback 
    /// system. It plays, pauses, and stops video.
    /// </summary>
    public class VideoSystem
    {
        // It tracks whether the video is currently playing
        public bool IsPlaying { get; private set; }

        public void PlayVideo()
        {
            IsPlaying = true;
            Console.WriteLine("Playing video...");
        }

        public void PauseVideo()
        {
            IsPlaying = false;
            Console.WriteLine("Pausing video...");
        }

        public void StopVideo()
        {
            IsPlaying = false;
            Console.WriteLine("Stopping video...");
        }
    }
}

