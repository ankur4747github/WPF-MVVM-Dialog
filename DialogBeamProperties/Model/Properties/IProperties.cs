using System.Collections.Generic;

namespace DialogBeamProperties.Model
{
    public interface IProperties
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
        string AttributesName { get; set; }
        bool IsAttributesProfileChecked { get; set; }
        string AttributesProfile { get; set; }
        bool IsAttributesMaterialChecked { get; set; }
        string AttributesMaterial { get; set; }
        bool IsAttributesFinishChecked { get; set; }
        string AttributesFinish { get; set; }
        bool IsAttributesClassChecked { get; set; }
        string AttributesClass { get; set; }

        //Position Tab Data
        bool IsPositionOnPlaneChecked { get; set; }
        List<string> PositionOnPlaneComboBox { get; set; }
        string SelectedDataInPositionOnPlaneComboBox { get; set; }
        string PositionOnPlaneText { get; set; }

        bool IsPositionRotationChecked { get; set; }
        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        string PositionRotationText { get; set; }

        bool IsPositionAtDepthChecked { get; set; }
        List<string> PositionAtDepthComboBox { get; set; }
        string SelectedDataInPositionAtDepthComboBox { get; set; }
        string PositionAtDepthText { get; set; }



    }
}