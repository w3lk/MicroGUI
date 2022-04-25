using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroGUI.Model
{
    public class BaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseObject()
        {
            Name = "BaseObject";
            Id = new Guid();
        }

        public BaseObject(string _name)
        {
            Name = _name;
        }

        public String Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Guid Id
        {
            get => id; 
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }


        private string name;
        private Guid id;

        internal void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        
    }
}
