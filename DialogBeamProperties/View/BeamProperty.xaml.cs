using DialogBeamProperties.CadInterfaces;
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
        private DialogBeamPropertiesViewModel viewModel;

        public DialogBeamProperties(IBeamProperties iproperties, DialogBeamPropertiesViewModel viewModel)
        {
            InitializeComponent();
            InitMessenger();
            this.viewModel = viewModel;
            this.DataContext = viewModel;
            this.viewModel.SetPropertiesData(iproperties);
        }

        public IBeamProperties GetPropertiesData()
        {
            return viewModel.GetPropertiesData();
        }

        private void InitMessenger()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSEBEAMPROPERTYWINDOW, CloseWindow);
            Messenger.Default.Register<bool>(this,
                MessengerToken.CLOSEBEAMPROPERTYWINDOW, CloseWindow);
        }

        private void CloseWindow(bool obj)
        {
            this.Close();
        }

        public void Dispose()
        {
            Messenger.Default.Unregister<bool>(this,
                    MessengerToken.CLOSEBEAMPROPERTYWINDOW, CloseWindow);
        }
    }
}