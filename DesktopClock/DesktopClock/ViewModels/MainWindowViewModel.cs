using DesktopClock.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopClock.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        #endregion

        #region Properties
        #region Menu Property
        private UserControl _menu;
        public UserControl Menu
        {
            get => _menu;
            set => SetField(out _menu, value);
        }
        #endregion
        #region Face Property
        private UserControl _face;
        public UserControl Face
        {
            get => _face;
            set => SetField(out _face, value);
        }
        #endregion
        #endregion

        #region Constructors
        public MainWindowViewModel()
        {
            Menu = new MainMenuView();
            Face = new DefaultClockFaceView();
        }
        #endregion

        #region Commands
        #endregion

        #region Methods
        #endregion
    }
}
