using MicroGUI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroGUI.ViewModel
{
    class MainWindowVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowVm()
        {
            ValueObjects = new ObservableCollection<BaseObject>();
            ValueObjects.Add(new EditableBoolObject("Activate"));
            ValueObjects.Add(new EditableIntObject("Cycles"));
            ValueObjects.Add(new EditableBoolObject("Enable"));
        }

        public ObservableCollection<BaseObject> ValueObjects { get; set; }

        public int ObjectCount => ValueObjects.Count;
    }
}
