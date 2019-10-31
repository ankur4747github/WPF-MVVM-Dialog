using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Helpers;
using DialogBeamProperties.Model.Properties;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel.AbstractViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Windows;

namespace DialogBeamProperties.ViewModel
{
    public class DialogColumnPropertiesViewModel : AbstractPropertyViewModel, IDisposable
    {
        private const string PositionLevelErrors = "Position Levels should not be equals and \r\nTop should be greater then Bottom.";

        #region Fields

        private readonly MemberModifierFactory modifierFactory;
        private ColumnProperties globaColumnProperties;
        private readonly ColumnValuesGetter columnValuesGetter;

        public List<string> PositionRotationComboBox { get; set; }
        public List<string> PositionVerticalComboBox { get; set; }
        public List<string> PositionHorizontalComboBox { get; set; }

        #endregion Fields

        #region INotifyPropertyChange Member

        #region IsPositionVerticalChecked

        public bool IsPositionVerticalChecked
        {
            get { return _isPositionVerticalChecked; }
            set
            {
                if (value == _isPositionVerticalChecked)
                    return;

                _isPositionVerticalChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionVerticalChecked));
            }
        }

        private bool _isPositionVerticalChecked { get; set; }

        #endregion IsPositionVerticalChecked

        #region SelectedDataInPositionVerticalComboBox

        public string SelectedDataInPositionVerticalComboBox
        {
            get { return _selectedDataInPositionVerticalComboBox; }
            set
            {
                if (value == _selectedDataInPositionVerticalComboBox)
                    return;

                _selectedDataInPositionVerticalComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInPositionVerticalComboBox));
            }
        }

        private string _selectedDataInPositionVerticalComboBox { get; set; }

        #endregion SelectedDataInPositionVerticalComboBox

        #region PositionVerticalText

        public string PositionVerticalText
        {
            get { return _positionVerticalText; }
            set
            {
                if (value.ToString() == _positionVerticalText || !IsValidDecimal(value))
                    return;

                _positionVerticalText = value.ToString();
                if (!string.IsNullOrEmpty(PositionVerticalText))
                {
                    IsPositionVerticalChecked = Convert.ToDouble(PositionVerticalText) > 0;
                }
                OnPropertyChangedAsync(nameof(PositionVerticalText));
            }
        }

        private string _positionVerticalText { get; set; }

        #endregion PositionVerticalText

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

        #region IsPositionHorizontalChecked

        public bool IsPositionHorizontalChecked
        {
            get { return _isPositionHorizontalChecked; }
            set
            {
                if (value == _isPositionHorizontalChecked)
                    return;

                _isPositionHorizontalChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionHorizontalChecked));
            }
        }

        private bool _isPositionHorizontalChecked { get; set; }

        #endregion IsPositionHorizontalChecked

        #region SelectedDataInPositionHorizontalComboBox

        public string SelectedDataInPositionHorizontalComboBox
        {
            get { return _selectedDataInPositionHorizontalComboBox; }
            set
            {
                if (value == _selectedDataInPositionHorizontalComboBox)
                    return;

                _selectedDataInPositionHorizontalComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInPositionHorizontalComboBox));
            }
        }

        private string _selectedDataInPositionHorizontalComboBox { get; set; }

        #endregion SelectedDataInPositionHorizontalComboBox

        #region PositionHorizontalText

        public string PositionHorizontalText
        {
            get { return _positionHorizontalText; }
            set
            {
                if (value.ToString() == _positionHorizontalText || !IsValidDecimal(value))
                    return;

                _positionHorizontalText = value.ToString();
                if (!string.IsNullOrEmpty(PositionHorizontalText))
                {
                    IsPositionHorizontalChecked = Convert.ToDouble(PositionHorizontalText) > 0;
                }
                OnPropertyChangedAsync(nameof(PositionHorizontalText));
            }
        }

        private string _positionHorizontalText { get; set; }

        #endregion PositionHorizontalText

        #region IsPositionLevelsTopChecked

        public bool IsPositionLevelsTopChecked
        {
            get { return _isPositionLevelsTopChecked; }
            set
            {
                if (value == _isPositionLevelsTopChecked)
                    return;

                _isPositionLevelsTopChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionLevelsTopChecked));
            }
        }

        private bool _isPositionLevelsTopChecked { get; set; }

        #endregion IsPositionLevelsTopChecked

        #region PositionsLevelTop

        public string PositionLevelsTop
        {
            get { return _positionLevelTop; }
            set
            {
                if (value.ToString() == _positionLevelTop || !IsValidDecimal(value))
                    return;

                _positionLevelTop = value.ToString();
                if (PositionLevelsTop.ToString().Length > 0)
                {
                    PositionLevelsTopBorderColor = DefaultBorderColor;
                    IsPositionLevelsTopChecked = Convert.ToDouble(PositionLevelsTop) > 0 
                                              || Convert.ToDouble(PositionLevelsTop) < 0;
                }

                OnPropertyChangedAsync(nameof(PositionLevelsTop));
            }
        }

        private string _positionLevelTop { get; set; }

        #endregion PositionsLevelTop

        #region IsPositionLevelsBottomChecked

        public bool IsPositionLevelsBottomChecked
        {
            get { return _isPositionLevelsBottomChecked; }
            set
            {
                if (value == _isPositionLevelsBottomChecked)
                    return;

                _isPositionLevelsBottomChecked = value;
                OnPropertyChangedAsync(nameof(IsPositionLevelsBottomChecked));
            }
        }

        private bool _isPositionLevelsBottomChecked { get; set; }

        #endregion IsPositionLevelsBottomChecked

        #region PositionLevelsBottom

        public string PositionLevelsBottom
        {
            get { return _positionLevelBottom; }
            set
            {
                if (value.ToString() == _positionLevelBottom || !IsValidDecimal(value))
                    return;

                _positionLevelBottom = value.ToString();
                if (PositionLevelsBottom.ToString().Length > 0)
                {
                    PositionLevelsTopBorderColor = DefaultBorderColor;
                    IsPositionLevelsBottomChecked = Convert.ToDouble(PositionLevelsBottom) > 0 
                                                    || Convert.ToDouble(PositionLevelsBottom) < 0;
                }

                OnPropertyChangedAsync(nameof(PositionLevelsBottom));
            }
        }

        private string _positionLevelBottom { get; set; }

        #endregion PositionLevelsBottom

        #region PositionLevelsBottomBorderColor

        public string PositionLevelsBottomBorderColor
        {
            get { return _positionLevelsBottomBorderColor; }
            set
            {
                if (value == _positionLevelsBottomBorderColor)
                    return;

                _positionLevelsBottomBorderColor = value;
                OnPropertyChangedAsync(nameof(PositionLevelsBottomBorderColor));
            }
        }

        private string _positionLevelsBottomBorderColor = "#ABADB3";

        #endregion PositionLevelsBottomBorderColor

        #region PositionLevelsTopBorderColor

        public string PositionLevelsTopBorderColor
        {
            get { return _positionLevelsTopBorderColor; }
            set
            {
                if (value == _positionLevelsTopBorderColor)
                    return;

                _positionLevelsTopBorderColor = value;
                OnPropertyChangedAsync(nameof(PositionLevelsTopBorderColor));
            }
        }

        private string _positionLevelsTopBorderColor = "#ABADB3";

        #endregion PositionLevelsTopBorderColor

        #endregion INotifyPropertyChange Member

        #region Constructor

        public DialogColumnPropertiesViewModel(MemberModifierFactory memberModifierFactory,
                                                ColumnProperties localColumnProperties,
                                                ColumnProperties globaColumnProperties,
                                                ColumnValuesGetter columnValuesGetter
                                                )
        {
            InitCommand();
            this.modifierFactory = memberModifierFactory;
            this.globaColumnProperties = globaColumnProperties;
            this.columnValuesGetter = columnValuesGetter;
            UpdateViewModel(localColumnProperties);

            PositionRotationComboBox = new List<string>() { "FRONT", "TOP", "BACK", "BELOW" };
            PositionVerticalComboBox = new List<string>() { "MIDDLE", "RIGHT", "LEFT" };
            PositionHorizontalComboBox = new List<string>() { "MIDDLE", "FRONT", "BEHIND" };

            SelectedDataInPositionVerticalComboBox = PositionVerticalComboBox[0];
            SelectedDataInPositionRotationComboBox = PositionRotationComboBox[0];
            SelectedDataInPositionHorizontalComboBox = PositionHorizontalComboBox[0];
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

        #region Command Methods

        private void CloseWindow(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSECOLUMNPROPERTYWINDOW);
        }

        private void OkButtonClick(object obj)
        {
            if (IsAllDataValid())
            {
                saveCheckedPropertiesToGlobalVariable();

                Messenger.Default.Send(true, MessengerToken.CLOSECOLUMNPROPERTYWINDOW);
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

                    if (IsPositionLevelsTopChecked)
                    {
                        memberModifier.ModifyTopPosition(Convert.ToDouble(PositionLevelsTop));
                    }

                    if (IsPositionLevelsBottomChecked)
                    {
                        memberModifier.ModifyBottomPosition(Convert.ToDouble(PositionLevelsBottom));
                    }
                }
            }
        }

        private void GetButtonClick(object obj)
        {
            try
            {
                ColumnProperties columnProperties = columnValuesGetter.GetColumnProperties();
                UpdateViewModel(columnProperties);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            IsPositionVerticalChecked = !_selectAll;
            IsPositionRotationChecked = !_selectAll;
            IsPositionHorizontalChecked = !_selectAll;
            IsPositionLevelsTopChecked = !_selectAll;
            IsPositionLevelsBottomChecked = !_selectAll;
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

        #endregion Command Methods

        #region Save Data

        private void saveCheckedPropertiesToGlobalVariable()
        {
            SelectedDataInLoadDataComboBox = globaColumnProperties.SelectedDataInLoadDataComboBox;
            SaveAttributesData();
            SaveNumberingData();
            SavePositionData();
        }

        private void SavePositionData()
        {
            if (IsPositionVerticalChecked)
            {
                globaColumnProperties.SelectedDataInPositionVerticalComboBox = SelectedDataInPositionVerticalComboBox;
                globaColumnProperties.PositionVerticalText = Convert.ToDouble(PositionVerticalText);
            }

            if (IsPositionRotationChecked)
            {
                globaColumnProperties.SelectedDataInPositionRotationComboBox = SelectedDataInPositionRotationComboBox;
                globaColumnProperties.PositionRotationText = Convert.ToDouble(PositionRotationText);
            }

            if (IsPositionHorizontalChecked)
            {
                globaColumnProperties.SelectedDataInPositionHorizontalComboBox = SelectedDataInPositionHorizontalComboBox;
                globaColumnProperties.PositionHorizontalText = Convert.ToDouble(PositionHorizontalText);
            }

            if (IsPositionLevelsTopChecked)
            {
                globaColumnProperties.PositionLevelsTopText = Convert.ToDouble(PositionLevelsTop);
            }

            if (IsPositionLevelsBottomChecked)
            {
                globaColumnProperties.PositionLevelsBottomText = Convert.ToDouble(PositionLevelsBottom);
            }
        }

        private void SaveAttributesData()
        {
            if (IsAttributesNameChecked)
            {
                globaColumnProperties.AttributesNameText = AttributesNameText;
            }

            if (IsAttributesProfileChecked)
            {
                globaColumnProperties.AttributesProfileText = AttributesProfileText;
            }

            if (IsAttributesMaterialChecked)
            {
                globaColumnProperties.AttributesMaterialText = AttributesMaterialText;
            }

            if (IsAttributesFinishChecked)
            {
                globaColumnProperties.AttributesFinishText = AttributesFinishText;
            }

            if (IsAttributesClassChecked)
            {
                globaColumnProperties.AttributesClassText = AttributesClassText;
            }
        }

        /// <summary>
        /// Remove method: make use of conditional binding directly in xamḷ. Only update if ticked.
        /// </summary>
        private void SaveNumberingData()
        {
            if (IsNumberingSeriesPartPrefixChecked)
            {
                globaColumnProperties.NumberingSeriesPartPrefixText = NumberingSeriesPartPrefixText;
            }

            if (IsNumberingSeriesPartStartumberChecked)
            {
                globaColumnProperties.NumberingSeriesPartStartNumberText = NumberingSeriesPartStartNumberText;
            }

            if (IsNumberingSeriesAssemblyPrefixChecked)
            {
                globaColumnProperties.NumberingSeriesAssemblyPrefixText = NumberingSeriesAssemblyPrefixText;
            }

            if (IsNumberingSeriesAssemblyStartumberChecked)
            {
                globaColumnProperties.NumberingSeriesAssemblyStartNumberText = NumberingSeriesAssemblyStartNumberText;
            }
        }

        #endregion Save Data

        #region Update Data

        private void UpdateViewModel(ColumnProperties columnProperties)
        {
            LoadData(columnProperties);
            UpdatePositionData(columnProperties);
            UpdateAttributesData(columnProperties);
            UpdateNumberingData(columnProperties);
        }

        private void UpdatePositionData(ColumnProperties columnProperties)
        {
            SelectedDataInPositionVerticalComboBox = columnProperties.SelectedDataInPositionVerticalComboBox;
            PositionVerticalText = columnProperties.PositionVerticalText.ToString();

            SelectedDataInPositionRotationComboBox = columnProperties.SelectedDataInPositionRotationComboBox;
            PositionRotationText = columnProperties.PositionRotationText.ToString();

            SelectedDataInPositionHorizontalComboBox = columnProperties.SelectedDataInPositionHorizontalComboBox;
            PositionHorizontalText = columnProperties.PositionHorizontalText.ToString();

            PositionLevelsTop = columnProperties.PositionLevelsTopText.ToString();
            PositionLevelsBottom = columnProperties.PositionLevelsBottomText.ToString();
        }

        private void SelectedProfile(string obj)
        {
            AttributesProfileText = obj;
        }

        private void LoadData(ColumnProperties columnProperties)
        {
            SelectedDataInLoadDataComboBox = columnProperties.SelectedDataInLoadDataComboBox;
        }

        private void UpdateAttributesData(ColumnProperties columnProperties)
        {
            AttributesNameText = columnProperties.AttributesNameText;
            AttributesProfileText = columnProperties.AttributesProfileText;
            AttributesMaterialText = columnProperties.AttributesMaterialText;
            AttributesFinishText = columnProperties.AttributesFinishText;
            AttributesClassText = columnProperties.AttributesClassText;
        }

        private void UpdateNumberingData(ColumnProperties columnProperties)
        {
            NumberingSeriesPartPrefixText = columnProperties.NumberingSeriesPartPrefixText;
            NumberingSeriesPartStartNumberText = columnProperties.NumberingSeriesPartStartNumberText;
            NumberingSeriesAssemblyPrefixText = columnProperties.NumberingSeriesAssemblyPrefixText;
            NumberingSeriesAssemblyStartNumberText = columnProperties.NumberingSeriesAssemblyStartNumberText;
        }

        #endregion Update Data

        #region Validation

        private bool IsAllDataValid()
        {
            ErrorText = string.Empty;
            bool isProfileValid = IsProfileValid();
            bool isAttributesClassValid = IsAttributesClassValid();
            bool isProfileLevelsValid = IsProfileLevelsValid();
            SelectTab(isProfileValid, isProfileLevelsValid);
            return isProfileValid && isProfileLevelsValid && isAttributesClassValid;
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

        private void SelectTab(bool isProfileValid, bool isProfileLevelsValid)
        {
            if (isProfileValid && !isProfileLevelsValid)
            {
                SelectedTabIndex = 1;
            }
        }

        private bool IsProfileLevelsValid()
        {
            bool valid = false;
            if (IsPositionLevelsTopChecked && IsPositionLevelsBottomChecked)
            {
                valid = new Validator().AreTopAndBottomPositionsValid
                                        (Convert.ToDouble(PositionLevelsTop), Convert.ToDouble(PositionLevelsBottom));
                if (!valid)
                {
                    SetErrorText(PositionLevelErrors);
                    SetLevelsError(true);
                }
                else
                {
                    SetLevelsError(false);
                }
            }
            else
            {
                SetLevelsError(false);
                valid = true;
            }
            return valid;
        }

        private void SetLevelsError(bool error)
        {
            if (error)
            {
                PositionLevelsTopBorderColor = ErrorBorderColor;
                PositionLevelsBottomBorderColor = ErrorBorderColor;
            }
            else
            {
                PositionLevelsTopBorderColor = DefaultBorderColor;
                PositionLevelsBottomBorderColor = DefaultBorderColor;
            }
        }

        #endregion Validation

        #endregion Private Methods

        public void Dispose()
        {
            base.Cleanup();
        }
    }
}