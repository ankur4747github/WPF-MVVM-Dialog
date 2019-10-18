using DialogBeamProperties.Model.ProfileFileData;
using DialogBeamProperties.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DialogBeamProperties.View
{
    /// <summary>
    /// Interaction logic for SelectProfile.xaml
    /// </summary>
    public partial class SelectProfile : Window
    {
        public SelectProfileViewModel ViewModel = new SelectProfileViewModel();
        public SelectProfile()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
        }

        internal void SetData(ProfileFileData allProfileFileData, string attributesProfileText)
        {
            ViewModel.SetData(allProfileFileData, attributesProfileText);
        }
    }
}
