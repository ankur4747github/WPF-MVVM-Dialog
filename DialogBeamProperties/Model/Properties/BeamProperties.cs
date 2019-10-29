using System.Collections.Generic;

namespace DialogBeamProperties.Model
{
    public class BeamProperties
    {
        
        public string SelectedDataInLoadDataComboBox { get; set; }
        public string NumberingSeriesPartPrefixText { get; set; }
        public string NumberingSeriesPartStartNumberText { get; set; }
        public string NumberingSeriesAssemblyPrefixText { get; set; }
        public string NumberingSeriesAssemblyStartNumberText { get; set; }
        public string AttributesNameText { get; set; }
        public string AttributesProfileText { get; set; }
        public string AttributesMaterialText { get; set; }
        public string AttributesFinishText { get; set; }
        public int AttributesClassText { get; set; }
        public string SelectedDataInPositionOnPlaneComboBox { get; set; }
        public double PositionOnPlaneText { get; set; }
        public string SelectedDataInPositionRotationComboBox { get; set; }
        public double PositionRotationText { get; set; }
        public string SelectedDataInPositionAtDepthComboBox { get; set; }
        public double PositionAtDepthText { get; set; }
    }
}