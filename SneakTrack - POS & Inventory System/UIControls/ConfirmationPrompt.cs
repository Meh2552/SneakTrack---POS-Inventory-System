using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System.UIControls
{
    public partial class ConfirmationPrompt : Form
    {
        private string prompt;
        private string header;
        private string button1Txt;
        private string button2Txt;

        public ConfirmationPrompt()
        {
            InitializeComponent();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        [Category("Prompt Fields")]
        public string Prompt
        {
            get { return prompt; }
            set 
            { 
                prompt = value;
                lbPrompt.Text = prompt;
            }
        }

        [Category("Prompt Fields")]
        public string Header
        {
            get { return header; }
            set 
            { 
                header = value;
                lbHeader.Text = header;
            }
        }

        [Category("Prompt Fields")]
        public string Button1Text
        {
            get { return button1Txt; }
            set 
            { 
                button1Txt = value; 
                btnConfirm.Text = button1Txt;
            }
        }

        [Category("Prompt Fields")]
        public string Button2Text
        {
            get { return button2Txt; }
            set 
            { 
                button2Txt = value; 
                btnExit.Text = button2Txt;
            }
        }


        // TODO: do this if u have time idk
        private void btnChanges_Click(object sender, EventArgs e)
        {

        }
    }
}
