﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GISKommunikation.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        // Felder
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;
        
        // Costructors
        public ViewModelCommand(Action<object> executeAction)
        {   _executeAction = executeAction;
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        { 
            _canExecuteAction = canExecuteAction;
            _executeAction = executeAction;
        }

        // Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested+= value; }
            remove { CommandManager.RequerySuggested -= value;}

        }

        // Methods
        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null ? true:_canExecuteAction(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction(parameter);
        }
    }
}
