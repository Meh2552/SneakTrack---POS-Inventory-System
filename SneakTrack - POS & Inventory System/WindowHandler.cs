using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class WindowHandler
    {

        public void switchControl(Control from, Control to)
        {
            from.Visible = false;
            to.Visible = true;
            to.BringToFront();
        }

        public void changeLbTxt(Label label, string txt)
        {
            label.Visible = true;
            label.Text = txt;
        }

    }
}
