using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SneakTrack___POS___Inventory_System
{
    public class WindowHandler
    {
        private Login login;
        private MainDashboard dash;

        // Accesors and Mutators
        public Login Login { get => login; set => login = value; }
        public MainDashboard Dash { get => dash; set => dash = value; }

        public WindowHandler() { }

        public WindowHandler(Login login, MainDashboard dash)
        {
            this.login = login;
            this.dash = dash;
        }

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

    // Optional mabye remove nalang later on lmao
    public class Pallete
    {
        public static Color accent = Color.FromArgb(254, 182, 66);
        public static Color main = Color.FromArgb(238, 238, 238);
        public static Color black = Color.Black;
        public static Color white = Color.White;
    }
}
