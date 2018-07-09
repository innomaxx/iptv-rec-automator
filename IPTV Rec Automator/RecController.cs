using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTV_Rec_Automator
{
    class RecController
    {
        //private Label LabelRecState;
        private Request req;
        private bool isRecording = false;

        public RecController(string url/*, Label LabelRecState*/)
        {
            //this.LabelRecState = LabelRecState;
            req = new Request(new Uri(new Uri(url), "/send/3/48/"));
        }

        public bool IsRecording { get; }

        public bool Start()
        {
            req.Get();
            //LabelRecState.ChangeState(RecState.RECORDING);
            isRecording = true;
            return isRecording;
        }

        public bool Stop(/*RecState state = RecState.FINISHED*/)
        {
            req.Get();
            //LabelRecState.ChangeState(state);
            isRecording = false;
            return isRecording;
        }
    }

    public enum RecState
    {
        NOT_INITIATED, PENDING, RECORDING, FINISHED, STOPPED
    }
}
