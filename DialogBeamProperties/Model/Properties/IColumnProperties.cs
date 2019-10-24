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

        List<string> PositionVerticalComboBox { get; set; }
        string SelectedDataInPositionVerticalComboBox { get; set; }
        double PositionVerticalText { get; set; }

        List<string> PositionRotationComboBox { get; set; }
        string SelectedDataInPositionRotationComboBox { get; set; }
        double PositionRotationText { get; set; }

        List<string> PositionHorizontalComboBox { get; set; }
        string SelectedDataInPositionHorizontalComboBox { get; set; }
        double PositionHorizontalText { get; set; }

        double PositionLevelsTopText { get; set; }
        double PositionLevelsBottomText { get; set; }
    }
}