using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Item_Namespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        Item itm = new Item();

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
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

            label1.Visible = false;
            lbPriceError.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            double discount = validateDouble(txbxBrand.Texts);
            double price = validateDouble(txbxPrice.Texts);
            int quantity = validateInt(txbxColor.Texts);
            double recieved = validateDouble(txbxRecieved.Texts);

            if (txbxItem.Texts == null || txbxItem.Texts.Trim() == "")
            {
                label5.Visible = true;
                valid = false;
            }

            if (discount < 0 || discount > 100)
            {
                label1.Visible = true;
                valid = false;
            }

            if (price < 0)
            {
                lbPriceError.Visible = true;
                valid = false;
            }

            if (quantity <= 0)
            {
                label3.Visible = true;
                valid = false;
            }

            if (!valid)
            {
                return;
            }

            DiscountedItem di = new DiscountedItem(txbxItem.Texts, price, quantity, discount);
            di.setPayment(recieved);

            if (di.getTotalPrice() > recieved)
            {
                label4.Visible = true;
                return;
            }

            txbxAmount.Text = di.getTotalPrice().ToString();
            txbxChange.Text = di.getChange().ToString();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double validateDouble(string value)
        {
            double result;
            if (double.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }

        private int validateInt(string value)
        {
            int result;
            if (int.TryParse(txbxColor.Texts, out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
