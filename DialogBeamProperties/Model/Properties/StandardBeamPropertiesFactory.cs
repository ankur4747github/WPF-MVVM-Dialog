using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardBeamPropertiesFactory
    {
        public IBeamProperties CreateStandardProperties()
        {
            BeamProperties beamProperties = new BeamProperties();

            List<string> list = new List<string>() { "a", "b", "c", "d" };
            beamProperties.LoadDataComboBox = list;
            beamProperties.SelectedDataInLoadDataComboBox = list[0];
            beamProperties.IsAttributesProfileChecked = true;
            beamProperties.AttributesProfileText = "H100";

            List<string> onPlaneList = new List<string>() { "Middle", "Right", "Left" };
            beamProperties.PositionOnPlaneComboBox = onPlaneList;
            beamProperties.SelectedDataInPositionOnPlaneComboBox = onPlaneList[0];

            List<string> rotationList = new List<string>() { "Front", "Top", "Back", "Below" };
            beamProperties.PositionRotationComboBox = rotationList;
            beamProperties.SelectedDataInPositionRotationComboBox = rotationList[0];

            List<string> atDepthList = new List<string>() { "Middle", "Front", "Behind" };
            beamProperties.PositionAtDepthComboBox = atDepthList;
            beamProperties.SelectedDataInPositionAtDepthComboBox = atDepthList[0];

            beamProperties.IsNumberingSeriesPartPrefixChecked = true;
            beamProperties.NumberingSeriesPartPrefixText = "";
            beamProperties.IsNumberingSeriesPartStartumberChecked = true;
            beamProperties.NumberingSeriesPartStartNumberText = "";
            beamProperties.IsNumberingSeriesAssemblyPrefixChecked = true;
            beamProperties.NumberingSeriesAssemblyPrefixText = "";
            beamProperties.IsNumberingSeriesAssemblyStartumberChecked = true;
            beamProperties.NumberingSeriesAssemblyStartNumberText = "";
            beamProperties.IsAttributesNameChecked = true;
            beamProperties.AttributesNameText = "";
            beamProperties.IsAttributesProfileChecked = true;
            beamProperties.AttributesProfileText = "";
            beamProperties.IsAttributesMaterialChecked = true;
            beamProperties.AttributesMaterialText = "";
            beamProperties.IsAttributesFinishChecked = true;
            beamProperties.AttributesFinishText = "";
            beamProperties.IsAttributesClassChecked = true;
            beamProperties.AttributesClassText = "";
            beamProperties.PositionOnPlaneText = 0;
            beamProperties.PositionRotationText = 0;
            beamProperties.PositionAtDepthText = 0;

            return beamProperties;
        }
    }
}