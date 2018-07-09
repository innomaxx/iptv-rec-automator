
using System;
using System.Timers;

namespace IPTV_Rec_Automator
{
    class TimerController
    {
        private Timer timer;
        private System.Windows.Forms.Label LabelRecState;
        private RecController rec;

        public DateTime RecStartTime { get; set; }
        public DateTime RecEndTime { get; set; }

        public TimerController(RecController rec, System.Windows.Forms.Label LabelRecState)
        {
            this.rec = rec;
            this.LabelRecState = LabelRecState;

            timer = new Timer
            {
                Interval = Constants.TimerTickInterval,
                AutoReset = true
            };
            timer.Elapsed += new ElapsedEventHandler(TimeVerifier);
        }

        private void TimeVerifier(object sender, ElapsedEventArgs e)
        {
            var current_time = DateTime.Now.ToString(Constants.ComparisonPattern);
            if (current_time == RecStartTime.ToString(Constants.ComparisonPattern))
            {
                rec.Start();
                LabelRecState.ChangeState(RecState.RECORDING);
            }
            else if (current_time == RecEndTime.ToString(Constants.ComparisonPattern))
            {
                rec.Stop();
                LabelRecState.ChangeState(RecState.FINISHED);
            }
        }

        public void Start() => timer.Start();

        public void Stop() => timer.Stop();
    }
}
