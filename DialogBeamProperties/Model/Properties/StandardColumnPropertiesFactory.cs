using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardColumnPropertiesFactory
    {
        public ColumnProperties CreateStandardProperties(string profile = "", double topRl = 0, double bottomRl = 0)
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
            columnProperties.AttributesClassText = "";
            columnProperties.PositionVerticalText = 0;
            columnProperties.PositionRotationText = 0;
            columnProperties.PositionHorizontalText = 0;
            columnProperties.PositionLevelsTopText = topRl;
            columnProperties.PositionLevelsBottomText = bottomRl;

            return columnProperties;
        }
    }
}