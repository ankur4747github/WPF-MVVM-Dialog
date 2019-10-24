using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public class StandardColumnPropertiesFactory
    {
        public IColumnProperties CreateStandardProperties(string profile = "", double topRl = 0, double bottomRl = 0)
        {
            IColumnProperties columnProperties = new ColumnProperties();

            List<string> list = new List<string>() { "a", "b", "c", "d" };

            columnProperties.LoadDataComboBox = list;
            columnProperties.SelectedDataInLoadDataComboBox = list[0];
            columnProperties.IsAttributesProfileChecked = true;
            columnProperties.AttributesProfileText = "H100";

            List<string> verticleList = new List<string>() { "Middle", "Right", "Left" };
            columnProperties.PositionVerticalComboBox = verticleList;
            columnProperties.SelectedDataInPositionVerticalComboBox = verticleList[0];

            List<string> rotationList = new List<string>() { "Front", "Top", "Back", "Below" };
            columnProperties.PositionRotationComboBox = rotationList;
            columnProperties.SelectedDataInPositionRotationComboBox = rotationList[0];

            List<string> horizontalList = new List<string>() { "Middle", "Front", "Behind" };
            columnProperties.PositionHorizontalComboBox = horizontalList;
            columnProperties.SelectedDataInPositionHorizontalComboBox = horizontalList[0];

            columnProperties.IsNumberingSeriesPartPrefixChecked = true;
            columnProperties.NumberingSeriesPartPrefixText = "";
            columnProperties.IsNumberingSeriesPartStartumberChecked = true;
            columnProperties.NumberingSeriesPartStartNumberText = "";
            columnProperties.IsNumberingSeriesAssemblyPrefixChecked = true;
            columnProperties.NumberingSeriesAssemblyPrefixText = "";
            columnProperties.IsNumberingSeriesAssemblyStartumberChecked = true;
            columnProperties.NumberingSeriesAssemblyStartNumberText = "";
            columnProperties.IsAttributesNameChecked = true;
            columnProperties.AttributesNameText = "";
            columnProperties.IsAttributesProfileChecked = true;
            columnProperties.AttributesProfileText = profile;
            columnProperties.IsAttributesMaterialChecked = true;
            columnProperties.AttributesMaterialText = "";
            columnProperties.IsAttributesFinishChecked = true;
            columnProperties.AttributesFinishText = "";
            columnProperties.IsAttributesClassChecked = true;
            columnProperties.AttributesClassText = "";
            columnProperties.PositionVerticalText = 0;
            columnProperties.PositionRotationText = 0;
            columnProperties.PositionHorizontalText = 0;
            columnProperties.IsPositionLevelsTopChecked = true;
            columnProperties.PositionLevelsTopText = topRl;
            columnProperties.IsPositionLevelsBottomChecked = true;
            columnProperties.PositionLevelsBottomText = bottomRl;

            return columnProperties;
        }
    }
}