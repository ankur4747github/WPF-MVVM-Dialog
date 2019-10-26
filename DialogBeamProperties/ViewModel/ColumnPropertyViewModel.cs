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
        private const string PositionLevelErrors = "Position Levels should not be equals.";

        #region Fields

        private readonly XDataWriter xDataWriter;
        private readonly ColumnProperties localColumnProperties;
        private readonly ColumnProperties globaColumnProperties;

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

        public double PositionVerticalText
        {
            get { return _positionVerticalText; }
            set
            {
                if (value == _positionVerticalText)
                    return;

                _positionVerticalText = value;
                OnPropertyChangedAsync(nameof(PositionVerticalText));
            }
        }

        private double _positionVerticalText { get; set; }

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

        public double PositionRotationText
        {
            get { return _positionRotationText; }
            set
            {
                if (value == _positionRotationText)
                    return;

                _positionRotationText = value;
                OnPropertyChangedAsync(nameof(PositionRotationText));
            }
        }

        private double _positionRotationText { get; set; }

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

        public double PositionHorizontalText
        {
            get { return _positionHorizontalText; }
            set
            {
                if (value == _positionHorizontalText)
                    return;

                _positionHorizontalText = value;
                OnPropertyChangedAsync(nameof(PositionHorizontalText));
            }
        }

        private double _positionHorizontalText { get; set; }

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

        public double PositionLevelsTop
        {
            get { return _positionLevelTop; }
            set
            {
                if (value == _positionLevelTop)
                    return;

                _positionLevelTop = value;
                if (PositionLevelsTop.ToString().Length > 0)
                {
                    PositionLevelsTopBorderColor = DefaultBorderColor;
                }
                OnPropertyChangedAsync(nameof(PositionLevelsTop));
            }
        }

        private double _positionLevelTop { get; set; }

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

        public double PositionLevelsBottom
        {
            get { return _positionLevelBottom; }
            set
            {
                if (value == _positionLevelBottom)
                    return;

                _positionLevelBottom = value;
                if (PositionLevelsBottom.ToString().Length > 0)
                {
                    PositionLevelsTopBorderColor = DefaultBorderColor;
                }
                OnPropertyChangedAsync(nameof(PositionLevelsBottom));
            }
        }

        private double _positionLevelBottom { get; set; }

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

        public DialogColumnPropertiesViewModel(XDataWriter xDataWriter,
                                                ColumnProperties localColumnProperties,
                                                ColumnProperties globaColumnProperties)
        {
            InitCommand();
            this.xDataWriter = xDataWriter;
            this.localColumnProperties = localColumnProperties; // Bind everything in the view to to the local beam properties, but only update the binding if the relevant check box is checked.
            this.globaColumnProperties = globaColumnProperties;
            UpdateData(localColumnProperties);

            PositionRotationComboBox = new List<string>() { "Front", "Top", "Back", "Below" };
            PositionVerticalComboBox = new List<string>() { "Middle", "Right", "Left" };
            PositionHorizontalComboBox = new List<string>() { "Middle", "Front", "Behind" };

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

        #region Button Click

        private void CloseWindow(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSECOLUMNPROPERTYWINDOW);
        }

        private void OkButtonClick(object obj)
        {
            localColumnProperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
            SaveNumberingData();
            SaveAttributesData();
            SavePositionData();
            if (IsAllDataValid())
            {
                Messenger.Default.Send(true, MessengerToken.CLOSECOLUMNPROPERTYWINDOW);
            }
        }

        private void ApplyButtonClick(object obj)
        {
            localColumnProperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
            SaveNumberingData();
            SaveAttributesData();
            SavePositionData();
            if (IsAllDataValid())
            {
                xDataWriter.WriteXDataToLine(localColumnProperties.AttributesProfileText, localColumnProperties.PositionRotationText);
            }
        }

        private void ModifyButtonClick(object obj)
        {
            localColumnProperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
            SaveNumberingData();
            SaveAttributesData();
            SavePositionData();
            if (IsAllDataValid())
            {
                xDataWriter.WriteXDataToLine(localColumnProperties.AttributesProfileText, localColumnProperties.PositionRotationText);
            }
        }

        private void GetButtonClick(object obj)
        {
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

        #endregion Button Click

        #region Save Data

        /// <summary>
        /// Remove method: make use of conditional binding directly in xamḷ. Only update if ticked.
        /// </summary>
        private void SavePositionData()
        {
            if (IsPositionVerticalChecked)
            {
                localColumnProperties.SelectedDataInPositionVerticalComboBox = SelectedDataInPositionVerticalComboBox;
                localColumnProperties.PositionVerticalText = PositionVerticalText;
            }

            if (IsPositionRotationChecked)
            {
                localColumnProperties.SelectedDataInPositionRotationComboBox = SelectedDataInPositionRotationComboBox;
                localColumnProperties.PositionRotationText = PositionRotationText;
            }

            if (IsPositionHorizontalChecked)
            {
                localColumnProperties.SelectedDataInPositionHorizontalComboBox = SelectedDataInPositionHorizontalComboBox;
                localColumnProperties.PositionHorizontalText = PositionHorizontalText;
            }

            if (IsPositionLevelsTopChecked)
            {
                localColumnProperties.PositionLevelsTopText = PositionLevelsTop;
            }

            if (IsPositionLevelsBottomChecked)
            {
                localColumnProperties.PositionLevelsBottomText = PositionLevelsBottom;
            }
        }

        /// <summary>
        /// Remove method: make use of conditional binding directly in xamḷ. Only update if ticked.
        /// </summary>
        private void SaveAttributesData()
        {
            if (IsAttributesNameChecked)
            {
                localColumnProperties.AttributesNameText = AttributesNameText;
            }

            if (IsAttributesProfileChecked)
            {
                localColumnProperties.AttributesProfileText = AttributesProfileText;
            }

            if (IsAttributesMaterialChecked)
            {
                localColumnProperties.AttributesMaterialText = AttributesMaterialText;
            }

            if (IsAttributesFinishChecked)
            {
                localColumnProperties.AttributesFinishText = AttributesFinishText;
            }

            if (IsAttributesClassChecked)
            {
                localColumnProperties.AttributesClassText = AttributesClassText;
            }
        }

        /// <summary>
        /// Remove method: make use of conditional binding directly in xamḷ. Only update if ticked.
        /// </summary>
        private void SaveNumberingData()
        {
            if (IsNumberingSeriesPartPrefixChecked)
            {
                localColumnProperties.NumberingSeriesPartPrefixText = NumberingSeriesPartPrefixText;
            }

            if (IsNumberingSeriesPartStartumberChecked)
            {
                localColumnProperties.NumberingSeriesPartStartNumberText = NumberingSeriesPartStartNumberText;
            }

            if (IsNumberingSeriesAssemblyPrefixChecked)
            {
                localColumnProperties.NumberingSeriesAssemblyPrefixText = NumberingSeriesAssemblyPrefixText;
            }

            if (IsNumberingSeriesAssemblyStartumberChecked)
            {
                localColumnProperties.NumberingSeriesAssemblyStartNumberText = NumberingSeriesAssemblyStartNumberText;
            }
        }

        #endregion Save Data

        #region Update Data

        private void UpdateData(ColumnProperties iproperties)
        {
            LoadData(iproperties);
            UpdatePositionData();
            UpdateAttributesData();
            UpdateNumberingData();
        }

        private void UpdatePositionData()
        {
            SelectedDataInPositionVerticalComboBox = localColumnProperties.SelectedDataInPositionVerticalComboBox;
            PositionVerticalText = localColumnProperties.PositionVerticalText;

            SelectedDataInPositionRotationComboBox = localColumnProperties.SelectedDataInPositionRotationComboBox;
            PositionRotationText = localColumnProperties.PositionRotationText;

            SelectedDataInPositionHorizontalComboBox = localColumnProperties.SelectedDataInPositionHorizontalComboBox;
            PositionHorizontalText = localColumnProperties.PositionHorizontalText;

            PositionLevelsTop = localColumnProperties.PositionLevelsTopText;
            PositionLevelsBottom = localColumnProperties.PositionLevelsBottomText;
        }

        private void SelectedProfile(string obj)
        {
            AttributesProfileText = obj;
        }

        private void LoadData(ColumnProperties iproperties)
        {
            SelectedDataInLoadDataComboBox = iproperties.SelectedDataInLoadDataComboBox;
        }

        private void UpdateAttributesData()
        {
            AttributesNameText = localColumnProperties.AttributesNameText;
            AttributesProfileText = localColumnProperties.AttributesProfileText;
            AttributesMaterialText = localColumnProperties.AttributesMaterialText;
            AttributesFinishText = localColumnProperties.AttributesFinishText;
            AttributesClassText = localColumnProperties.AttributesClassText;
        }

        private void UpdateNumberingData()
        {
            NumberingSeriesPartPrefixText = localColumnProperties.NumberingSeriesPartPrefixText;
            NumberingSeriesPartStartNumberText = localColumnProperties.NumberingSeriesPartStartNumberText;
            NumberingSeriesAssemblyPrefixText = localColumnProperties.NumberingSeriesAssemblyPrefixText;
            NumberingSeriesAssemblyStartNumberText = localColumnProperties.NumberingSeriesAssemblyStartNumberText;
        }

        #endregion Update Data

        #region Validation

        private bool IsAllDataValid()
        {
            ErrorText = string.Empty;
            bool isProfileValid = IsProfileValid();
            bool isProfileLevelsValid = IsProfileLevelsValid();
            SelectTab(isProfileValid, isProfileLevelsValid);
            return isProfileValid && isProfileLevelsValid;
        }

        private bool IsProfileValid()
        {
            bool validProfile = false;
            try
            {
                if (IsAttributesProfileChecked)
                {
                    validProfile = new Validator().IsValidProfile(localColumnProperties);
                    SetErrorOnScreenIfProfileError(validProfile);
                }
                else
                {
                    validProfile = true;
                }
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
                valid = new Validator().AreTopAndBottomPositionsValid(PositionLevelsTop, PositionLevelsBottom);
                if (!valid)
                {
                    SetErrorText(PositionLevelErrors);
                    PositionLevelsTopBorderColor = ErrorBorderColor;
                    PositionLevelsBottomBorderColor = ErrorBorderColor;
                }
                else
                {
                    PositionLevelsTopBorderColor = DefaultBorderColor;
                    PositionLevelsBottomBorderColor = DefaultBorderColor;
                }
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        #endregion Validation

        #endregion Private Methods

        public void Dispose()
        {
            base.Cleanup();
        }
    }
}