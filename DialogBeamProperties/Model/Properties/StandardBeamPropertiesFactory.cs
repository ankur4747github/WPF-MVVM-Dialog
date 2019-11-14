using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardBeamPropertiesFactory
    {
        public BeamProperties CreateStandardProperties(string profile, double rotation, int color, string rotationEnum, string depthEnum, double depthOffset, string planeEnum, double planeOffset, string finish, string material, string name)
        {
            BeamProperties beamProperties = new BeamProperties();

            beamProperties.AttributesProfileText = "H100";
            beamProperties.NumberingSeriesPartPrefixText = "";
            beamProperties.NumberingSeriesPartStartNumberText = "";
            beamProperties.NumberingSeriesAssemblyPrefixText = "";
            beamProperties.NumberingSeriesAssemblyStartNumberText = "";
            beamProperties.AttributesNameText = name;
            beamProperties.AttributesProfileText = profile;
            beamProperties.AttributesMaterialText = material;
            beamProperties.AttributesFinishText = finish;
            beamProperties.AttributesClassText = color;
            beamProperties.PositionOnPlaneText = planeOffset;
            beamProperties.PositionRotationText = rotation;
            beamProperties.PositionAtDepthText = depthOffset;
            beamProperties.SelectedDataInPositionRotationComboBox = rotationEnum;
            beamProperties.SelectedDataInPositionOnPlaneComboBox = planeEnum;
            beamProperties.SelectedDataInPositionAtDepthComboBox = depthEnum;
            return beamProperties;
        }
    }
}