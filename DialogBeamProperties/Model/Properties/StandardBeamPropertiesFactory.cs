using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardBeamPropertiesFactory
    {
        public BeamProperties CreateStandardProperties(string profile = "", double rotation = 0, int color = 0, string rotationEnum = "")
        {
            BeamProperties beamProperties = new BeamProperties();

            beamProperties.AttributesProfileText = "H100";
            beamProperties.NumberingSeriesPartPrefixText = "";
            beamProperties.NumberingSeriesPartStartNumberText = "";
            beamProperties.NumberingSeriesAssemblyPrefixText = "";
            beamProperties.NumberingSeriesAssemblyStartNumberText = "";
            beamProperties.AttributesNameText = "";
            beamProperties.AttributesProfileText = profile;
            beamProperties.AttributesMaterialText = "";
            beamProperties.AttributesFinishText = "";
            beamProperties.AttributesClassText = color;
            beamProperties.PositionOnPlaneText = 0;
            beamProperties.PositionRotationText = rotation;
            beamProperties.PositionAtDepthText = 0;
            beamProperties.SelectedDataInPositionRotationComboBox = rotationEnum;

            return beamProperties;
        }
    }
}