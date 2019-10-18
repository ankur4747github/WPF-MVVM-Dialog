using DialogBeamProperties.Constants;
using DialogBeamProperties.Model;
using DialogBeamProperties.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows;

namespace DialogBeamProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DialogBeamProperties : Window, IDisposable
    {
        public DialogBeamPropertiesViewModel ViewModel = new DialogBeamPropertiesViewModel();

        public DialogBeamProperties(IProperties iproperties)
        {
            InitializeComponent();
            InitMessenger();
            this.DataContext = ViewModel;
            ViewModel.SetProtertiesData(iproperties);
        }

        public IProperties GetPropertiesData()
        {
            return ViewModel.GetPropertiesData();
        }

        private void InitMessenger()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSEWINDOW, CloseWindow);
            Messenger.Default.Register<bool>(this,
                MessengerToken.CLOSEWINDOW, CloseWindow);
        }

        private void CloseWindow(bool obj)
        {
            this.Close();
        }

        public void Dispose()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSEWINDOW, CloseWindow);
        }
    }
}