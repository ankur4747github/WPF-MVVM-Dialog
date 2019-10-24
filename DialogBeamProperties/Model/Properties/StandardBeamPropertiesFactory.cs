using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardBeamPropertiesFactory
    {
        public IBeamProperties CreateStandardProperties(string profile = "", double rotation = 0)
        {
            BeamProperties beamProperties = new BeamProperties();

            List<string> list = new List<string>() { "a", "b", "c", "d" };
            beamProperties.LoadDataComboBox = list;
            beamProperties.SelectedDataInLoadDataComboBox = list[0];
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

            beamProperties.NumberingSeriesPartPrefixText = "";
            beamProperties.NumberingSeriesPartStartNumberText = "";
            beamProperties.NumberingSeriesAssemblyPrefixText = "";
            beamProperties.NumberingSeriesAssemblyStartNumberText = "";
            beamProperties.AttributesNameText = "";
            beamProperties.AttributesProfileText = profile;
            beamProperties.AttributesMaterialText = "";
            beamProperties.AttributesFinishText = "";
            beamProperties.AttributesClassText = "";
            beamProperties.PositionOnPlaneText = 0;
            beamProperties.PositionRotationText = rotation;
            beamProperties.PositionAtDepthText = 0;

            return beamProperties;
        }
    }
}