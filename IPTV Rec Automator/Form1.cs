using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IPTV_Rec_Automator
{
    public partial class MainForm : Form
    {
        private bool is_ok = false;
        private RecController RecCtl;
        private TimerController TimerCtl;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            TextAddr.Text = Constants.DefaultURI;
            TestConnection();
        }

        public void TestConnection()
        {
            var testreq = new Request(TextAddr.Text).Probe();

            if (testreq)
            {
                is_ok = true;
                LabelConnState.Text = "З'єднання встановлено";
                LabelConnState.BackColor = Color.LightGreen;
                LabelConnState.ForeColor = Color.Black;

                RecCtl = new RecController(TextAddr.Text);
                TimerCtl = new TimerController(RecCtl, LabelRecState);
            }
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            if (TextAddr.Text == String.Empty)
            {
                MessageBox.Show("Введіть адресу");
            } else
            {
                TestConnection();
                if (!is_ok)
                {
                    MessageBox.Show(Constants.TestErrorMessage, "Помилка");
                }
            }
        }

        private void ButtonInit_Click(object sender, EventArgs e)
        {
            if (is_ok)
            {
                TimerCtl.RecStartTime = StartTimePicker.Value;
                TimerCtl.RecEndTime = EndTimePicker.Value;
                TimerCtl.Start();
                LabelRecState.ChangeState(RecState.PENDING);
            } else
            {
                MessageBox.Show(Constants.TestErrorMessage);
            }
        }

        private void ButtonDeInit_Click(object sender, EventArgs e)
        {
            if (is_ok)
            {
                TimerCtl.Stop();
                LabelRecState.ChangeState(RecState.STOPPED);

                if (RecCtl.IsRecording)
                {
                    RecCtl.Stop(/*RecState.STOPPED*/);
                }
            }
            else
            {
                MessageBox.Show(Constants.TestErrorMessage);
            }
        }
    }

    public static class LabelExtensions
    {
        public static void ChangeState (this Label label, RecState state)
        {
            switch (state)
            {
                case RecState.NOT_INITIATED:                    // [+] Default
                    label.BackColor = Color.Yellow;
                    label.ForeColor = Color.Black;
                    label.Text = "Неактивний";
                break;
                case RecState.PENDING:                          // TimerController.Start
                    label.BackColor = Color.LightGreen;
                    label.ForeColor = Color.Black;
                    label.Text = "Очікування";
                break;
                case RecState.RECORDING:                        // [+] RecController.Start
                    label.BackColor = Color.Green;
                    label.ForeColor = Color.White;
                    label.Text = "Активний";
                break;
                case RecState.FINISHED:                         // [+] RecController.Stop
                    label.BackColor = Color.LightGreen;
                    label.ForeColor = Color.Black;
                    label.Text = "Закінчено";
                break;
                case RecState.STOPPED:                          // Button : Stop
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.White;
                    label.Text = "Зупинено";
                break;
            }
        }
    }
}