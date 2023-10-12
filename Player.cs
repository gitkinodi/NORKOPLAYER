using WMPLib;

namespace NORKOPLAYER
{
    internal class Player
    {
        private WMPLib.WindowsMediaPlayer WMP;

        private const int DefaultVolume = 50;
        private const double DefaultSpeed = 1;

        private const double DefaultPosition = 0;
        private const string DefaultPositionString = "00:00";

        private const double DefaultDuration = 0;
        private const string DefaultDurationString = "00:00";

        internal Player()
        {
            WMP = new WMPLib.WindowsMediaPlayer();
            WMP.settings.autoStart = false;

            this.SetVolume(DefaultVolume);
            this.SetSpeed(DefaultSpeed);
        }

        internal bool IsMediaEnded()
        {
            return WMP.playState == WMPPlayState.wmppsStopped;
        }

        internal void SetTrack(string FullFileName)
        {
            WMP.URL = FullFileName;
        }

        internal void Play()
        {
            if (WMP.playState != WMPPlayState.wmppsUndefined)
            {
                WMP.controls.play();
            }
        }

        internal void Pause()
        {
            if (WMP.playState != WMPPlayState.wmppsUndefined)
            {
                WMP.controls.pause();
            }
        }

        internal void Stop()
        {
            if (WMP.playState != WMPPlayState.wmppsUndefined)
            {
                WMP.controls.stop();
                WMP.close();
            }
        }


        internal void SetVolume(int volume)
        {
            WMP.settings.volume = volume;
        }

        internal void SetSpeed(double rate)
        {
            WMP.settings.rate = rate;
        }


        internal double GetCurrentPosition()
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying || WMP.playState == WMPPlayState.wmppsPaused)
            {
                return WMP.controls.currentPosition;
            }
            else
            {
                return DefaultPosition;
            }
        }

        internal string GetCurrentPositionString()
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying || WMP.playState == WMPPlayState.wmppsPaused)
            {
                return WMP.controls.currentPositionString;
            }
            else
            {
                return DefaultPositionString;
            }
        }

        internal void SetPosition(double position)
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying || WMP.playState == WMPPlayState.wmppsPaused)
            {
                WMP.controls.currentPosition = position;
            }
        }

        internal double GetDuration()
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying || WMP.playState == WMPPlayState.wmppsPaused)
            {
                return WMP.controls.currentItem.duration;
            }
            else
            {
                return DefaultDuration;
            }
        }

        internal string GetDurationString()
        {
            if (WMP.playState == WMPPlayState.wmppsPlaying || WMP.playState == WMPPlayState.wmppsPaused)
            {
                return WMP.controls.currentItem.durationString;
            }
            else
            {
                return DefaultDurationString;
            }
        }
    }
}
