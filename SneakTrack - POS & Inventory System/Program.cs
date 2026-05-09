using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new TESTDESIGNTEMP());
        }

    }

    public class MainSystem
    {

        public MainSystem()
        {
            this.wh = new WindowHandler();
            this.val = new Validator();
            this.dh = new DataHandler();
        }

        private WindowHandler wh;
        private Validator val;
        private DataHandler dh;

        public WindowHandler WH { get { return this.wh; } }
        public Validator VAL { get { return this.val; } }
        public DataHandler DH { get { return this.dh; } }
    }

}
