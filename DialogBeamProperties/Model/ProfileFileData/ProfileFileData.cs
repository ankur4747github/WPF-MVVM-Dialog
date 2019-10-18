using System.Collections.Generic;

namespace DialogBeamProperties.Model.ProfileFileData
{
    public class ProfileFileData
    {
        public List<ProfileData> Beams = new List<ProfileData>();
        public List<ProfileData> ChinaProfiles = new List<ProfileData>();
        public List<ProfileData> UsimperialProfiles = new List<ProfileData>();
        public List<ProfileData> UsmetricProfiles = new List<ProfileData>();
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