using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    abstract class Controller
    {
        private MainSystem sys;

        Controller(MainSystem system)
        {
            this.sys = system;
        }


    }
}
