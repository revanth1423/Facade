/******************************************************************************
* Filename    = AudioSystems.cs
*
* Author      = Revanth Juvvala
*
* Project     = Facade
*
*****************************************************************************/

namespace Subsystems
{
    /// <summary>
    /// The AudioSystem class controlls like an audio
    /// playback system. It can play, pause and stop audio.
    /// </summary>
    public class AudioSystem
    {
        // It tracks whether the audio is currently playing
        public bool IsPlaying { get; private set; }

        public void PlayAudio()
        {
            IsPlaying = true;
            Console.WriteLine("Playing audio...");
        }

        public void PauseAudio()
        {
            IsPlaying = false;
            Console.WriteLine("Pausing audio...");
        }

        public void StopAudio()
        {
            IsPlaying = false;
            Console.WriteLine("Stopping audio...");
        }
    }
}
