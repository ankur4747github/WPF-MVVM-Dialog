using DialogBeamProperties.Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private DialogBeamProperties.DialogBeamProperties test;

        public MainWindow()
        {
            InitializeComponent();
            IProperties prop = new DialogBeamProperties.Model.Properties();
            SetTestDataIntoProperties(ref prop);
            test = new DialogBeamProperties.DialogBeamProperties(prop);
            test.Closing += Test_Closing;
            test.Show();
            this.Hide();
        }

        private void Test_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IProperties prop = test.GetPropertiesData();
        }

        private void SetTestDataIntoProperties(ref IProperties prop)
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