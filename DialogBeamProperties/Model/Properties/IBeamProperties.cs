using System.Collections.Generic;

namespace DialogBeamProperties.Model
{
    public interface IBeamProperties
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
        bool IsPositionOnPlaneChecked { get; set; }

        List<string> PositionOnPlaneComboBox { get; set; }
        string SelectedDataInPositionOnPlaneComboBox { get; set; }
        string PositionOnPlaneText { get; set; } // Hi ankur, this needs to be updated to a double.

        bool IsPositionRotationChecked { get; set; }
        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        string PositionRotationText { get; set; } // Hi ankur, this needs to be updated to a double.

        bool IsPositionAtDepthChecked { get; set; }
        List<string> PositionAtDepthComboBox { get; set; }
        string SelectedDataInPositionAtDepthComboBox { get; set; }
        string PositionAtDepthText { get; set; } // Hi ankur, this needs to be updated to a double.
    }
}