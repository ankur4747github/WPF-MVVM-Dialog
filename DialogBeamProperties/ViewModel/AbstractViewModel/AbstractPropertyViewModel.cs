using DialogBeamProperties.Model;
using DialogBeamProperties.Model.ProfileFileData;
using GalaSoft.MvvmLight;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace DialogBeamProperties.ViewModel.AbstractViewModel
{
    public abstract class AbstractPropertyViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region Fields

        

        protected bool _selectAll = false;
        protected ProfileFileData _allProfileFileData { get; set; }

        #endregion Fields

        #region INotifyPropertyChange Member

        #region LoadDataComboBox

        public List<string> LoadDataComboBox
        {
            get { return _loadDataComboBox; }
            set
            {
                if (value == _loadDataComboBox)
                    return;

                _loadDataComboBox = value;
                OnPropertyChangedAsync(nameof(LoadDataComboBox));
            }
        }

        private List<string> _loadDataComboBox { get; set; }

        #endregion LoadDataComboBox

        #region SelectedDataInLoadDataComboBox

        public string SelectedDataInLoadDataComboBox
        {
            get { return _selectedDataInLoadDataComboBox; }
            set
            {
                if (value == _selectedDataInLoadDataComboBox)
                    return;

                _selectedDataInLoadDataComboBox = value;
                OnPropertyChangedAsync(nameof(SelectedDataInLoadDataComboBox));
            }
        }

        private string _selectedDataInLoadDataComboBox { get; set; }

        #endregion SelectedDataInLoadDataComboBox

        #region IsNumberingSeriesPartPrefixChecked

        public bool IsNumberingSeriesPartPrefixChecked
        {
            get { return _isNumberingSeriesPartPrefixChecked; }
            set
            {
                if (value == _isNumberingSeriesPartPrefixChecked)
                    return;

                _isNumberingSeriesPartPrefixChecked = value;
                OnPropertyChangedAsync(nameof(IsNumberingSeriesPartPrefixChecked));
            }
        }

        private bool _isNumberingSeriesPartPrefixChecked { get; set; }

        #endregion IsNumberingSeriesPartPrefixChecked

        #region NumberingSeriesPartPrefixText

        public string NumberingSeriesPartPrefixText
        {
            get { return _numberingSeriesPartPrefixText; }
            set
            {
                if (value == _numberingSeriesPartPrefixText)
                    return;

                _numberingSeriesPartPrefixText = value;
                OnPropertyChangedAsync(nameof(NumberingSeriesPartPrefixText));
            }
        }

        private string _numberingSeriesPartPrefixText { get; set; }

        #endregion NumberingSeriesPartPrefixText

        #region IsNumberingSeriesPartStartumberChecked

        public bool IsNumberingSeriesPartStartumberChecked
        {
            get { return _isNumberingSeriesPartStartumberChecked; }
            set
            {
                if (value == _isNumberingSeriesPartStartumberChecked)
                    return;

                _isNumberingSeriesPartStartumberChecked = value;
                OnPropertyChangedAsync(nameof(IsNumberingSeriesPartStartumberChecked));
            }
        }

        private bool _isNumberingSeriesPartStartumberChecked { get; set; }

        #endregion IsNumberingSeriesPartStartumberChecked

        #region NumberingSeriesPartStartNumberText

        public string NumberingSeriesPartStartNumberText
        {
            get { return _numberingSeriesPartStartNumberText; }
            set
            {
                if (value == _numberingSeriesPartStartNumberText)
                    return;

                _numberingSeriesPartStartNumberText = value;
                OnPropertyChangedAsync(nameof(NumberingSeriesPartStartNumberText));
            }
        }

        private string _numberingSeriesPartStartNumberText { get; set; }

        #endregion NumberingSeriesPartStartNumberText

        #region IsNumberingSeriesAssemblyPrefixChecked

        public bool IsNumberingSeriesAssemblyPrefixChecked
        {
            get { return _isNumberingSeriesAssemblyPrefixChecked; }
            set
            {
                if (value == _isNumberingSeriesAssemblyPrefixChecked)
                    return;

                _isNumberingSeriesAssemblyPrefixChecked = value;
                OnPropertyChangedAsync(nameof(IsNumberingSeriesAssemblyPrefixChecked));
            }
        }

        private bool _isNumberingSeriesAssemblyPrefixChecked { get; set; }

        #endregion IsNumberingSeriesAssemblyPrefixChecked

        #region NumberingSeriesAssemblyPrefixText

        public string NumberingSeriesAssemblyPrefixText
        {
            get { return _numberingSeriesAssemblyPrefixText; }
            set
            {
                if (value == _numberingSeriesAssemblyPrefixText)
                    return;

                _numberingSeriesAssemblyPrefixText = value;
                OnPropertyChangedAsync(nameof(NumberingSeriesAssemblyPrefixText));
            }
        }

        private string _numberingSeriesAssemblyPrefixText { get; set; }

        #endregion NumberingSeriesAssemblyPrefixText

        #region IsNumberingSeriesAssemblyStartumberChecked

        public bool IsNumberingSeriesAssemblyStartumberChecked
        {
            get { return _isNumberingSeriesAssemblyStartumberChecked; }
            set
            {
                if (value == _isNumberingSeriesAssemblyStartumberChecked)
                    return;

                _isNumberingSeriesAssemblyStartumberChecked = value;
                OnPropertyChangedAsync(nameof(IsNumberingSeriesAssemblyStartumberChecked));
            }
        }

        private bool _isNumberingSeriesAssemblyStartumberChecked { get; set; }

        #endregion IsNumberingSeriesAssemblyStartumberChecked

        #region NumberingSeriesAssemblyStartNumberText

        public string NumberingSeriesAssemblyStartNumberText
        {
            get { return _numberingSeriesAssemblyStartNumberText; }
            set
            {
                if (value == _numberingSeriesAssemblyStartNumberText)
                    return;

                _numberingSeriesAssemblyStartNumberText = value;
                OnPropertyChangedAsync(nameof(NumberingSeriesAssemblyStartNumberText));
            }
        }

        private string _numberingSeriesAssemblyStartNumberText { get; set; }

        #endregion NumberingSeriesAssemblyStartNumberText

        #region IsAttributesNameChecked

        public bool IsAttributesNameChecked
        {
            get { return _isAttributesNameChecked; }
            set
            {
                if (value == _isAttributesNameChecked)
                    return;

                _isAttributesNameChecked = value;
                OnPropertyChangedAsync(nameof(IsAttributesNameChecked));
            }
        }

        private bool _isAttributesNameChecked { get; set; }

        #endregion IsAttributesNameChecked

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

        private string _attributesNameText { get; set; }

        #endregion AttributesNameText

        #region IsAttributesProfileChecked

        public bool IsAttributesProfileChecked
        {
            get { return _isAttributesProfileChecked; }
            set
            {
                if (value == _isAttributesProfileChecked)
                    return;

                _isAttributesProfileChecked = value;
                OnPropertyChangedAsync(nameof(IsAttributesProfileChecked));
            }
        }

        private bool _isAttributesProfileChecked { get; set; }

        #endregion IsAttributesProfileChecked

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

        #region AttributesProfileText

        public string AttributesProfileText
        {
            get { return _attributesProfileText; }
            set
            {
                if (value == _attributesProfileText)
                    return;

                _attributesProfileText = value;

                IsSelectProfileButtonEnable = AttributesProfileText.Trim().Length > 1;
                OnPropertyChangedAsync(nameof(AttributesProfileText));
            }
        }

        private string _attributesProfileText { get; set; }

        #endregion AttributesProfileText

        #region IsAttributesMaterialChecked

        public bool IsAttributesMaterialChecked
        {
            get { return _isAttributesMaterialChecked; }
            set
            {
                if (value == _isAttributesMaterialChecked)
                    return;

                _isAttributesMaterialChecked = value;
                OnPropertyChangedAsync(nameof(IsAttributesMaterialChecked));
            }
        }

        private bool _isAttributesMaterialChecked { get; set; }

        #endregion IsAttributesMaterialChecked

        #region AttributesMaterialText

        public string AttributesMaterialText
        {
            get { return _attributesMaterialText; }
            set
            {
                if (value == _attributesMaterialText)
                    return;

                _attributesMaterialText = value;
                OnPropertyChangedAsync(nameof(AttributesMaterialText));
            }
        }

        private string _attributesMaterialText { get; set; }

        #endregion AttributesMaterialText

        #region IsAttributesFinishChecked

        public bool IsAttributesFinishChecked
        {
            get { return _isAttributesFinishChecked; }
            set
            {
                if (value == _isAttributesFinishChecked)
                    return;

                _isAttributesFinishChecked = value;
                OnPropertyChangedAsync(nameof(IsAttributesFinishChecked));
            }
        }

        private bool _isAttributesFinishChecked { get; set; }

        #endregion IsAttributesFinishChecked

        #region AttributesFinishText

        public string AttributesFinishText
        {
            get { return _attributesFinishText; }
            set
            {
                if (value == _attributesFinishText)
                    return;

                _attributesFinishText = value;
                OnPropertyChangedAsync(nameof(AttributesFinishText));
            }
        }

        private string _attributesFinishText { get; set; }

        #endregion AttributesFinishText

        #region IsAttributesClassChecked

        public bool IsAttributesClassChecked
        {
            get { return _isAttributesClassChecked; }
            set
            {
                if (value == _isAttributesClassChecked)
                    return;

                _isAttributesClassChecked = value;
                OnPropertyChangedAsync(nameof(IsAttributesClassChecked));
            }
        }

        private bool _isAttributesClassChecked { get; set; }

        #endregion IsAttributesClassChecked

        #region AttributesClassText

        public string AttributesClassText
        {
            get { return _attributesClassText; }
            set
            {
                if (value == _attributesClassText)
                    return;

                _attributesClassText = value;
                OnPropertyChangedAsync(nameof(AttributesClassText));
            }
        }

        private string _attributesClassText { get; set; }

        #endregion AttributesClassText

        #endregion INotifyPropertyChange Member

        #region Button Command

        #region Close Button Command

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

        #endregion Close Button Command

        #region Apply Buttom Command

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

        #endregion Apply Buttom Command

        #region Modify Buttom Command

        private ICommand _modifyButtonCommand;

        public ICommand ModifyButtonCommand
        {
            get
            {
                return _modifyButtonCommand;
            }
            set
            {
                _modifyButtonCommand = value;
            }
        }

        #endregion Modify Buttom Command

        #region Get Buttom Command

        private ICommand _getButtonCommand;

        public ICommand GetButtonCommand
        {
            get
            {
                return _getButtonCommand;
            }
            set
            {
                _getButtonCommand = value;
            }
        }

        #endregion Get Buttom Command

        #region SelectAllCheckBox Buttom Command

        private ICommand _selectAllCheckButtonCommand;

        public ICommand SelectAllCheckBoxButtonCommand
        {
            get
            {
                return _selectAllCheckButtonCommand;
            }
            set
            {
                _selectAllCheckButtonCommand = value;
            }
        }

        #endregion SelectAllCheckBox Buttom Command

        #region Save Buttom Command

        private ICommand _saveButtonCommand;

        public ICommand SaveButtonCommand
        {
            get
            {
                return _saveButtonCommand;
            }
            set
            {
                _saveButtonCommand = value;
            }
        }

        #endregion Save Buttom Command

        #region Load Buttom Command

        private ICommand _loadButtonCommand;

        public ICommand LoadButtonCommand
        {
            get
            {
                return _loadButtonCommand;
            }
            set
            {
                _loadButtonCommand = value;
            }
        }

        #endregion Load Buttom Command

        #region SelectProfile Buttom Command

        private ICommand _selectButtonCommand;

        public ICommand SelectProfileButtonCommand
        {
            get
            {
                return _selectButtonCommand;
            }
            set
            {
                _selectButtonCommand = value;
            }
        }

        #endregion SelectProfile Buttom Command

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

        #region Load Profile Files Into List

        protected void LoadProfileFiles()
        {
            string temp = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (File.Exists(Path.Combine(temp, "Files", "Profile", "beams.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "beams.json"), ref _allProfileFileData.Beams);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "china-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "china-profiles.json"), ref _allProfileFileData.ChinaProfiles);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "usimperial-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "usimperial-profiles.json"), ref _allProfileFileData.UsimperialProfiles);
            }

            if (File.Exists(Path.Combine(temp, "Files", "Profile", "usmetric-profiles.json")))
            {
                LoadFiles(Path.Combine(temp, "Files", "Profile", "usmetric-profiles.json"), ref _allProfileFileData.UsmetricProfiles);
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
}