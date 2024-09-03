/******************************************************************************
* Filename    = UnitTest1.cs
*
* Author      = Revanth Juvvala
*
* Project     = Facade
*
*****************************************************************************/

using Facade; 

namespace UnitTest
{
    /// <summary>
    /// The MediaFacadeTests class contains unit tests to verify the behavior
    /// of the MediaFacade methods which control the interaction between the
    /// subsystems for playing, pausing, and stopping a movie.
    /// </summary>
 
    [TestClass]
    public class MediaFacadeTests
    {
        private MediaFacade _mediaFacade;

        [TestInitialize]
        public void Setup()
        {
            _mediaFacade = new MediaFacade();
        }

        [TestMethod]
        public void TestPlayMovie()
        {
            _mediaFacade.PlayMovie();
            Assert.IsTrue(_mediaFacade._audioSystem.IsPlaying);
            Assert.IsTrue(_mediaFacade._videoSystem.IsPlaying);
            Assert.IsTrue(_mediaFacade._subtitleSystem.IsDisplaying);
        }

        [TestMethod]
        public void TestPauseMovie()
        {
            _mediaFacade.PauseMovie();
            Assert.IsFalse(_mediaFacade._audioSystem.IsPlaying);
            Assert.IsFalse(_mediaFacade._videoSystem.IsPlaying);
            Assert.IsFalse(_mediaFacade._subtitleSystem.IsDisplaying);
        }

        [TestMethod]
        public void TestStopMovie()
        {
            _mediaFacade.StopMovie();
            Assert.IsFalse(_mediaFacade._audioSystem.IsPlaying);
            Assert.IsFalse(_mediaFacade._videoSystem.IsPlaying);
            Assert.IsFalse(_mediaFacade._subtitleSystem.IsDisplaying);
        }
    }
}
