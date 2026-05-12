using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // remove if needed

namespace SneakTrack___POS___Inventory_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainSystem system = new MainSystem();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmSneakTrack(system));
        }

    }

    public class MainSystem
    {

        public MainSystem()
        {
            this.wh = new WindowHandler();
            this.val = new Validator();
            this.dh = new DataHandler(this);
            this.ua = new UserAuth(this);
        }

        private WindowHandler wh;
        private Validator val;
        private DataHandler dh;
        private UserAuth ua;

        public WindowHandler WH { get { return this.wh; } }
        public Validator VAL { get { return this.val; } }
        public DataHandler DH { get { return this.dh; } }
        public UserAuth UA { get { return this.ua; } }
    }
}
