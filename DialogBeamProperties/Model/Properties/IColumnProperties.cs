using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public interface IColumnProperties
    {
        //Attributes Tab Data
        List<string> LoadDataComboBox { get; set; }

        string SelectedDataInLoadDataComboBox { get; set; }
        bool IsNumberingSeriesPartPrefixChecked { get; set; }
        string NumberingSeriesPartPrefixText { get; set; }
        bool IsNumberingSeriesPartStartumberChecked { get; set; }
        string NumberingSeriesPartStartNumberText { get; set; }
        bool IsNumberingSeriesAssemblyPrefixChecked { get; set; }
        string NumberingSeriesAssemblyPrefixText { get; set; }
        bool IsNumberingSeriesAssemblyStartumberChecked { get; set; }
        string NumberingSeriesAssemblyStartNumberText { get; set; }

        bool IsAttributesNameChecked { get; set; }
        string AttributesNameText { get; set; }
        bool IsAttributesProfileChecked { get; set; }
        string AttributesProfileText { get; set; }
        bool IsAttributesMaterialChecked { get; set; }
        string AttributesMaterialText { get; set; }
        bool IsAttributesFinishChecked { get; set; }
        string AttributesFinishText { get; set; }
        bool IsAttributesClassChecked { get; set; }
        string AttributesClassText { get; set; }

        //Position Tab Data
        bool IsPositionVerticalChecked { get; set; }
        List<string> PositionVerticalComboBox { get; set; }
        string SelectedDataInPositionVerticalComboBox { get; set; }
        double PositionVerticalText { get; set; }

        bool IsPositionRotationChecked { get; set; }
        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        double PositionRotationText { get; set; }

        bool IsPositionHorizontalChecked { get; set; }
        List<string> PositionHorizontalComboBox { get; set; }
        string SelectedDataInPositionHorizontalComboBox { get; set; }
        double PositionHorizontalText { get; set; }

        bool IsPositionLevelsTopChecked { get; set; }
        double PositionLevelsTopText { get; set; }
        bool IsPositionLevelsBottomChecked { get; set; }
        double PositionLevelsBottomText { get; set; }
    }
}
