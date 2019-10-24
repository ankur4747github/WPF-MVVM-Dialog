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
        bool IsNumberingSeriesPartPrefixChecked { get; set; }        // bool can be removed.
        string NumberingSeriesPartPrefixText { get; set; }
        bool IsNumberingSeriesPartStartumberChecked { get; set; }     // bool can be removed.
        string NumberingSeriesPartStartNumberText { get; set; }
        bool IsNumberingSeriesAssemblyPrefixChecked { get; set; }      // bool can be removed.
        string NumberingSeriesAssemblyPrefixText { get; set; }
        bool IsNumberingSeriesAssemblyStartumberChecked { get; set; }    // etc etc.
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
        double PositionOnPlaneText { get; set; }

        bool IsPositionRotationChecked { get; set; }
        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        double PositionRotationText { get; set; }

        bool IsPositionAtDepthChecked { get; set; }
        List<string> PositionAtDepthComboBox { get; set; }
        string SelectedDataInPositionAtDepthComboBox { get; set; }
        double PositionAtDepthText { get; set; }
    }
}