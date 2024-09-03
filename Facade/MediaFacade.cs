/******************************************************************************
* Filename    = MediaFacade.cs
*
* Author      = Revanth Juvvala
*
* Project     = Facade
*
*****************************************************************************/

using Subsystems; // Just to ensure to include the namespace for Subsystems

namespace Facade
{
    /// <summary>
    /// The MediaFacade class provides a simple interface to control
    /// the operations of different subsystems such as Audio, Video,
    /// and Subtitles. It hides the complexity of interacting with these
    /// subsystems individually which is what exactly a facade does
    /// </summary>
    public class MediaFacade
    {
        // Making these properties public for accessing the underlying subsystem cases
        public AudioSystem _audioSystem { get; private set; }
        public VideoSystem _videoSystem { get; private set; }
        public SubtitleSystem _subtitleSystem { get; private set; }

        /// <summary>
        /// Constructor initializes the subsystems for Audio, Video, and Subtitles.
        /// </summary>
        public MediaFacade()
        {
            _audioSystem = new AudioSystem();
            _videoSystem = new VideoSystem();
            _subtitleSystem = new SubtitleSystem();
        }

        /// <summary>
        /// PlayMovie method starts playing the movie by starting the
        /// the audio, video, and subtitle subsystems.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine("Starting movie...");
            _audioSystem.PlayAudio();
            _videoSystem.PlayVideo();
            _subtitleSystem.DisplaySubtitles();
        }

        public void PauseMovie()
        {
            Console.WriteLine("Pausing movie...");
            _audioSystem.PauseAudio();
            _videoSystem.PauseVideo();
            _subtitleSystem.HideSubtitles();
        }

        public void StopMovie()
        {
            Console.WriteLine("Stopping movie...");
            _audioSystem.StopAudio();
            _videoSystem.StopVideo();
            _subtitleSystem.HideSubtitles();
        }
    }
}
