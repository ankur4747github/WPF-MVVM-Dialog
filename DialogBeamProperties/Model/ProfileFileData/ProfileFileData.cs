using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace DialogBeamProperties.Model.ProfileFileData
{
    public class ProfileFileData
    {
        public List<ProfileData> Beams = new List<ProfileData>();
        public List<ProfileData> ChinaProfiles = new List<ProfileData>();
        public List<ProfileData> UsimperialProfiles = new List<ProfileData>();
        public List<ProfileData> UsmetricProfiles = new List<ProfileData>();

        private ProfileFileData()
        {
            Task.Factory.StartNew(() => LoadProfileFiles());
        }

        private static ProfileFileData instance = null;

        public static ProfileFileData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProfileFileData();
                }
                return instance;
            }
        }

        #region Load Profile Files Into List

        protected void LoadProfileFiles()
        {
            string temp = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (File.Exists(Path.Combine(temp, "Files", "Profile", "beams.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "beams.json"), ref Beams);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "china-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "china-profiles.json"), ref ChinaProfiles);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "usimperial-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "usimperial-profiles.json"), ref UsimperialProfiles);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "usmetric-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "usmetric-profiles.json"), ref UsmetricProfiles);
            }
        }

        protected void LoadFiles(string filePath, ref List<ProfileData> list)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                JArray jsonArray = JArray.Parse(json);
                list = jsonArray.ToObject<List<ProfileData>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Load Profile Files Into List
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