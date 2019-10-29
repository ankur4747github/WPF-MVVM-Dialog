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
            BeamProperties prop = (new StandardBeamPropertiesFactory()).CreateStandardProperties();
            DummyBeamPropertyData(prop);
            ColumnProperties propColumn = (new StandardColumnPropertiesFactory()).CreateStandardProperties();
            DummyColumnProprtyData(propColumn);
        }

        private void DummyColumnProprtyData(ColumnProperties prop)
        {
            prop.AttributesProfileText = "RS";
            DialogColumnPropertiesViewModel viewModel = new DialogColumnPropertiesViewModel(new XDataWriterDummyImplementation(), prop, prop);
            testColumn = new DialogColumnProperties(viewModel);
            testColumn.Closing += TestColumn_Closing;
            testColumn.Show();
            this.Hide();
        }

        private void TestColumn_Closing(object sender, CancelEventArgs e)
        {
            // IColumnProperties prop = testColumn.GetPropertiesData();
        }

        private void DummyBeamPropertyData(BeamProperties prop)
        {
            prop.AttributesProfileText = "RS";
            BeamValuesGetterDummyImplementation beamValuesGetter = new BeamValuesGetterDummyImplementation();
            DialogBeamPropertiesViewModel viewModel = new DialogBeamPropertiesViewModel(new MemberModifierFactoryDummyImplementation(), prop, prop, beamValuesGetter);
            testBeam = new DialogBeamProperties.DialogBeamProperties(viewModel);
            testBeam.Closing += TestBeam_Closing;
            testBeam.Show();
            this.Hide();
        }

        private void TestBeam_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //IBeamProperties prop = testBeam.GetPropertiesData();
        }

        public void Dispose()
        {
        }
    }
}