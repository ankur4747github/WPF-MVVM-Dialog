using DialogBeamProperties.CadInterfaces;
using DialogBeamProperties.Command;
using DialogBeamProperties.Constants;
using DialogBeamProperties.Helpers;
using DialogBeamProperties.Model;
using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.View;
using DialogBeamProperties.ViewModel.AbstractViewModel;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace DialogBeamProperties.ViewModel
{
    public class DialogBeamPropertiesViewModel : AbstractPropertyViewModel,IDisposable
    {
        
        #region Fields

        private readonly XDataWriter xDataWriter;
        private readonly BeamCreator beamCreator;

        private IBeamProperties _iproperties { get; set; }

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

        #region PositionOnPlaneComboBox

        public List<string> PositionOnPlaneComboBox
        {
            get { return _positionOnPlaneComboBox; }
            set
            {
                if (value == _positionOnPlaneComboBox)
                    return;

                _positionOnPlaneComboBox = value;
                OnPropertyChangedAsync(nameof(PositionOnPlaneComboBox));
            }
        }

        private List<string> _positionOnPlaneComboBox { get; set; }

        #endregion PositionOnPlaneComboBox

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

        public double PositionOnPlaneText
        {
            get { return _positionOnPlaneText; }
            set
            {
                if (value == _positionOnPlaneText)
                    return;

                _positionOnPlaneText = value;
                OnPropertyChangedAsync(nameof(PositionOnPlaneText));
            }
        }

        private double _positionOnPlaneText { get; set; }

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

        #region PositionAtDepthComboBox

        public List<string> PositionAtDepthComboBox
        {
            get { return _positionAtDepthComboBox; }
            set
            {
                if (value == _positionAtDepthComboBox)
                    return;

                _positionAtDepthComboBox = value;
                OnPropertyChangedAsync(nameof(PositionAtDepthComboBox));
            }
        }

        private List<string> _positionAtDepthComboBox { get; set; }

        #endregion PositionAtDepthComboBox

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

        public double PositionAtDepthText
        {
            get { return _positionAtDepthText; }
            set
            {
                if (value == _positionAtDepthText)
                    return;

                _positionAtDepthText = value;
                OnPropertyChangedAsync(nameof(PositionAtDepthText));
            }
        }

        private double _positionAtDepthText { get; set; }

        #endregion PositionAtDepthText

        #endregion INotifyPropertyChange Member

        #region Constructor

        public DialogBeamPropertiesViewModel(XDataWriter xDataWriter, BeamCreator beamCreator)
        {
            LoadDataComboBox = new List<string>();
            _allProfileFileData = new ProfileFileData();
            InitCommand();
            Task.Factory.StartNew(() => LoadProfileFiles());
            this.xDataWriter = xDataWriter;
            this.beamCreator = beamCreator;
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



        #endregion Constructor

        #region Public Methods

        public void SetPropertiesData(IBeamProperties iproperties)
        {
            this._iproperties = iproperties;
            UpdateData(iproperties);
        }

        public IBeamProperties GetPropertiesData()
        {
            return _iproperties;
        }

        #endregion Public Methods

        #region Private Methods

        #region Button Click

        private void CloseWindow(object obj)
        {
            if (IsAllDataValid())
            {
                _iproperties.LoadDataComboBox = LoadDataComboBox;
                _iproperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
                SaveNumberingData();
                SaveAttributesData();
                SavePositionData();
                Messenger.Default.Send(true, MessengerToken.CLOSEBEAMPROPERTYWINDOW);
                beamCreator.CreateBeam(_iproperties.AttributesProfileText, _iproperties.PositionRotationText);
            }
        }

        private void ApplyButtonClick(object obj)
        {
            if (IsAllDataValid())
            {
                _iproperties.LoadDataComboBox = LoadDataComboBox;
                _iproperties.SelectedDataInLoadDataComboBox = SelectedDataInLoadDataComboBox;
                SaveNumberingData();
                SaveAttributesData();
                SavePositionData();

                xDataWriter.WriteXDataToLine(_iproperties.AttributesProfileText, _iproperties.PositionRotationText);
            }
            
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
            selectProfile.SetData(_allProfileFileData, AttributesProfileText);
            selectProfile.ShowDialog();

            Messenger.Default.Unregister<string>(this,
                  MessengerToken.SELECTEDPROFILE, SelectedProfile);
        }

        #endregion Button Click

        #region Update Data

        private void UpdateData(IBeamProperties iproperties)
        {
            LoadData(iproperties);
            UpdatePositionData();
            UpdateAttributesData();
            UpdateNumberingData();
        }

        private void UpdatePositionData()
        {
            IsPositionOnPlaneChecked = _iproperties.IsPositionOnPlaneChecked;
            PositionOnPlaneComboBox = _iproperties.PositionOnPlaneComboBox;
            SelectedDataInPositionOnPlaneComboBox = _iproperties.SelectedDataInPositionOnPlaneComboBox;
            PositionOnPlaneText = _iproperties.PositionOnPlaneText;

            IsPositionRotationChecked = _iproperties.IsPositionRotationChecked;
            PositionRotationComboBox = _iproperties.PositionRotationComboBox;
            SelectedDataInPositionRotationComboBox = _iproperties.SelectedDataInPositionRotationComboBox;
            PositionRotationText = _iproperties.PositionRotationText;

            IsPositionAtDepthChecked = _iproperties.IsPositionAtDepthChecked;
            PositionAtDepthComboBox = _iproperties.PositionAtDepthComboBox;
            SelectedDataInPositionAtDepthComboBox = _iproperties.SelectedDataInPositionAtDepthComboBox;
            PositionAtDepthText = _iproperties.PositionAtDepthText;
        }

        private void SelectedProfile(string obj)
        {
            AttributesProfileText = obj;
        }

        private void LoadData(IBeamProperties iproperties)
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

        #region Save Data

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

        private void SavePositionData()
        {
            _iproperties.IsPositionOnPlaneChecked = IsPositionOnPlaneChecked;
            if (_iproperties.IsPositionOnPlaneChecked)
            {
                _iproperties.PositionOnPlaneComboBox = PositionOnPlaneComboBox;
                _iproperties.SelectedDataInPositionOnPlaneComboBox = SelectedDataInPositionOnPlaneComboBox;
                _iproperties.PositionOnPlaneText = PositionOnPlaneText;
            }

            _iproperties.IsPositionRotationChecked = IsPositionRotationChecked;
            if (_iproperties.IsPositionRotationChecked)
            {
                _iproperties.PositionRotationComboBox = PositionRotationComboBox;
                _iproperties.SelectedDataInPositionRotationComboBox = SelectedDataInPositionRotationComboBox;
                _iproperties.PositionRotationText = PositionRotationText;
            }

            _iproperties.IsPositionAtDepthChecked = IsPositionAtDepthChecked;
            if (_iproperties.IsPositionAtDepthChecked)
            {
                _iproperties.PositionAtDepthComboBox = PositionAtDepthComboBox;
                _iproperties.SelectedDataInPositionAtDepthComboBox = SelectedDataInPositionAtDepthComboBox;
                _iproperties.PositionAtDepthText = PositionAtDepthText;
            }
        }



        #endregion Save Data

        #region Validation
        private bool IsAllDataValid()
        {
            ErrorText = string.Empty;
            return IsProfileValid();
        }
        #endregion

        #endregion Private Methods

        public void Dispose()
        {
            base.Cleanup();
        }
    }
}