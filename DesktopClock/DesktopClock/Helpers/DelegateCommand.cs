using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopClock.Helpers
{
    internal class DelegateCommand : ICommand
    {
        #region Fields
        private Action _action;
#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public DelegateCommand(Action action)
        {
            _action = action;
        }
        #endregion

        #region Commands
        #endregion

        #region Methods
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _action.Invoke();
        }
        #endregion
    }
}
