using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System.UIControls
{
    public partial class OrderCalculationPrompt : Form
    {
        private MainSystem sys;
        private Validator v;

        private decimal due = 0;
        private decimal payment = 0;

        public decimal Payment { get { return payment; } }

        public OrderCalculationPrompt()
        {
            InitializeComponent();
        }

        public OrderCalculationPrompt(MainSystem system, decimal total)
        {
            InitializeComponent();
            this.sys = system;
            this.v = sys.VAL;

            initialize(total);
        }

        private void initialize(decimal total)
        {
            this.due = total;
            lbAmountDue.Text = $"Amount due: {due.ToString("0.00")}";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Cancelling Payment";
            confirm.Prompt = "Are you sure you want to cancel the payment?";
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK)
            {
                this.DialogResult = results;
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;

            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Payment";
            confirm.Prompt = $"Confirm ₱ {payment.ToString("0.00")} as the amount paid?";
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK)
            {
                this.DialogResult = results;
                this.Close();
            }
        }

        private bool validateFields()
        {
            lbPaymentError.Visible = false;
            bool isValid = true;
            decimal paid = v.readDecimal(txbxPayment.Texts);

            if (paid < 0)
            {
                MessageBox.Show("Invalid payment input", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (paid < due)
            {
                lbPaymentError.Text = "Insufficient amount paid.";
                lbPaymentError.Visible = true;
                isValid = false;
            }

            payment = paid;
            return isValid;
        }

        private long rawInput = 0;
        private bool isUpdating = false;

        private void txbxPayment__TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; 

            decimal pay = v.readDecimal(txbxPayment.Texts);
            if (pay < 0 || pay > 999999999.99m)
            {
                MessageBox.Show("Invalid payment input", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updatePaymentDisplay();
                return;
            }
            rawInput = (long)(pay * 100);
        }

        private void attachToPayment(string num)
        {
            string digits = rawInput.ToString() + num;

            if (digits.Length > 12) return;

            rawInput = long.Parse(digits);
            updatePaymentDisplay();
        }

        private void addToPayment(int num)
        {
            string digits = (rawInput + (num * 100)).ToString();

            if (digits.Length > 12) return;

            rawInput = long.Parse(digits);
            updatePaymentDisplay();
        }

        private void updatePaymentDisplay()
        {
            isUpdating = true;
            decimal value = rawInput / 100m;
            txbxPayment.Texts = value.ToString("0.00");
            isUpdating = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string digits = rawInput.ToString();
            if (digits.Length <= 1) { rawInput = 0; }
            else rawInput = long.Parse(digits.Substring(0, digits.Length - 1));
            updatePaymentDisplay();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rawInput = 0;
            updatePaymentDisplay();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            attachToPayment("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            attachToPayment("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            attachToPayment("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            attachToPayment("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            attachToPayment("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            attachToPayment("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            attachToPayment("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            attachToPayment("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            attachToPayment("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            attachToPayment("9");
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            attachToPayment("00");
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            attachToPayment("000");
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            addToPayment(50);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            addToPayment(100);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            addToPayment(500);
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            addToPayment(1000);
        }
    }
}
