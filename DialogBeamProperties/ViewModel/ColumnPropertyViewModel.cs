﻿using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.Model.Properties;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel.AbstractViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DialogBeamProperties.ViewModel
{
    public class DialogColumnPropertiesViewModel : AbstractPropertyViewModel
    {
        #region Fields

        private readonly XDataWriter xDataWriter;
        private IColumnProperties _iproperties { get; set; }

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

        #region PositionVerticalComboBox

        public List<string> PositionVerticalComboBox
        {
            get { return _positionVerticalComboBox; }
            set
            {
                if (value == _positionVerticalComboBox)
                    return;

                _positionVerticalComboBox = value;
                OnPropertyChangedAsync(nameof(PositionVerticalComboBox));
            }
        }

        private List<string> _positionVerticalComboBox { get; set; }

        #endregion PositionVerticalComboBox

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
                if (value == _positionVerticalText)
                    return;

                _positionVerticalText = value;
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

        #region PositionRotationComboBox

        public List<string> PositionRotationComboBox
        {
            get { return _positionRotationComboBox; }
            set
            {
                if (value == _positionRotationComboBox)
                    return;

                _positionRotationComboBox = value;
                OnPropertyChangedAsync(nameof(PositionRotationComboBox));
            }
        }

        private List<string> _positionRotationComboBox { get; set; }

        #endregion PositionRotationComboBox

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
                if (value == _positionRotationText)
                    return;

                _positionRotationText = value;
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

        #region PositionHorizontalComboBox

        public List<string> PositionHorizontalComboBox
        {
            get { return _positionHorizontalComboBox; }
            set
            {
                if (value == _positionHorizontalComboBox)
                    return;

                _positionHorizontalComboBox = value;
                OnPropertyChangedAsync(nameof(PositionHorizontalComboBox));
            }
        }

        private List<string> _positionHorizontalComboBox { get; set; }

        #endregion PositionHorizontalComboBox

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
                if (value == _positionHorizontalText)
                    return;

                _positionHorizontalText = value;
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

        #region PositionLevelTopText

        public string PositionLevelsTopText
        {
            get { return _positionLevelTopText; }
            set
            {
                if (value == _positionLevelTopText)
                    return;

                _positionLevelTopText = value;
                OnPropertyChangedAsync(nameof(PositionLevelsTopText));
            }
        }

        private string _positionLevelTopText { get; set; }

        #endregion PositionLevelTopText

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

        #region PositionLevelBottomText

        public string PositionLevelsBottomText
        {
            get { return _positionLevelBottomText; }
            set
            {
                if (value == _positionLevelBottomText)
                    return;

                _positionLevelBottomText = value;
                OnPropertyChangedAsync(nameof(PositionLevelsBottomText));
            }
        }

        private string _positionLevelBottomText { get; set; }

        #endregion PositionLevelBottomText

        #region IsSelectProfileButtonEnable

        public bool IsSelectProfileButtonEnable
        {
            get { return _isSelectProfileButtonEnable; }
            set
            {
                if (value == _isSelectProfileButtonEnable)
                    return;

                _isSelectProfileButtonEnable = value;
                OnPropertyChangedAsync(nameof(IsSelectProfileButtonEnable));
            }
        }

        private bool _isSelectProfileButtonEnable { get; set; }

        #endregion IsSelectProfileButtonEnable

        #endregion INotifyPropertyChange Member

        #region Constructor

        public DialogColumnPropertiesViewModel(XDataWriter xDataWriter)
        {
            LoadDataComboBox = new List<string>();
            _allProfileFileData = new ProfileFileData();
            InitCommand();
            InitMessenger();
            Task.Factory.StartNew(() => LoadProfileFiles());
            this.xDataWriter = xDataWriter;
        }

        private void InitCommand()
        {
            ButtonCommand = new RelayCommand(new Action<object>(CloseWindow));
            ApplyButtonCommand = new RelayCommand(new Action<object>(ApplyButtonClick));
            ModifyButtonCommand = new RelayCommand(new Action<object>(ModifyButtonClick));
            GetButtonCommand = new RelayCommand(new Action<object>(GetButtonClick));
            SelectAllCheckBoxButtonCommand = new RelayCommand(new Action<object>(SelectAllCheckBoxButtonClick));
            SaveButtonCommand = new RelayCommand(new Action<object>(SaveButtonClick));
            LoadButtonCommand = new RelayCommand(new Action<object>(LoadButtonClick));
            SelectProfileButtonCommand = new RelayCommand(new Action<object>(SelectProfileButtonClick));
        }

        private void InitMessenger()
        {
            Messenger.Default.Unregister<string>(this,
                    MessengerToken.SELECTEDPROFILE, SelectedProfile);
            Messenger.Default.Register<string>(this,
                MessengerToken.SELECTEDPROFILE, SelectedProfile);
        }

        #endregion Constructor

        #region Public Methods

        public void SetProtertiesData(IColumnProperties iproperties)
        {
            this._iproperties = iproperties;
            UpdateData(iproperties);
        }

        public IColumnProperties GetPropertiesData()
        {
            return _iproperties;
        }

        #endregion Public Methods

        #region Private Methods

        #region Button Click

        private void CloseWindow(object obj)
        {
            Messenger.Default.Send(true, MessengerToken.CLOSECOLUMNPROPERTYWINDOW);
        }

        private void ApplyButtonClick(object obj)
        {
            _iproperties.LoadDataComboBox = LoadDataComboBox;
            _iproperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
            SaveNumberingData();
            SaveAttributesData();
            SavePositionData();

            xDataWriter.WriteXDataToLine(_iproperties.AttributesProfileText, 0);
        }

        private void ModifyButtonClick(object obj)
        {
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
            SelectProfile selectProfile = new SelectProfile();
            selectProfile.SetData(_allProfileFileData, AttributesProfileText);
            selectProfile.ShowDialog();
        }

        #endregion Button Click

        #region Save Data

        private void SavePositionData()
        {
            _iproperties.IsPositionVerticalChecked = IsPositionVerticalChecked;
            if (_iproperties.IsPositionVerticalChecked)
            {
                _iproperties.PositionVerticalComboBox = PositionVerticalComboBox;
                _iproperties.SelectedDataInPositionVerticalComboBox = SelectedDataInPositionVerticalComboBox;
                _iproperties.PositionVerticalText = PositionVerticalText;
            }

            _iproperties.IsPositionRotationChecked = IsPositionRotationChecked;
            if (_iproperties.IsPositionRotationChecked)
            {
                _iproperties.PositionRotationComboBox = PositionRotationComboBox;
                _iproperties.SelectedDataInPositionRotationComboBox = SelectedDataInPositionRotationComboBox;
                _iproperties.PositionRotationText = PositionRotationText;
            }

            _iproperties.IsPositionHorizontalChecked = IsPositionHorizontalChecked;
            if (_iproperties.IsPositionHorizontalChecked)
            {
                _iproperties.PositionHorizontalComboBox = PositionHorizontalComboBox;
                _iproperties.SelectedDataInPositionHorizontalComboBox = SelectedDataInPositionHorizontalComboBox;
                _iproperties.PositionHorizontalText = PositionHorizontalText;
            }

            _iproperties.IsPositionLevelsTopChecked = IsPositionLevelsTopChecked;
            if (_iproperties.IsPositionLevelsTopChecked)
            {
                _iproperties.PositionLevelsTopText = PositionLevelsTopText;
            }

            _iproperties.IsPositionLevelsBottomChecked = IsPositionLevelsBottomChecked;
            if (_iproperties.IsPositionLevelsBottomChecked)
            {
                _iproperties.PositionLevelsBottomText = PositionLevelsBottomText;
            }
        }
        private void SaveAttributesData()
        {
            _iproperties.IsAttributesNameChecked = IsAttributesNameChecked;
            if (_iproperties.IsAttributesNameChecked)
            {
                _iproperties.AttributesNameText = AttributesNameText;
            }

            _iproperties.IsAttributesProfileChecked = IsAttributesProfileChecked;
            if (_iproperties.IsAttributesProfileChecked)
            {
                _iproperties.AttributesProfileText = AttributesProfileText;
            }

            _iproperties.IsAttributesMaterialChecked = IsAttributesMaterialChecked;
            if (_iproperties.IsAttributesMaterialChecked)
            {
                _iproperties.AttributesMaterialText = AttributesMaterialText;
            }

            _iproperties.IsAttributesFinishChecked = IsAttributesFinishChecked;
            if (_iproperties.IsAttributesFinishChecked)
            {
                _iproperties.AttributesFinishText = AttributesFinishText;
            }

            _iproperties.IsAttributesClassChecked = IsAttributesClassChecked;
            if (_iproperties.IsAttributesClassChecked)
            {
                _iproperties.AttributesClassText = AttributesClassText;
            }
        }

        private void SaveNumberingData()
        {
            _iproperties.IsNumberingSeriesPartPrefixChecked = IsNumberingSeriesPartPrefixChecked;
            if (_iproperties.IsNumberingSeriesPartPrefixChecked)
            {
                _iproperties.NumberingSeriesPartPrefixText = NumberingSeriesPartPrefixText;
            }

            _iproperties.IsNumberingSeriesPartStartumberChecked = IsNumberingSeriesPartStartumberChecked;
            if (_iproperties.IsNumberingSeriesPartStartumberChecked)
            {
                _iproperties.NumberingSeriesPartStartNumberText = NumberingSeriesPartStartNumberText;
            }

            _iproperties.IsNumberingSeriesAssemblyPrefixChecked = IsNumberingSeriesAssemblyPrefixChecked;
            if (_iproperties.IsNumberingSeriesAssemblyPrefixChecked)
            {
                _iproperties.NumberingSeriesAssemblyPrefixText = NumberingSeriesAssemblyPrefixText;
            }

            _iproperties.IsNumberingSeriesAssemblyStartumberChecked = IsNumberingSeriesAssemblyStartumberChecked;
            if (_iproperties.IsNumberingSeriesAssemblyStartumberChecked)
            {
                _iproperties.NumberingSeriesAssemblyStartNumberText = NumberingSeriesAssemblyStartNumberText;
            }
        }
        #endregion Save Data

        #region Update Data

        private void UpdateData(IColumnProperties iproperties)
        {
            LoadData(iproperties);
            UpdatePositionData();
            UpdateAttributesData();
            UpdateNumberingData();
        }

        private void UpdatePositionData()
        {
            IsPositionVerticalChecked = _iproperties.IsPositionVerticalChecked;
            PositionVerticalComboBox = _iproperties.PositionVerticalComboBox;
            SelectedDataInPositionVerticalComboBox = _iproperties.SelectedDataInPositionVerticalComboBox;
            PositionVerticalText = _iproperties.PositionVerticalText;

            IsPositionRotationChecked = _iproperties.IsPositionRotationChecked;
            PositionRotationComboBox = _iproperties.PositionRotationComboBox;
            SelectedDataInPositionRotationComboBox = _iproperties.SelectedDataInPositionRotationComboBox;
            PositionRotationText = _iproperties.PositionRotationText;

            IsPositionHorizontalChecked = _iproperties.IsPositionHorizontalChecked;
            PositionHorizontalComboBox = _iproperties.PositionHorizontalComboBox;
            SelectedDataInPositionHorizontalComboBox = _iproperties.SelectedDataInPositionHorizontalComboBox;
            PositionHorizontalText = _iproperties.PositionHorizontalText;

            IsPositionLevelsTopChecked = _iproperties.IsPositionLevelsTopChecked;
            PositionLevelsTopText = _iproperties.PositionLevelsTopText;

            IsPositionLevelsBottomChecked = _iproperties.IsPositionLevelsBottomChecked;
            PositionLevelsBottomText = _iproperties.PositionLevelsBottomText;
        }

        private void SelectedProfile(string obj)
        {
            AttributesProfileText = obj;
        }

        private void LoadData(IColumnProperties iproperties)
        {
            LoadDataComboBox = iproperties.LoadDataComboBox;
            SelectedDataInLoadDataComboBox = iproperties.SelectedDataInLoadDataComboBox;
        }

        private void UpdateAttributesData()
        {
            IsAttributesNameChecked = _iproperties.IsAttributesNameChecked;
            AttributesNameText = _iproperties.AttributesNameText;
            IsAttributesProfileChecked = _iproperties.IsAttributesProfileChecked;
            AttributesProfileText = _iproperties.AttributesProfileText;
            IsAttributesMaterialChecked = _iproperties.IsAttributesMaterialChecked;
            AttributesMaterialText = _iproperties.AttributesMaterialText;
            IsAttributesFinishChecked = _iproperties.IsAttributesFinishChecked;
            AttributesFinishText = _iproperties.AttributesFinishText;
            IsAttributesClassChecked = _iproperties.IsAttributesClassChecked;
            AttributesClassText = _iproperties.AttributesClassText;
        }

        private void UpdateNumberingData()
        {
            IsNumberingSeriesPartPrefixChecked = _iproperties.IsNumberingSeriesPartPrefixChecked;
            NumberingSeriesPartPrefixText = _iproperties.NumberingSeriesPartPrefixText;
            IsNumberingSeriesPartStartumberChecked = _iproperties.IsNumberingSeriesPartStartumberChecked;
            NumberingSeriesPartStartNumberText = _iproperties.NumberingSeriesPartStartNumberText;
            IsNumberingSeriesAssemblyPrefixChecked = _iproperties.IsNumberingSeriesAssemblyPrefixChecked;
            NumberingSeriesAssemblyPrefixText = _iproperties.NumberingSeriesAssemblyPrefixText;
            IsNumberingSeriesAssemblyStartumberChecked = _iproperties.IsNumberingSeriesAssemblyStartumberChecked;
            NumberingSeriesAssemblyStartNumberText = _iproperties.NumberingSeriesAssemblyStartNumberText;
        }

        #endregion Update Data


        #endregion Private Methods
    }
}