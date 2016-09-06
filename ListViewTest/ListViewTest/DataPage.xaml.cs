using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewTest
{
    public partial class DataPage : ContentPage
    {
        public DataPage()
        {
            InitializeComponent();
            this.BindingContext = App.ViewModel;

        }

        private void ShowHideClicked(object sender, EventArgs e)
        {
            FilterLayout.IsVisible = !FilterLayout.IsVisible;
        }

        private void XamarinClicked(object sender, EventArgs e)
        {
            App.ViewModel.FilterBtnXamarin();
        }

        private void MicrosoftClicked(object sender, EventArgs e)
        {
            App.ViewModel.FilterBtnWindows();
        }

        private void AllClicked(object sender, EventArgs e)
        {
            App.ViewModel.InitDummyList();
        }
    }
}
