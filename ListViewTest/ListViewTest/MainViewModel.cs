using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTest
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            InitDummyList();
        }


        private List<string> _displayList;
        public List<string> DisplayList
        {
            get { return _displayList; }
            set
            {
                _displayList = value;
                NotifyPropertyChanged("DisplayList");
            }
        }

        private List<string> _dataList;

        public List<string> DataList
        {
            get { return _dataList; }
            set
            {
                _dataList = value;
                NotifyPropertyChanged("DataList");
            }
        }


        public void FilterBtnXamarin()
        {
            DisplayList = DataList.Where(s => s.ToLower().Contains("xamarin")).ToList();
        }

        public void FilterBtnWindows()
        {
            DisplayList = DataList.Where(s => s.ToLower().Contains("windows")).ToList();
        }

        public void InitDummyList()
        {
            DataList = new List<string>() { "Xamarin", "Xamarin.Android", "Xamarin.iOS", "Xamarin.Forms", "Windows 10", "Windows Phone", "Windows 8", "Windows 8.1" };
            DisplayList = DataList;
        }







        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
