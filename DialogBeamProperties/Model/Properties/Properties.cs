using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model
{
    public class Properties : IProperties
    {
        public List<string> LoadDataComboBox { get; set; }
        public string SelectedDataInLoadDataComboBox {get;set;}
        public bool IsNumberingSeriesPartPrefixChecked {get;set;}
        public string NumberingSeriesPartPrefixText {get;set;}
        public bool IsNumberingSeriesPartStartumberChecked {get;set;}
        public string NumberingSeriesPartStartNumberText {get;set;}
        public bool IsNumberingSeriesAssemblyPrefixChecked {get;set;}
        public string NumberingSeriesAssemblyPrefixText {get;set;}
        public bool IsNumberingSeriesAssemblyStartumberChecked {get;set;}
        public string NumberingSeriesAssemblyStartNumberText {get;set;}
        public bool IsAttributesNameChecked {get;set;}
        public string AttributesNameText {get;set;}
        public bool IsAttributesProfileChecked {get;set;}
        public string AttributesProfileText { get; set; }
        public bool IsAttributesMaterialChecked { get; set; }
        public string AttributesMaterialText { get; set; }
        public bool IsAttributesFinishChecked { get; set; }
        public string AttributesFinishText { get; set; }
        public bool IsAttributesClassChecked { get; set; }
        public string AttributesClassText { get; set; }
        public bool IsPositionOnPlaneChecked { get; set; }
        public List<string> PositionOnPlaneComboBox { get; set; }
        public string SelectedDataInPositionOnPlaneComboBox { get; set; }
        public string PositionOnPlaneText { get; set; }
        public bool IsPositionRotationChecked { get; set; }
        public List<string> PositionRotationComboBox { get; set; }
        public string SelectedDataInPositionRotationComboBox { get; set; }
        public string PositionRotationText { get; set; }
        public bool IsPositionAtDepthChecked { get; set; }
        public List<string> PositionAtDepthComboBox { get; set; }
        public string SelectedDataInPositionAtDepthComboBox { get; set; }
        public string PositionAtDepthText { get; set; }
    }
}
