using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Namespace
{
    public class Item
    {

        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item() { }
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public virtual double getTotalPrice()
        {
            total_price = item_price * item_quantity;
            return total_price;
        }

        public virtual void setPayment(double amount)
        {

        }
    }
}
