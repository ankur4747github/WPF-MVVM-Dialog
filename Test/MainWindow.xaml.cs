using DialogBeamProperties.Model;
using System;
using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        public MainWindow()
        {
            InitializeComponent();
            IProperties prop = new DialogBeamProperties.Model.Properties();
            DialogBeamProperties.DialogBeamProperties test = new DialogBeamProperties.DialogBeamProperties(prop);
            test.Show();
            this.Hide();
        }

        public void Dispose()
        {
        }
    }
}