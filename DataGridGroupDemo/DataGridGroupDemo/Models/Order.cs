using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace DataGridGroupDemo.Models
{
  public class Order
  {
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
        public DateTime Datum { get; set; }
        public string OrderYearMonth
        {
            get
            { return string.Format("{1:000}-{0:00}", Datum.Month, Datum.Year); }
        }
        public string NoGroup
        {
            get
            {
                return "Total:";
            }
        }
      
  }
    public class Orders:ObservableCollection<Order> 
    {
        public Orders()
        {
            this.Add(new Order
            {
                OrderNumber = "0001",
                Customer = "IBM",
                Amount = 250,
                Datum = new DateTime(2015, 1, 25)
            });
            this.Add(new Order
            {
                OrderNumber = "0002",
                Customer = "Microsoft",
                Amount = 3000,
                Datum = new DateTime(2015, 1, 26)
            });
            this.Add(new Order
            {
                OrderNumber = "0003",
                Customer = "Google",
                Amount = 20,
                Datum = new DateTime(2015, 1, 26)
            });
            this.Add(new Order
            {
                OrderNumber = "0004",
                Customer = "IBM",
                Amount = 240,
                Datum = new DateTime(2015, 1, 28)
            });
            this.Add(new Order
            {
                OrderNumber = "0005",
                Customer = "IBM",
                Amount = 250,
                Datum = new DateTime(2015, 2, 25)
            });
            this.Add(new Order
            {
                OrderNumber = "0006",
                Customer = "IBM",
                Amount = 250,
                Datum = new DateTime(2015, 3, 25)
            });
        }
    
    }
}
