using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem.View
{
    interface IMainForm
    {
        event System.Action StartClicked;
        event System.Action StopClicked;
        event System.Action ReadyClicked;

        string RunningTime { set; }
    }
}
