using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClock.ViewModels
{
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Fields
        protected Models.ModelBase _calculationEngine;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        private void RaisePropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected void SetField<T>(out T field, T value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            RaisePropertyChanged(propertyName);
        }
        #endregion
    }
}
