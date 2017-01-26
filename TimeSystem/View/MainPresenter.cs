using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem.View
{
    class MainPresenter
    {
        private TimeManager timeManager;
        private IMainForm mainForm;

        public MainPresenter(TimeManager timeManager, IMainForm mainForm)
        {
            this.timeManager = timeManager;
            this.mainForm = mainForm;

            this.timeManager.TimeChanged += OnTimeChanged;
            this.mainForm.StartClicked += OnStartClicked;
            this.mainForm.StopClicked += OnStopClicked;
            this.mainForm.ReadyClicked += OnReadyClicked;
        }

        ~MainPresenter()
        {
            this.timeManager.Stop();
            this.timeManager.TimeChanged -= OnTimeChanged;
            this.mainForm.StartClicked -= OnStartClicked;
            this.mainForm.StopClicked -= OnStopClicked;
            this.mainForm.ReadyClicked -= OnReadyClicked;
        }

        private void OnReadyClicked()
        {
            timeManager.ReadyToStart();
        }

        private void OnStartClicked()
        {
            timeManager.Start();
        }

        private void OnStopClicked()
        {
            timeManager.Stop();
        }

        private void OnTimeChanged(double time)
        {
            mainForm.RunningTime = time.ToString("N1");
        }

    }
}
