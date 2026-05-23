using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAcoount : Form
    {

        Cashier cash;

        public frmLoginAcoount()
        {
            InitializeComponent();
            this.cash = new Cashier("Roland Orlando", "blacksilence", "thisisthis", "Junior Fixer Dept.");
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool valid = true;

            lbPasswordError.Visible = false;
            lbUsernameError.Visible = false;

            if (txbxUsername.Texts == null || txbxUsername.Texts.Trim() == "")
            {
                lbUsernameError.Visible = true;
                valid = false;
            }

            if (txbxPassword.Texts == null || txbxPassword.Texts.Trim() == "")
            {
                lbPasswordError.Visible = true;
                valid = false;
            }

            if (!valid)
            {
                return;
            }


            if (!cash.validateLogin(txbxUsername.Texts.Trim(), txbxPassword.Texts.Trim()))
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show($"Login successful! Welcome, {cash.getFullName()} from {cash.getDepartment()}", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmPurchaseDiscountedItem form = new frmPurchaseDiscountedItem();
                form.Show();
            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
