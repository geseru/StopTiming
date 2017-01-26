using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSystem.View
{
    public partial class Main : Form, IMainForm
    {
        public event System.Action StartClicked;
        public event System.Action StopClicked;
        
        public event System.Action ReadyClicked;

        public Main()
        {
            InitializeComponent();
        }

        public string RunningTime
        {
            set
            {
                // Don't do anything if the form's handle hasn't been created 
                // or the form has been disposed.
                if (!this.IsHandleCreated || this.IsDisposed || !runningTime.IsHandleCreated || runningTime.IsDisposed) return;

                // Invoke an anonymous method on the thread of the form.
                this.Invoke((MethodInvoker)delegate
                {
                    // Show the current time in the form's title bar.
                    runningTime.Text = value;
                });
                
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.plot.Model = new PlotModel();
            this.plot.Controller = null;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (StartClicked != null)
                StartClicked();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (ReadyClicked != null)
                ReadyClicked();
        }

        private void buttonStopp_Click(object sender, EventArgs e)
        {
            if (StopClicked != null)
                StopClicked();
        }
    }
}
