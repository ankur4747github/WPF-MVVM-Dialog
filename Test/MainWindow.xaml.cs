using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Model;
using DialogBeamProperties.Model.Properties;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel;
using System;
using System.ComponentModel;
using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private DialogBeamProperties.DialogBeamProperties testBeam;
        private DialogColumnProperties testColumn;

        public MainWindow()
        {
            InitializeComponent();
            IBeamProperties prop = (new StandardBeamPropertiesFactory()).CreateStandardProperties();
            DummyBeamPropertyData(prop);
            IColumnProperties propColumn = (new StandardColumnPropertiesFactory()).CreateStandardProperties();
            DummyColumnProprtyData(propColumn);
        }

        private void DummyColumnProprtyData(IColumnProperties prop)
        {
            DialogColumnPropertiesViewModel viewModel = new DialogColumnPropertiesViewModel(new XDataWriterDummyImplementation());
            testColumn = new DialogColumnProperties(prop, viewModel);
            testColumn.Closing += TestColumn_Closing;
            testColumn.Show();
            this.Hide();
        }

        private void TestColumn_Closing(object sender, CancelEventArgs e)
        {
            IColumnProperties prop = testColumn.GetPropertiesData();
        }

        private void DummyBeamPropertyData(IBeamProperties prop)
        {
            DialogBeamPropertiesViewModel viewModel = new DialogBeamPropertiesViewModel(new XDataWriterDummyImplementation());
            testBeam = new DialogBeamProperties.DialogBeamProperties(prop, viewModel);
            testBeam.Closing += TestBeam_Closing;
            testBeam.Show();
            this.Hide();
        }

        private void TestBeam_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IBeamProperties prop = testBeam.GetPropertiesData();
        }

        public void Dispose()
        {
        }
    }
}