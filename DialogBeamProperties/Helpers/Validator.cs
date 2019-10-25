using DialogBeamProperties.Model;
using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.Model.Properties;
using System;
using System.Linq;
using System.Windows;

namespace DialogBeamProperties.Helpers
{
    
    public class Validator
    {
        public bool IsValidProfile(BeamProperties iproperties)
        {
            return IsValidProfile(iproperties.AttributesProfileText);
        }

        public bool IsValidProfile(ColumnProperties iproperties)
        {
            return IsValidProfile(iproperties.AttributesProfileText);
        }

        public bool IsValidProfileAndTopAndBottomPositions(ColumnProperties iproperties)
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