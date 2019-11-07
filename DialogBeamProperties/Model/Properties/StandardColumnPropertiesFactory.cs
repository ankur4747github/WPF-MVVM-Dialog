using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardColumnPropertiesFactory
    {
        public ColumnProperties CreateStandardProperties(string profile = "", double rotation = 0, int color = 0, double topRl = 0, double bottomRl = 0, string rotationEnum = "", string depthEnum = "", double depthOffset = 0, string planeEnum = "", double planeOffset = 0)
        {
            ColumnProperties columnProperties = new ColumnProperties();
            columnProperties.AttributesProfileText = "H100";
            columnProperties.NumberingSeriesPartPrefixText = "";
            columnProperties.NumberingSeriesPartStartNumberText = "";
            columnProperties.NumberingSeriesAssemblyPrefixText = "";
            columnProperties.NumberingSeriesAssemblyStartNumberText = "";
            columnProperties.AttributesNameText = "";
            columnProperties.AttributesProfileText = profile;
            columnProperties.AttributesMaterialText = "";
            columnProperties.AttributesFinishText = "";
            columnProperties.AttributesClassText = color;
            columnProperties.PositionVerticalText = planeOffset;
            columnProperties.PositionRotationText = rotation;
            columnProperties.PositionHorizontalText = depthOffset;
            columnProperties.PositionLevelsTopText = topRl;
            columnProperties.PositionLevelsBottomText = bottomRl;
            columnProperties.SelectedDataInPositionRotationComboBox = rotationEnum;
            columnProperties.SelectedDataInPositionVerticalComboBox = planeEnum;
            columnProperties.SelectedDataInPositionHorizontalComboBox = depthEnum;
            return columnProperties;
        }
    }
}