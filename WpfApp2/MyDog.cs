using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class MyDog : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
    }

}
