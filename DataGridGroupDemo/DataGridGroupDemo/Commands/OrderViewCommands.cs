using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataGridGroupDemo.ViewModels;

namespace DataGridGroupDemo.Commands
{
   public class RemoveGroupCommand:ICommand
    {
        
        #region ICommand implementation
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this._viewModel.RemoveGroup();
        }
        #endregion
        private OrdersViewModels _viewModel;
        public RemoveGroupCommand(OrdersViewModels viewModel)
        {
            _viewModel = viewModel;
        }
    }
    public class GroupByCustomerCommand : ICommand
    {

        #region ICommand implementation
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this._viewModel.GroupByCustomer();
        }
        #endregion
        private OrdersViewModels _viewModel;
        public GroupByCustomerCommand(OrdersViewModels viewModel)
        {
            _viewModel = viewModel;
        }
    }
}
public class GroupByYearMonthCommand : ICommand
{

    #region ICommand implementation
    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        this._viewModel.GroupByYearMonth();
    }
    #endregion
    private OrdersViewModels _viewModel;
    public GroupByYearMonthCommand(OrdersViewModels viewModel)
    {
        _viewModel = viewModel;
    }
}
