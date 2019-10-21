using System.Collections.Generic;

namespace DialogBeamProperties.Model.Properties
{
    public class ColumnProperties : IColumnProperties
    {
        public List<string> LoadDataComboBox { get; set; }
        public string SelectedDataInLoadDataComboBox { get; set; }
        public bool IsNumberingSeriesPartPrefixChecked { get; set; }
        public string NumberingSeriesPartPrefixText { get; set; }
        public bool IsNumberingSeriesPartStartumberChecked { get; set; }
        public string NumberingSeriesPartStartNumberText { get; set; }
        public bool IsNumberingSeriesAssemblyPrefixChecked { get; set; }
        public string NumberingSeriesAssemblyPrefixText { get; set; }
        public bool IsNumberingSeriesAssemblyStartumberChecked { get; set; }
        public string NumberingSeriesAssemblyStartNumberText { get; set; }
        public bool IsAttributesNameChecked { get; set; }
        public string AttributesNameText { get; set; }
        public bool IsAttributesProfileChecked { get; set; }
        public string AttributesProfileText { get; set; }
        public bool IsAttributesMaterialChecked { get; set; }
        public string AttributesMaterialText { get; set; }
        public bool IsAttributesFinishChecked { get; set; }
        public string AttributesFinishText { get; set; }
        public bool IsAttributesClassChecked { get; set; }
        public string AttributesClassText { get; set; }
        public bool IsPositionVerticalChecked { get; set; }
        public List<string> PositionVerticalComboBox { get; set; }
        public string SelectedDataInPositionVerticalComboBox { get; set; }
        public double PositionVerticalText { get; set; }
        public bool IsPositionRotationChecked { get; set; }
        public List<string> PositionRotationComboBox { get; set; }
        public string SelectedDataInPositionRotationComboBox { get; set; }
        public double PositionRotationText { get; set; }
        public bool IsPositionHorizontalChecked { get; set; }
        public List<string> PositionHorizontalComboBox { get; set; }
        public string SelectedDataInPositionHorizontalComboBox { get; set; }
        public double PositionHorizontalText { get; set; }
        public bool IsPositionLevelsTopChecked { get; set; }
        public double PositionLevelsTopText { get; set; }
        public bool IsPositionLevelsBottomChecked { get; set; }
        public double PositionLevelsBottomText { get; set; }
    }
}