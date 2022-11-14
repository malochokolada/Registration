using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationWindow.Command
{
    public class RelativeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public RelativeCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelativeCommand(Action<object> execute) : this(execute, null)
        {

        }

        public bool CanExecute(object parametr)
        {
            if (_canExecute != null) return _canExecute(parametr);
            else return true;
        }


        public void Execute(object parametr)
        {
            _execute?.Invoke(parametr);
        }

    }
}
