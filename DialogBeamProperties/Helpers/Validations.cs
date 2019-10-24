using DialogBeamProperties.Model;
using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.Model.Properties;
using System;
using System.Linq;
using System.Windows;

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
        public bool IsValidProfile(IBeamProperties iproperties)
        {
            return IsValidProfile(iproperties.AttributesProfileText);
        }

        public bool IsValidProfile(IColumnProperties iproperties)
        {
            return IsValidProfile(iproperties.AttributesProfileText);
        }

        public bool IsValidProfileAndTopAndBottomPositions(IColumnProperties iproperties)
        {
            return IsValidProfile(iproperties.AttributesProfileText) &&
                   AreTopAndBottomPositionsValid(iproperties.PositionLevelsTopText, iproperties.PositionLevelsBottomText);
        }

        public bool IsValidProfile(string attributesProfileText)
        {
            try
            {
                var profiles = ProfileFileData.Instance;
                if (!string.IsNullOrEmpty(attributesProfileText))
                {
                    var beams = profiles.Beams.Where(i => i.Profile.ToUpper().Equals(attributesProfileText.ToUpper()));
                    var chinaProfiles = profiles.ChinaProfiles.Where(i => i.Profile.ToUpper().Equals(attributesProfileText.ToUpper()));
                    var usimperialProfiles = profiles.UsimperialProfiles.Where(i => i.Profile.ToUpper().Equals(attributesProfileText.ToUpper()));
                    var usmetricProfiles = profiles.UsmetricProfiles.Where(i => i.Profile.ToUpper().Equals(attributesProfileText.ToUpper()));
                    if (beams.Count() > 0 || chinaProfiles.Count() > 0 ||
                        usimperialProfiles.Count() > 0 || usmetricProfiles.Count() > 0)
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

        public bool AreTopAndBottomPositionsValid(double positionLevelsTop, double positionLevelsBottom)
        {
            return positionLevelsBottom != positionLevelsTop;
        }
    }
}