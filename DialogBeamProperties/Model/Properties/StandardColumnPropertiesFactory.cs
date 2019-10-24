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