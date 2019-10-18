using DialogBeamProperties.Model.ProfileFileData;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DialogBeamProperties.ViewModel
{
    public class SelectProfileViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region INotifyPropertyChange Member

        #region ProfileList

        public ObservableCollection<string> ProfileList
        {
            get { return _profileList; }
            set
            {
                if (value == _profileList)
                    return;

                _profileList = value;
                OnPropertyChangedAsync(nameof(ProfileList));
            }
        }

        private ObservableCollection<string> _profileList { get; set; }

        #endregion ProfileList

        #endregion INotifyPropertyChange Member

        #region PropertyChanged

        public new event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChangedAsync([CallerMemberName]string propertyName = null)
        {
            try
            {
                try
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }
                catch { }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion PropertyChanged

        #region Constructor

        public SelectProfileViewModel()
        {
            ProfileList = new ObservableCollection<string>();
        }

        #endregion Constructor

        #region Public Methods

        public void SetData(ProfileFileData allProfileFileData, string attributesProfileText)
        {
            var beamdata = allProfileFileData.Beams.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var chinadata = allProfileFileData.ChinaProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var usimperialdata = allProfileFileData.UsimperialProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var usmetricdata = allProfileFileData.UsmetricProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));

            AddItemToLIst(beamdata);
            AddItemToLIst(chinadata);
            AddItemToLIst(usimperialdata);
            AddItemToLIst(usmetricdata);
        }

        private void AddItemToLIst(IEnumerable<ProfileData> data)
        {
            foreach (var item in data)
            {
                ProfileList.Add(item.Profile);
            }
        }

        #endregion Public Methods
    }
}