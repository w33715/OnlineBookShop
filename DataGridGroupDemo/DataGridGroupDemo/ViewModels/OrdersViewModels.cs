using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridGroupDemo.Models;
using System.ComponentModel;
using DataGridGroupDemo.Commands;

using System.Windows.Data;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Globalization;

namespace DataGridGroupDemo.ViewModels
{
    public class OrdersViewModels
    {
        public ICollectionView OrdersView { get; set; }
        public OrdersViewModels() 
        {
         IList<Order> orders= new Orders();
            OrdersView=CollectionViewSource.GetDefaultView(orders);
            OrdersView.GroupDescriptions.Add(new PropertyGroupDescription("NoGroup"));
            GroupByCustomerCommand = new GroupByCustomerCommand(this);
            GroupByYearMonthCommand= new GroupByYearMonthCommand(this);
            RemoveGroupCommand= new RemoveGroupCommand(this);
        }
        public void RemoveGroup()
        {
            OrdersView.GroupDescriptions.Clear();
            OrdersView.GroupDescriptions.Add(new PropertyGroupDescription("NoGroup"));
        }
        public void GroupByCustomer()
        {
            OrdersView.GroupDescriptions.Clear();
            OrdersView.GroupDescriptions.Add(new PropertyGroupDescription("Customer"));
        }
        public void GroupByYearMonth()
        {
            OrdersView.GroupDescriptions.Clear();
            OrdersView.GroupDescriptions.Add(new PropertyGroupDescription("OrderYearMonth"));
        }
        public ICommand GroupByCustomerCommand
        {
            get;
            private set;
        }
        public ICommand GroupByYearMonthCommand
        {
            get;
            private set;
        }
        public ICommand RemoveGroupCommand
        {
            get;
            private set;
        }

                
    }
    public class GroupToTotalConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (value is ReadOnlyObservableCollection<object> )
            {

                var item = (ReadOnlyObservableCollection<object>)value;

                Decimal total = 0;
               
                foreach (Order element in item) 
                {
                    total += element.Amount;                   
                }
               
                return total.ToString();
               
            }
            return "";
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
