using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model.Properties
{
    public interface IColumnProperties
    {
        // The boolean values not important in the CAD file. i.e. whether a check box is checked does not worry
        // me from a model point of view. That is important from a view and view model point of view.
        // The only thing we are concerned with saving are the numbers and text fields.
        // Everything else can be savely removed. i.e. please remove all bools

        List<string> LoadDataComboBox { get; set; }                   // This can be set direclty in the view / view model
        string SelectedDataInLoadDataComboBox { get; set; }
        bool IsNumberingSeriesPartPrefixChecked { get; set; }         // bool can be removed.
        string NumberingSeriesPartPrefixText { get; set; }
        bool IsNumberingSeriesPartStartumberChecked { get; set; }     // bool can be removed.
        string NumberingSeriesPartStartNumberText { get; set; }
        bool IsNumberingSeriesAssemblyPrefixChecked { get; set; }     // bool can be removed.
        string NumberingSeriesAssemblyPrefixText { get; set; }
        bool IsNumberingSeriesAssemblyStartumberChecked { get; set; } // bool can be removed.
        string NumberingSeriesAssemblyStartNumberText { get; set; }

        bool IsAttributesNameChecked { get; set; }                    // bool can be removed.
        string AttributesNameText { get; set; }
        bool IsAttributesProfileChecked { get; set; }                 // bool can be removed.
        string AttributesProfileText { get; set; }
        bool IsAttributesMaterialChecked { get; set; }                // bool can be removed
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