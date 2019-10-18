using DialogBeamProperties.Constants;
using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DialogBeamProperties.View
{
    /// <summary>
    /// Interaction logic for SelectProfile.xaml
    /// </summary>
    public partial class SelectProfile : Window, IDisposable
    {
        public SelectProfileViewModel ViewModel = new SelectProfileViewModel();
        public SelectProfile()
        {
            InitializeComponent();
            InitMessenger();
            this.DataContext = ViewModel;
        }
        private void InitMessenger()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSESELECTPROFILEWINDOW, CloseWindow);
            Messenger.Default.Register<bool>(this,
                MessengerToken.CLOSESELECTPROFILEWINDOW, CloseWindow);
        }

        private void CloseWindow(bool obj)
        {
            this.Close();
        }

        internal void SetData(ProfileFileData allProfileFileData, string attributesProfileText)
        {
            ViewModel.SetData(allProfileFileData, attributesProfileText);
        }

        public void Dispose()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSESELECTPROFILEWINDOW, CloseWindow);
        }
    }
}
