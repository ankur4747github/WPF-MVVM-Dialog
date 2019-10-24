using System.Collections.Generic;

namespace DialogBeamProperties.Model
{
    public interface IBeamProperties
    {
        // The boolean values not important in the CAD file. i.e. whether a check box is checked does not worry
        // me from a model point of view. That is important from a view and view model point of view.
        // The only thing we are concerned with saving are the numbers and text fields.
        // Everything else can be savely removed. i.e. please remove all bools

        List<string> LoadDataComboBox { get; set; }                 // This can be set direclty in the view / view model

        string SelectedDataInLoadDataComboBox { get; set; }
        string NumberingSeriesPartPrefixText { get; set; }
        string NumberingSeriesPartStartNumberText { get; set; }
        string NumberingSeriesAssemblyPrefixText { get; set; }
        string NumberingSeriesAssemblyStartNumberText { get; set; }

        string AttributesNameText { get; set; }
        string AttributesProfileText { get; set; }
        string AttributesMaterialText { get; set; }
        string AttributesFinishText { get; set; }
        string AttributesClassText { get; set; }

        //Position Tab Data

        List<string> PositionOnPlaneComboBox { get; set; }
        string SelectedDataInPositionOnPlaneComboBox { get; set; }
        double PositionOnPlaneText { get; set; }

        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        double PositionRotationText { get; set; }

        List<string> PositionAtDepthComboBox { get; set; }
        string SelectedDataInPositionAtDepthComboBox { get; set; }
        double PositionAtDepthText { get; set; }
    }
}