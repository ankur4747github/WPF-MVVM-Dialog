using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Helpers;
using DialogBeamProperties.Model;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel.AbstractViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Windows;

namespace DialogBeamProperties.ViewModel
{
    public class DialogBeamPropertiesViewModel : AbstractPropertyViewModel, IDisposable
    {
        #region Fields

        private readonly MemberModifierFactory modifierFactory;
        private BeamProperties globalBeamProperties;
        private readonly BeamValuesGetter beamValuesGetter;

        public List<string> PositionOnPlaneComboBox { get; set; }
        public List<string> PositionRotationComboBox { get; set; }
        public List<string> PositionAtDepthComboBox { get; set; }

        #endregion Fields

        #region INotifyPropertyChange Member

        #region IsPositionOnPlaneChecked

        public bool IsPositionOnPlaneChecked
        {
            get { return _isPositionOnPlaneChecked; }
            set
            {
                if (value == _isPositionOnPlaneChecked)
                    return;

                _isPositionOnPlaneChecked = value;

                OnPropertyChangedAsync(nameof(IsPositionOnPlaneChecked));
            }
        }

        private bool _isPositionOnPlaneChecked { get; set; }

        #endregion IsPositionOnPlaneChecked

        #region SelectedDataInPositionOnPlaneComboBox

