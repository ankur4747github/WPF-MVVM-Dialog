using DialogBeamProperties.Model.ProfileFileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static DialogBeamProperties.Model.ProfileFileData.ProfileFileData;

namespace DialogBeamProperties.Helpers
{
    // Hi Ankur
    // Right now the validation logic is woven into the view model classes.
    // I cannot use your Validations class right now, without also
    // Loading all the profile strings by myself. The profile strings are loaded
    // from within the view models classes. I don't want to have to write
    // some code again to validate this.

    // What I want to be able to do in my code is something like this.

    // IColumnProperties columnproperties = ....
    // if (validator.IsValid(iColumnProperties))
    //{
    //     if it is valid then I continue as before.
    //}
    //else
    //{
    //     otherwise I take some corrective action
    //}

    // IBeamProperties beamProperties = ....
    // if (validator.IsValid(iColumnProperties))
    //{
    //     if it is valid then I continue as before.
    //}
    // I will otherwise have to load the profiles and instantiate them myself.
    // The profile data right now is loaded from within the view model.

    public class Validator
    {
        // Data must be preloaded for this to work.
        // You could possibly store this is a static variable, to
        // prevent the reloading of already existing data?

        //public bool IsValid(IColumnProperties columnProperties)
        //{
        //    return IsValidProfile(columnProperties.AttributesProfileText) && AreTopAndBottomPositionsValid(columnProperties.PositionLevelsTopText, columnProperties.PositionLevelsBottomText);
        //}

        //public bool IsValid(IBeamProperties beamProperties)
        //{
        //    return IsValidProfile(beamProperties.AttributesProfileText);
        //}

        public bool IsValidProfile(string attributesProfileText, List<ProfileData> profiles)
        {
            try
            {
                if (!string.IsNullOrEmpty(attributesProfileText))
                {
                    var beamdata = profiles.Where(i => i.Profile.ToUpper().Equals(attributesProfileText.ToUpper()));
                    if (beamdata.Count() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool IsPositionLevelsTopBottomValid(double positionLevelsTop, double positionLevelsBottom)
        {
            return positionLevelsBottom != positionLevelsTop;
        }
    }
}
