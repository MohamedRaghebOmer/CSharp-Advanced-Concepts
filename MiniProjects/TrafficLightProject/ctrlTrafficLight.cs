using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightProject
{
    public partial class ctrlTrafficLight : UserControl
    {
        public event EventHandler<LightChangedEventArgs> OnLightChanged;

        public delegate void LightChangedEventHandler();
        public event LightChangedEventHandler OnLightIsRed;
        public event LightChangedEventHandler OnLightIsYellow;
        public event LightChangedEventHandler OnLightIsGreen;

        public enum LightColor { Red, Yellow, Green };
        private LightColor _lightColor = LightColor.Red;

        private int _currentTime; // Current timer time (by seconds)
        public int _redTime = 10, _yellowTime = 10, _greenTime = 10;


        public ctrlTrafficLight()
        {
            InitializeComponent();
        }


        public class LightChangedEventArgs : EventArgs
        {
            public LightColor OldColor;
            public LightColor CurrentColor;
            public LightColor NextColor;
            public int OldTime;
            public int CurrentTime;
            public int NextTime;

            public LightChangedEventArgs(LightColor oldColor, LightColor currentColor, LightColor nextColor,
                int oldTime, int currentTime, int nextTime)
            {
                this.OldColor = oldColor;
                this.CurrentColor = currentColor;
                this.NextColor = nextColor;
                this.OldTime = oldTime;
                this.CurrentTime = currentTime;
                this.NextTime = nextTime;
            }
        }

        public int RedTime
        {
            get => _redTime;
            set => _redTime = value;
        }

        public int YellowTime
        {
            get => _yellowTime;
            set => _yellowTime = value;
        }

        public int GreenTime
        {
            get => _greenTime;
            set => _greenTime = value;
        }

        public LightColor TrafficLightColor
        {
            get => _lightColor;

            set
            {
                _lightColor = value;
                ChangeImage();
                UpdateLabelTime();
            }
        }


        public void Start()
        {
            _currentTime = GetCurrentColorTime();
            lblTime.Text = _currentTime.ToString();
        }

        public void Stop()
        {
            LightTimer.Stop();
        }

        public void Resume()
        {
            LightTimer.Start();
        }

        public void Reset()
        {
            btnReset_Click(null, null);
        }


        private void ChangeImage()
        {
            switch (TrafficLightColor)
            {
                case LightColor.Red:
                    pbTrafficLight.Image = Properties.Resources.Red;
                    break;

                case LightColor.Yellow:
                    pbTrafficLight.Image = Properties.Resources.Yellow;
                    break;

                case LightColor.Green:
                    pbTrafficLight.Image = Properties.Resources.Green;
                    break;
            }
        }

        private LightChangedEventArgs GetCurrentArgs()
        {
            switch (TrafficLightColor)
            {
                case LightColor.Red:
                    return new LightChangedEventArgs(LightColor.Green, LightColor.Red, LightColor.Yellow,
                        GreenTime, RedTime, YellowTime);

                case LightColor.Yellow:
                    return new LightChangedEventArgs(LightColor.Red, LightColor.Yellow, LightColor.Green,
                        RedTime, YellowTime, GreenTime);

                case LightColor.Green:
                    return new LightChangedEventArgs(LightColor.Yellow, LightColor.Green, LightColor.Red,
                        YellowTime, GreenTime, RedTime);
            }

            return null; // Unreachable
        }

        private LightColor GetNextColor()
        {
            switch (TrafficLightColor)
            {
                case LightColor.Red:
                    return LightColor.Yellow;

                case LightColor.Yellow:
                    return LightColor.Green;

                case LightColor.Green:
                    return LightColor.Red;
            }

            return LightColor.Red; // Unreachable
        }

        private void UpdateLabelTime()
        {
            lblTime.Text = _currentTime.ToString();

            // Set label fore color the same light color.
            if (TrafficLightColor == LightColor.Red)
            {
                lblTime.ForeColor = Color.Red;
            }
            else if (TrafficLightColor == LightColor.Yellow)
            {
                lblTime.ForeColor = Color.Goldenrod;
            }
            else if (TrafficLightColor == LightColor.Green)
            {
                lblTime.ForeColor = Color.Green;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            LightTimer.Stop();
            btnPause.Visible = false;
            btnStart.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LightTimer.Start();
            btnStart.Visible = false;
            btnPause.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TrafficLightColor = LightColor.Red;
            _currentTime = GetCurrentColorTime();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            _currentTime--;
            UpdateLabelTime();

            if (_currentTime <= 0)
            {
                TrafficLightColor = GetNextColor(); // Update light color
                _currentTime = GetCurrentColorTime();
                RaiseEvents();
            }
        }

        private void RaiseEvents()
        {
            OnLightChanged?.Invoke(this, GetCurrentArgs());

            // Raise specified color event
            switch(TrafficLightColor)
            {
                case LightColor.Red:
                    OnLightIsRed?.Invoke();
                    break;

                case LightColor.Yellow:
                    OnLightIsYellow?.Invoke();
                    break;

                case LightColor.Green:
                    OnLightIsGreen?.Invoke();
                    break;
            }
        }

        private int GetCurrentColorTime()
        {
            switch (TrafficLightColor)
            {
                case LightColor.Red:
                    return RedTime;

                case LightColor.Yellow:
                    return YellowTime;

                case LightColor.Green:
                    return GreenTime;
            }

            return -1; // Unreachable by default, (-1 indicates error).
        }
    }
}
