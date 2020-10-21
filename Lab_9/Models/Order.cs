using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab99.Models
{
    public class Order
    {
        public int OrderID
        {
            get;
            set;

        }
        //Cust_ID, P_ID, Amount, Order_date time
        public int CustomerId
        {
            get;
            set;

        }
        public int ProductId
        {
            get;
            set;

        }
        public double Amount
        {
            get;
            set;

        }
        public DateTime Order_Date {
            get;
            set;
        }
        public Customer Customer {
            get;
            set;
        }
        public Product Product {
            get;
            set;
        }
    }
}
