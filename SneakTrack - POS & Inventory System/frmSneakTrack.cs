using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SneakTrack___POS___Inventory_System.UserAuth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SneakTrack___POS___Inventory_System
{
    public partial class frmSneakTrack : Form
    {
        // Mostly for ease of reference
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private UserAuth auth;
        private DataHandler dh;

        public frmSneakTrack() // Makes sure same sys throughout
        {
            InitializeComponent();
            sys = new MainSystem(userConLogin, userConMainDash);
            initialize();
            userConLogin.initialize(sys);
            userConMainDash.initialize(sys);
            skipLogin(true); // Testing only
        }

        private void frmSneakTrack_Load(object sender, EventArgs e)
        {

        }

        private void initialize()
        {
            v = sys.VAL;
            wh = sys.WH;
            auth = sys.UA;
            dh = sys.DH;
        }

        // For Testing
        private void skipLogin(bool admin)
        {
            User account = dh.checkUserAuth(admin ? "admin" : "rolandslnt");
            auth.CurrentUser = account;
            wh.Dash.start();
            wh.switchControl(userConLogin, userConMainDash);
        }

    }

    // Holds all classes used interchangeably by the system.
    public class MainSystem
    {
        public MainSystem(Login login, MainDashboard dash)
        {
            this.wh = new WindowHandler(login, dash);
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