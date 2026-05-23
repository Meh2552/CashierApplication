using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Namespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount * 0.01;
        }

        public override double getTotalPrice()
        {
            discounted_price = base.getTotalPrice() - (base.getTotalPrice() * item_discount);
            return discounted_price;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - discounted_price;
            return change;
        }
    }
}
