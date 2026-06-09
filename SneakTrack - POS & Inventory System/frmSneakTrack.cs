using System;
using System.Windows.Forms;

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
            skipLogin(true);
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

        // For Testing TODO: remove
        private void skipLogin(bool admin)
        {
            UserAuth.User account = dh.checkUserAuth(admin ? "admin" : "rolandslnt");
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
            this.val = new Validator(this);
            this.dh = new DataHandler(this);
            this.ua = new UserAuth(this);
            this.pc = new ProductController(this);
            this.fh = new FileHandler(this);
            this.uc = new UserController(this);
            this.sc = new SalesController(this);

            dh.initialize();
        }

        private WindowHandler wh;
        private Validator val;
        private DataHandler dh;
        private UserAuth ua;
        private ProductController pc;
        private FileHandler fh;
        private UserController uc;
        private SalesController sc;

        public WindowHandler WH { get { return this.wh; } }
        public Validator VAL { get { return this.val; } }
        public DataHandler DH { get { return this.dh; } }
        public UserAuth UA { get { return this.ua; } }
        public ProductController PC { get { return this.pc; } }
        public FileHandler FH { get { return this.fh; } }
        public UserController UC { get { return this.uc; } }
        public SalesController SC { get { return this.sc; } }
    }
}