using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DialogBeamProperties.Model.ProfileFileData
{
    public class ProfileFileData
    {
        public List<ProfileData> Beams = new List<ProfileData>();
        public List<ProfileData> ChinaProfiles = new List<ProfileData>();
        public List<ProfileData> UsimperialProfiles = new List<ProfileData>();
        public List<ProfileData> UsmetricProfiles = new List<ProfileData>();

        public bool IsValidProfile(string attributesProfileText)
        {
            try
            {
                var beamdata = Beams.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
                var chinadata = ChinaProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
                var usimperialdata = UsimperialProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
                var usmetricdata = UsmetricProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));

                if (beamdata.Count() > 0 ||
                    chinadata.Count() > 0 ||
                    usimperialdata.Count() > 0 ||
                    usmetricdata.Count() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }

    public class ProfileData
    {
        public string Profile = string.Empty;
        public double Height;
        public double Width;
        public double FlangeThickness;
        public double WeightPerUnitLength;
        public string ProfileType = string.Empty;
    }
}