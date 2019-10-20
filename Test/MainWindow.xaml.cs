using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Model;
using DialogBeamProperties.Model.Properties;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel;
using System;
using System.Collections.Generic;
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

            IBeamProperties prop = new DialogBeamProperties.Model.BeamProperties();
            SetTestDataIntoProperties(ref prop);
            DummyBeamPropertyData(prop);

            IColumnProperties propColumn = new ColumnProperties();
            SetTestDataIntoColumnProperties(ref propColumn);
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

        private void SetTestDataIntoColumnProperties(ref IColumnProperties prop)
        {
            List<string> list = new List<string>() { "a", "b", "c", "d" };

            prop.LoadDataComboBox = list;
            prop.SelectedDataInLoadDataComboBox = list[0];
            prop.IsAttributesProfileChecked = true;
            prop.AttributesProfileText = "H100";

            List<string> verticleList = new List<string>() { "Middle", "Right", "Left" };
            prop.PositionVerticalComboBox = verticleList;
            prop.SelectedDataInPositionVerticalComboBox = verticleList[0];

            List<string> rotationList = new List<string>() { "Front", "Top", "Back", "Below" };
            prop.PositionRotationComboBox = rotationList;
            prop.SelectedDataInPositionRotationComboBox = rotationList[0];

            List<string> horizontalList = new List<string>() { "Middle", "Front", "Behind" };
            prop.PositionHorizontalComboBox = horizontalList;
            prop.SelectedDataInPositionHorizontalComboBox = horizontalList[0];

            prop.IsNumberingSeriesPartPrefixChecked = true;
            prop.NumberingSeriesPartPrefixText = "PartPrefix";
            prop.IsNumberingSeriesPartStartumberChecked = true;
            prop.NumberingSeriesPartStartNumberText = "PartStartNumber";
            prop.IsNumberingSeriesAssemblyPrefixChecked = true;
            prop.NumberingSeriesAssemblyPrefixText = "AssemblyPrefix";
            prop.IsNumberingSeriesAssemblyStartumberChecked = true;
            prop.NumberingSeriesAssemblyStartNumberText = "AssemblyStartNumber";
            prop.IsAttributesNameChecked = true;
            prop.AttributesNameText = "AttributesName";
            prop.IsAttributesProfileChecked = true;
            prop.AttributesProfileText = "AttributesProfile";
            prop.IsAttributesMaterialChecked = true;
            prop.AttributesMaterialText = "AttributesMaterial";
            prop.IsAttributesFinishChecked = true;
            prop.AttributesFinishText = "AttributesFinish";
            prop.IsAttributesClassChecked = true;
            prop.AttributesClassText = "AttributesClass";
            prop.PositionVerticalText = "PositionVerticle";
            prop.PositionRotationText = "PositionRotation";
            prop.PositionHorizontalText = "PositionHorizontal";
            prop.IsPositionLevelsTopChecked = true;
            prop.PositionLevelsTopText = "Top";
            prop.IsPositionLevelsBottomChecked = true;
            prop.PositionLevelsBottomText = "Bottom";
        }

        private void SetTestDataIntoProperties(ref IBeamProperties prop)
        {
            List<string> list = new List<string>() { "a", "b", "c", "d" };

            prop.LoadDataComboBox = list;
            prop.SelectedDataInLoadDataComboBox = list[0];
            prop.IsAttributesProfileChecked = true;
            prop.AttributesProfileText = "H100";

            List<string> onPlaneList = new List<string>() { "Middle", "Right", "Left" };
            prop.PositionOnPlaneComboBox = onPlaneList;
            prop.SelectedDataInPositionOnPlaneComboBox = onPlaneList[0];

            List<string> rotationList = new List<string>() { "Front", "Top", "Back", "Below" };
            prop.PositionRotationComboBox = rotationList;
            prop.SelectedDataInPositionRotationComboBox = rotationList[0];

            List<string> atDepthList = new List<string>() { "Middle", "Front", "Behind" };
            prop.PositionAtDepthComboBox = atDepthList;
            prop.SelectedDataInPositionAtDepthComboBox = atDepthList[0];

            prop.IsNumberingSeriesPartPrefixChecked = true;
            prop.NumberingSeriesPartPrefixText = "PartPrefix";
            prop.IsNumberingSeriesPartStartumberChecked = true;
            prop.NumberingSeriesPartStartNumberText = "PartStartNumber";
            prop.IsNumberingSeriesAssemblyPrefixChecked = true;
            prop.NumberingSeriesAssemblyPrefixText = "AssemblyPrefix";
            prop.IsNumberingSeriesAssemblyStartumberChecked = true;
            prop.NumberingSeriesAssemblyStartNumberText = "AssemblyStartNumber";
            prop.IsAttributesNameChecked = true;
            prop.AttributesNameText = "AttributesName";
            prop.IsAttributesProfileChecked = true;
            prop.AttributesProfileText = "AttributesProfile";
            prop.IsAttributesMaterialChecked = true;
            prop.AttributesMaterialText = "AttributesMaterial";
            prop.IsAttributesFinishChecked = true;
            prop.AttributesFinishText = "AttributesFinish";
            prop.IsAttributesClassChecked = true;
            prop.AttributesClassText = "AttributesClass";
            prop.PositionOnPlaneText = "PositionOnPlane";
            prop.PositionRotationText = "PositionRotation";
            prop.PositionAtDepthText = "PositionAtDepth";
        }

        public void Dispose()
        {
        }
    }
}