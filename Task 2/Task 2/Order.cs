using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public double TotalPrice => CalculateTotalPrice();
        public DateTime Date { get; set; }

        private double CalculateTotalPrice()
        {
            double totalprice = 0;
            foreach (var product in Products)
            {
                totalprice += product.Price * product.Count;
            }

            double discountRate = 0;
            if (totalprice < 100)
            {
                discountRate = 0;
            }
            else if (totalprice >= 100 && totalprice <= 200)
            {
                discountRate = 10;
            }
            else
            {
                discountRate = 20;
            }

            return totalprice - ((totalprice * discountRate) / 100);

        }
    }
}