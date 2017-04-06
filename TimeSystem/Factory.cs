using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSystem.View;

namespace TimeSystem
{
    public class Factory
    {
        public readonly TimeManager timeManager;

        public Main mainForm;

        private MainPresenter mainPresenter;

        public Factory()
        {
            IDevice device = new Device();
//            IDevice device = new DeviceSimulator();
            TimeReader timeReader = new TimeReader(device);
            timeManager = new TimeManager(timeReader);

            mainForm = new Main();
            mainPresenter = new MainPresenter(timeManager, mainForm);
        }
    }
}
