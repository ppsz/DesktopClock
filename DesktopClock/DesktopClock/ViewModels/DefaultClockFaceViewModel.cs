using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClock.ViewModels
{
    class DefaultClockFaceViewModel : ViewModelBase
    {
        #region Fields
        #endregion

        #region Properties
        #region BackgroundOpacity Property
        private float _backgroundOpacity;
        public float BackgroundOpacity
        {
            get => _backgroundOpacity;
            set => SetField(out _backgroundOpacity, value);
        }
        #endregion
        #region CurrentDate Property
        private string _currentDate;
        public string CurrentDate
        {
            get => _currentDate;
            set => SetField(out _currentDate, value);
        }
        #endregion
        #endregion

        #region Constructors
        public DefaultClockFaceViewModel()
        {
            BackgroundOpacity = 0.25f;
            var date = DateTime.Now;
            CurrentDate = $"{date.ToString("dd MMMM yyyy")}{Environment.NewLine}{date.ToString("dddd")}";
        }
        #endregion

        #region Commands
        #endregion

        #region Methods
        #endregion


    }
}