        public string SelectedDataInPositionOnPlaneComboBox
        {
            get { return _selectedDataInPositionOnPlaneComboBox; }
            set
            {
                if (value == _selectedDataInPositionOnPlaneComboBox)
                    return;

                _selectedDataInPositionOnPlaneComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInPositionOnPlaneComboBox));
            }
        }

        private string _selectedDataInPositionOnPlaneComboBox { get; set; }

        #endregion SelectedDataInPositionOnPlaneComboBox

        #region PositionOnPlaneText

        public string PositionOnPlaneText
        {
            get { return _positionOnPlaneText; }
            set
            {
                if (value.ToString() == _positionOnPlaneText || !IsValidDecimal(value))
                    return;

                _positionOnPlaneText = value.ToString();
                if (!string.IsNullOrEmpty(PositionOnPlaneText))
                {
                    IsPositionOnPlaneChecked = Convert.ToDouble(PositionOnPlaneText) > 0;
                }
                OnPropertyChangedAsync(nameof(PositionOnPlaneText));
            }
        }

        private string _positionOnPlaneText { get; set; }

        #endregion PositionOnPlaneText

        #region IsPositionRotationChecked

        public bool IsPositionRotationChecked
        {
            get { return _isPositionRotationChecked; }
            set
            {
                if (value == _isPositionRotationChecked)
                    return;

                _isPositionRotationChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionRotationChecked));
            }
        }

        private bool _isPositionRotationChecked { get; set; }

        #endregion IsPositionRotationChecked

        #region SelectedDataInPositionRotationComboBox

        public string SelectedDataInPositionRotationComboBox
        {
            get { return _selectedDataInPositionRotationComboBox; }
            set
            {
                if (value == _selectedDataInPositionRotationComboBox)
                    return;

                _selectedDataInPositionRotationComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInPositionRotationComboBox));
            }
        }

        private string _selectedDataInPositionRotationComboBox { get; set; }

        #endregion SelectedDataInPositionRotationComboBox

        #region PositionRotationText

        public string PositionRotationText
        {
            get { return _positionRotationText; }
            set
            {
                if (value.ToString() == _positionRotationText || !IsValidDecimal(value))
                    return;

                _positionRotationText = value.ToString();
                if (!string.IsNullOrEmpty(PositionRotationText))
                {
                    IsPositionRotationChecked = Convert.ToDouble(PositionRotationText) > 0;
                }
                OnPropertyChangedAsync(nameof(PositionRotationText));
            }
        }

        private string _positionRotationText { get; set; }

        #endregion PositionRotationText

        #region IsPositionAtDepthChecked

        public bool IsPositionAtDepthChecked
        {
            get { return _isPositionAtDepthChecked; }
            set
            {
                if (value == _isPositionAtDepthChecked)
                    return;

                _isPositionAtDepthChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionAtDepthChecked));
            }
        }

        private bool _isPositionAtDepthChecked { get; set; }

        #endregion IsPositionAtDepthChecked

        #region SelectedDataInPositionAtDepthComboBox

        public string SelectedDataInPositionAtDepthComboBox
        {
            get { return _selectedDataInPositionAtDepthComboBox; }
            set
            {
                if (value == _selectedDataInPositionAtDepthComboBox)
                    return;

                _selectedDataInPositionAtDepthComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInPositionAtDepthComboBox));
            }
        }

        private string _selectedDataInPositionAtDepthComboBox { get; set; }

        #endregion SelectedDataInPositionAtDepthComboBox

        #region PositionAtDepthText

        public string PositionAtDepthText
        {
            get { return _positionAtDepthText; }
            set
            {
                if (value.ToString() == _positionAtDepthText || !IsValidDecimal(value))
                    return;

                _positionAtDepthText = value.ToString();
                if (!string.IsNullOrEmpty(PositionAtDepthText))
                {
                    IsPositionAtDepthChecked = Convert.ToDouble(PositionAtDepthText) > 0;
                }
                OnPropertyChangedAsync(nameof(PositionAtDepthText));
            }
        }

        private string _positionAtDepthText { get; set; }

        #endregion PositionAtDepthText

        #endregion INotifyPropertyChange Member

        #region Constructor

        public DialogBeamPropertiesViewModel(MemberModifierFactory modifierFactory,
            BeamProperties localBeamProperties,
            BeamProperties globalBeamPropertiesInput,
            BeamValuesGetter beamValuesGetter
            )
        {
            InitCommand();
            this.modifierFactory = modifierFactory;
            globalBeamProperties = globalBeamPropertiesInput;
            this.beamValuesGetter = beamValuesGetter;
            UpdateViewModel(localBeamProperties);

            PositionOnPlaneComboBox = new List<string>() { "MIDDLE", "RIGHT", "LEFT" };
            PositionRotationComboBox = new List<string>() { "FRONT", "TOP", "BACK", "BELOW" };
            PositionAtDepthComboBox = new List<string>() { "MIDDLE", "FRONT", "BEHIND" };

            SelectedDataInPositionOnPlaneComboBox = PositionOnPlaneComboBox[0];
            SelectedDataInPositionRotationComboBox = PositionRotationComboBox[0];
            SelectedDataInPositionAtDepthComboBox = PositionAtDepthComboBox[0];
        }

        private void InitCommand()
        {
            ButtonCommand = new RelayCommand(new Action<object>(CloseWindow));
            OkButtonCommand = new RelayCommand(new Action<object>(OkButtonClick));
            ApplyButtonCommand = new RelayCommand(new Action<object>(ApplyButtonClick));
            ModifyButtonCommand = new RelayCommand(new Action<object>(ModifyButtonClick));
            GetButtonCommand = new RelayCommand(new Action<object>(GetButtonClick));
            SelectAllCheckBoxButtonCommand = new RelayCommand(new Action<object>(SelectAllCheckBoxButtonClick));
            SaveButtonCommand = new RelayCommand(new Action<object>(SaveButtonClick));
            LoadButtonCommand = new RelayCommand(new Action<object>(LoadButtonClick));
            SelectProfileButtonCommand = new RelayCommand(new Action<object>(SelectProfileButtonClick));
            EnterKeyCommand = new RelayCommand(new Action<object>(ProfileEnterClick));
        }

        #endregion Constructor

        #region Private Methods

        #region Command Handlers

        private void CloseWindow(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSEBEAMPROPERTYWINDOW);
        }

        private void OkButtonClick(object obj)
        {
            if (IsAllDataValid())
            {
                saveCheckedPropertiesToGlobalVariable();
                Messenger.Default.Send(true, MessengerToken.CLOSEBEAMPROPERTYWINDOW);
            }
        }

        private void ApplyButtonClick(object obj)
        {
            if (IsAllDataValid())
            {
                saveCheckedPropertiesToGlobalVariable();
            }
        }

        private void ModifyButtonClick(object obj)
        {
            if (IsAllDataValid())
            {
                using (MemberModifier memberModifier = modifierFactory.CreateMemberModifier())
                {
                    if (IsAttributesProfileChecked)
                    {
                        memberModifier.ModifyProfile(AttributesProfileText);
                    }

                    if (IsPositionRotationChecked)
                    {
                        memberModifier.ModifyRotation(Convert.ToDouble(PositionRotationText));
                    }

                    if (IsPositionRotationChecked)
                    {
                        memberModifier.ModifyPositionRotationEnum(SelectedDataInPositionRotationComboBox);
                    }

                    if (IsAttributesClassChecked)
                    {
                        memberModifier.ModifyClass((AttributesClassText));
                    }
                }
            }
        }

        private void GetButtonClick(object obj)
        {
            BeamProperties beamProperties = beamValuesGetter.GetBeamProperties();
            UpdateViewModel(beamProperties);
        }

        private void SelectAllCheckBoxButtonClick(object obj)
        {
            IsNumberingSeriesPartPrefixChecked = !_selectAll;
            IsNumberingSeriesPartStartumberChecked = !_selectAll;
            IsNumberingSeriesAssemblyPrefixChecked = !_selectAll;
            IsNumberingSeriesAssemblyStartumberChecked = !_selectAll;
            IsAttributesNameChecked = !_selectAll;
            IsAttributesProfileChecked = !_selectAll;
            IsAttributesMaterialChecked = !_selectAll;
            IsAttributesFinishChecked = !_selectAll;
            IsAttributesClassChecked = !_selectAll;
            IsPositionOnPlaneChecked = !_selectAll;
            IsPositionRotationChecked = !_selectAll;
            IsPositionAtDepthChecked = !_selectAll;
            _selectAll = !_selectAll;
        }

        private void SaveButtonClick(object obj)
        {
        }

        private void LoadButtonClick(object obj)
        {
        }

        private void SelectProfileButtonClick(object obj)
        {
            Messenger.Default.Unregister<string>(this,
                   MessengerToken.SELECTEDPROFILE, SelectedProfile);
            Messenger.Default.Register<string>(this,
                MessengerToken.SELECTEDPROFILE, SelectedProfile);

            SelectProfile selectProfile = new SelectProfile();
            selectProfile.SetData(AttributesProfileText);
            selectProfile.ShowDialog();

            Messenger.Default.Unregister<string>(this,
                  MessengerToken.SELECTEDPROFILE, SelectedProfile);
        }

        private void ProfileEnterClick(object obj)
        {
            if (AttributesProfileText.Trim().Length > 1)
            {
                SelectProfileButtonClick(obj);
            }
        }

        #endregion Command Handlers

        #region Update Data

        private void UpdateViewModel(BeamProperties beamProperties)
        {
            LoadData(beamProperties);
            UpdatePositionData(beamProperties);
            UpdateAttributesData(beamProperties);
            UpdateNumberingData(beamProperties);
        }

        private void LoadData(BeamProperties beamProperties)
        {
            SelectedDataInLoadDataComboBox = beamProperties.SelectedDataInLoadDataComboBox;
        }

        private void UpdatePositionData(BeamProperties beamProperties)
        {
            SelectedDataInPositionOnPlaneComboBox = beamProperties.SelectedDataInPositionOnPlaneComboBox;
            PositionOnPlaneText = beamProperties.PositionOnPlaneText.ToString();

            SelectedDataInPositionRotationComboBox = beamProperties.SelectedDataInPositionRotationComboBox;
            PositionRotationText = beamProperties.PositionRotationText.ToString();

            SelectedDataInPositionAtDepthComboBox = beamProperties.SelectedDataInPositionAtDepthComboBox;
            PositionAtDepthText = beamProperties.PositionAtDepthText.ToString();
        }

        private void SelectedProfile(string obj)
        {
            AttributesProfileText = obj;
        }

        private void UpdateAttributesData(BeamProperties beamProperties)
        {
            AttributesNameText = beamProperties.AttributesNameText;
            AttributesProfileText = beamProperties.AttributesProfileText;
            AttributesMaterialText = beamProperties.AttributesMaterialText;
            AttributesFinishText = beamProperties.AttributesFinishText;
            AttributesClassText = beamProperties.AttributesClassText;
        }

        private void UpdateNumberingData(BeamProperties beamProperties)
        {
            NumberingSeriesPartPrefixText = beamProperties.NumberingSeriesPartPrefixText;
            NumberingSeriesPartStartNumberText = beamProperties.NumberingSeriesPartStartNumberText;
            NumberingSeriesAssemblyPrefixText = beamProperties.NumberingSeriesAssemblyPrefixText;
            NumberingSeriesAssemblyStartNumberText = beamProperties.NumberingSeriesAssemblyStartNumberText;
        }

        #endregion Update Data

        #region Save Data

        private void saveCheckedPropertiesToGlobalVariable()
        {
            SelectedDataInLoadDataComboBox = globalBeamProperties.SelectedDataInLoadDataComboBox;
            SaveAttributesData();
            SaveNumberingData();
            SavePositionData();
        }

        private void SaveAttributesData()
        {
            if (IsAttributesNameChecked)
            {
                globalBeamProperties.AttributesNameText = AttributesNameText;
            }

            if (IsAttributesProfileChecked)
            {
                globalBeamProperties.AttributesProfileText = AttributesProfileText;
            }

            if (IsAttributesMaterialChecked)
            {
                globalBeamProperties.AttributesMaterialText = AttributesMaterialText;
            }

            if (IsAttributesFinishChecked)
            {
                globalBeamProperties.AttributesFinishText = AttributesFinishText;
            }

            if (IsAttributesClassChecked)
            {
                globalBeamProperties.AttributesClassText = AttributesClassText;
            }
        }

        private void SaveNumberingData()
        {
            if (IsNumberingSeriesPartPrefixChecked)
            {
                globalBeamProperties.NumberingSeriesPartPrefixText = NumberingSeriesPartPrefixText;
            }

            if (IsNumberingSeriesPartStartumberChecked)
            {
                globalBeamProperties.NumberingSeriesPartStartNumberText = NumberingSeriesPartStartNumberText;
            }

            if (IsNumberingSeriesAssemblyPrefixChecked)
            {
                globalBeamProperties.NumberingSeriesAssemblyPrefixText = NumberingSeriesAssemblyPrefixText;
            }

            if (IsNumberingSeriesAssemblyStartumberChecked)
            {
                globalBeamProperties.NumberingSeriesAssemblyStartNumberText = NumberingSeriesAssemblyStartNumberText;
            }
        }

        private void SavePositionData()
        {
            if (IsPositionOnPlaneChecked)
            {
                globalBeamProperties.SelectedDataInPositionOnPlaneComboBox = SelectedDataInPositionOnPlaneComboBox;
                globalBeamProperties.PositionOnPlaneText = Convert.ToDouble(PositionOnPlaneText);
            }

            if (IsPositionRotationChecked)
            {
                globalBeamProperties.SelectedDataInPositionRotationComboBox = SelectedDataInPositionRotationComboBox;
                globalBeamProperties.PositionRotationText = Convert.ToDouble(PositionRotationText);
            }

            if (IsPositionAtDepthChecked)
            {
                globalBeamProperties.SelectedDataInPositionAtDepthComboBox = SelectedDataInPositionAtDepthComboBox;
                globalBeamProperties.PositionAtDepthText = Convert.ToDouble(PositionAtDepthText);
            }
        }

        #endregion Save Data

        #region Validation

        private bool IsAllDataValid()
        {
            ErrorText = string.Empty;
            return IsProfileValid() && IsAttributesClassValid();
        }

        private bool IsAttributesClassValid()
        {
            bool valid = true;
            if (IsAttributesClassChecked)
            {
                valid = new Validator().IsValidAttributesClass(AttributesClassText);
            }
            SetErrorOnScreenIsAttributesClassError(valid);
            return valid;
        }

        private bool IsProfileValid()
        {
            bool validProfile = false;
            try
            {
                if (IsAttributesProfileChecked)
                {
                    validProfile = new Validator().IsValidProfile(AttributesProfileText);
                }
                else
                {
                    validProfile = true;
                }
                SetErrorOnScreenIfProfileError(validProfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return validProfile;
        }

        #endregion Validation

        #endregion Private Methods

        public void Dispose()
        {
            base.Cleanup();
        }
    }
}