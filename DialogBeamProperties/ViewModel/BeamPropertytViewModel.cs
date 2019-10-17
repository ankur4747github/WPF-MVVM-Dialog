using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DialogBeamProperties.ViewModel
{
    public class DialogBeamPropertiesViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region Fields
        private IProperties iproperties { get; set; }
        #endregion

        #region Button Command

        private ICommand m_ButtonCommand;

        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }

        private ICommand _applyButtonCommand;

        public ICommand ApplyButtonCommand
        {
            get
            {
                return _applyButtonCommand;
            }
            set
            {
                _applyButtonCommand = value;
            }
        }

        #endregion Button Command

        #region INotifyPropertyChange Member

        #region IsEnableName

        public bool IsEnableName
        {
            get { return _isEnableName; }
            set
            {
                if (value == _isEnableName)
                    return;

                _isEnableName = value;
                OnPropertyChangedAsync(nameof(IsEnableName));
            }
        }

        private bool _isEnableName;

        #endregion IsEnableName

        #region IsEnableProfile

        public bool IsEnableProfile
        {
            get { return _isEnableProfile; }
            set
            {
                if (value == _isEnableProfile)
                    return;

                _isEnableProfile = value;
                OnPropertyChangedAsync(nameof(IsEnableProfile));
            }
        }

        private bool _isEnableProfile;

        #endregion IsEnableProfile

        #region IsPartPrefixEnable

        public bool IsPartPrefixEnable
        {
            get { return _isPartPrefixEnable; }
            set
            {
                if (value == _isPartPrefixEnable)
                    return;

                _isPartPrefixEnable = value;
                OnPropertyChangedAsync(nameof(IsPartPrefixEnable));
            }
        }

        private bool _isPartPrefixEnable;

        #endregion IsPartPrefixEnable

        #region IsPartStartNumberEnable

        public bool IsPartStartNumberEnable
        {
            get { return _isPartStartNumberEnable; }
            set
            {
                if (value == _isPartStartNumberEnable)
                    return;

                _isPartStartNumberEnable = value;
                OnPropertyChangedAsync(nameof(IsPartStartNumberEnable));
            }
        }

        private bool _isPartStartNumberEnable;

        #endregion IsPartStartNumberEnable

        #region IsAssemblyPrefixNumberEnable

        public bool IsAssemblyPrefixNumberEnable
        {
            get { return _isAssemblyPrefixNumberEnable; }
            set
            {
                if (value == _isAssemblyPrefixNumberEnable)
                    return;

                _isAssemblyPrefixNumberEnable = value;
                OnPropertyChangedAsync(nameof(IsAssemblyPrefixNumberEnable));
            }
        }

        private bool _isAssemblyPrefixNumberEnable;

        #endregion IsAssemblyPrefixNumberEnable

        #region IsAssemblyStartNumberEnable

        public bool IsAssemblyStartNumberEnable
        {
            get { return _isAssemblyStartNumberEnable; }
            set
            {
                if (value == _isAssemblyStartNumberEnable)
                    return;

                _isAssemblyStartNumberEnable = value;
                OnPropertyChangedAsync(nameof(IsAssemblyStartNumberEnable));
            }
        }

        private bool _isAssemblyStartNumberEnable;

        #endregion IsAssemblyStartNumberEnable

        #region IsToggelCheckBoxFirst

        public bool IsToggelCheckBoxFirst
        {
            get { return _isToggelCheckBoxFirst; }
            set
            {
                if (value == _isToggelCheckBoxFirst)
                    return;

                _isToggelCheckBoxFirst = value;
                if (IsToggelCheckBoxFirst)
                {
                    IsToggelCheckBoxSecond = false;
                }
                OnPropertyChangedAsync(nameof(IsToggelCheckBoxFirst));
            }
        }

        private bool _isToggelCheckBoxFirst = true;

        #endregion IsToggelCheckBoxFirst

        #region IsToggelCheckBoxSecond

        public bool IsToggelCheckBoxSecond
        {
            get { return _isToggelCheckBoxSecond; }
            set
            {
                if (value == _isToggelCheckBoxSecond)
                    return;

                _isToggelCheckBoxSecond = value;
                if (IsToggelCheckBoxSecond)
                {
                    IsToggelCheckBoxFirst = false;
                }
                OnPropertyChangedAsync(nameof(IsToggelCheckBoxSecond));
            }
        }

        private bool _isToggelCheckBoxSecond;

        #endregion IsToggelCheckBoxSecond

        #region AttributesNameText

        public string AttributesNameText
        {
            get { return _attributesNameText; }
            set
            {
                if (value == _attributesNameText)
                    return;

                _attributesNameText = value;
                OnPropertyChangedAsync(nameof(AttributesNameText));
            }
        }

        private string _attributesNameText;

        #endregion AttributesNameText

        #region AttributesProfileText

        public string AttributesProfileText
        {
            get { return _attributesProfileText; }
            set
            {
                if (value == _attributesProfileText)
                    return;

                _attributesProfileText = value;
                OnPropertyChangedAsync(nameof(AttributesProfileText));
            }
        }

        private string _attributesProfileText;

        #endregion AttributesProfileText

        #region NumberingPartPrefixText

        public string NumberingPartPrefixText
        {
            get { return _numberingPartPrefixText; }
            set
            {
                if (value == _numberingPartPrefixText)
                    return;

                _numberingPartPrefixText = value;
                OnPropertyChangedAsync(nameof(NumberingPartPrefixText));
            }
        }

        private string _numberingPartPrefixText;

        #endregion NumberingPartPrefixText

        #region NumberingPartStartNumberText

        public string NumberingPartStartNumberText
        {
            get { return _numberingPartStartNumberText; }
            set
            {
                if (value == _numberingPartStartNumberText)
                    return;

                _numberingPartStartNumberText = value;
                OnPropertyChangedAsync(nameof(NumberingPartStartNumberText));
            }
        }

        private string _numberingPartStartNumberText;

        #endregion NumberingPartStartNumberText

        #region NumberingAssemblyPrefixText

        public string NumberingAssemblyPrefixText
        {
            get { return _numberingAssemblyPrefixText; }
            set
            {
                if (value == _numberingAssemblyPrefixText)
                    return;

                _numberingAssemblyPrefixText = value;
                OnPropertyChangedAsync(nameof(NumberingAssemblyPrefixText));
            }
        }

        private string _numberingAssemblyPrefixText;

        #endregion NumberingAssemblyPrefixText

        #region NumberingAssemblyStartNumberText

        public string NumberingAssemblyStartNumberText
        {
            get { return _numberingAssemblyStartNumberText; }
            set
            {
                if (value == _numberingAssemblyStartNumberText)
                    return;

                _numberingAssemblyStartNumberText = value;
                OnPropertyChangedAsync(nameof(NumberingAssemblyStartNumberText));
            }
        }

        private string _numberingAssemblyStartNumberText;

        #endregion NumberingAssemblyStartNumberText

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

        public DialogBeamPropertiesViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(CloseWindow));
            ApplyButtonCommand = new RelayCommand(new Action<object>(ApplyButtonClick));
        }

        #endregion Constructor

        #region Public Methods
        public void SetProtertiesData(IProperties iproperties)
        {
            this.iproperties = iproperties;
            UpdateData(iproperties);
        }

       
        public IProperties GetPropertiesData()
        {
            return iproperties;
        }
        #endregion

        #region Private Methods
        private void ApplyButtonClick(object obj)
        {
            iproperties.AttributesName = AttributesNameText;
            iproperties.AttributesProfile = AttributesProfileText;
            iproperties.NumberingPartPrefix = NumberingPartPrefixText;
            iproperties.NumberingPartStartNumber = NumberingPartStartNumberText;
            iproperties.NumberingAssemblyPrefix = NumberingAssemblyPrefixText;
            iproperties.NumberingAssemblyStartNumber = NumberingAssemblyStartNumberText;
        }

        private void CloseWindow(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSEWINDOW);
        }

        private void UpdateData(IProperties iproperties)
        {
            AttributesNameText = iproperties.AttributesName;
            AttributesProfileText = iproperties.AttributesProfile;
            NumberingPartPrefixText = iproperties.NumberingPartPrefix;
            NumberingPartStartNumberText = iproperties.NumberingPartStartNumber;
            NumberingAssemblyPrefixText = iproperties.NumberingAssemblyPrefix;
            NumberingAssemblyStartNumberText = iproperties.NumberingAssemblyStartNumber;
        }

        #endregion
    }
}