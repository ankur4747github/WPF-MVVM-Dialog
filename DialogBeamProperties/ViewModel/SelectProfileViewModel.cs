using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Model.ProfileFileData;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

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

        #region SelectedProfile

        public string SelectedProfile
        {
            get { return _selectedProfile; }
            set
            {
                if (value == _selectedProfile)
                    return;

                _selectedProfile = value;
                OnPropertyChangedAsync(nameof(SelectedProfile));
            }
        }

        private string _selectedProfile { get; set; }

        #endregion SelectedProfile

        #endregion INotifyPropertyChange Member

        #region Button Command

        #region Close Button Command

        private ICommand okCommand;

        public ICommand OKCommand
        {
            get
            {
                return okCommand;
            }
            set
            {
                okCommand = value;
            }
        }

        #endregion Close Button Command

        #region Apply Buttom Command

        private ICommand _cancelButtonCommand;

        public ICommand CancelButtonCommand
        {
            get
            {
                return _cancelButtonCommand;
            }
            set
            {
                _cancelButtonCommand = value;
            }
        }

        #endregion Apply Buttom Command

       

        #endregion Button Command

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
            OKCommand = new RelayCommand(new Action<object>(OkButtonClick));
            CancelButtonCommand = new RelayCommand(new Action<object>(CancelButtonClick));
        }

      

        #endregion Constructor

        #region Public Methods

        public void SetData(string attributesProfileText)
        {
            ProfileFileData allProfileFileData = ProfileFileData.Instance;
            var beamdata = allProfileFileData.Beams.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var chinadata = allProfileFileData.ChinaProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var usimperialdata = allProfileFileData.UsimperialProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));
            var usmetricdata = allProfileFileData.UsmetricProfiles.Where(i => i.Profile.ToUpper().StartsWith(attributesProfileText.ToUpper()));

            AddItemToList(beamdata);
            AddItemToList(chinadata);
            AddItemToList(usimperialdata);
            AddItemToList(usmetricdata);
        }

        private void AddItemToList(IEnumerable<ProfileData> data)
        {
            foreach (var item in data)
            {
                ProfileList.Add(item.Profile);
            }
        }

        public void ListViewMouseDoubleClick()
        {
            OkButtonClick(true);
        }
        #endregion Public Methods

        #region Private Methods

        private void CancelButtonClick(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSESELECTPROFILEWINDOW);
        }

        private void OkButtonClick(object obj)
        {
            if (!string.IsNullOrEmpty(SelectedProfile))
            {
                Messenger.Default.Send(SelectedProfile, MessengerToken.SELECTEDPROFILE);
                Messenger.Default.Send(true, MessengerToken.CLOSESELECTPROFILEWINDOW);
            }
        }

     

        #endregion Private Methods
    }
}