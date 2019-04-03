using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NeutroniumTest
{
    public class MainViewModel :  INotifyPropertyChanged
    {

        private string _address;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            Address = "https://www.ubtus.com/";
        }

        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(); }
        }


    }
}
