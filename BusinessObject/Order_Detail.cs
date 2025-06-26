using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order_Detail
    {
        public int OrderID {  get; set; }
        public int ProductID { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity {  get; set; }

        public double Discount { get; set; }

        public override string ToString()
        {
            return OrderID+"\t"+ ProductID +"\t" + UnitPrice+"\t" + Quantity+"\t" + Discount;
        }
    }
}
