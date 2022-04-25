using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroGUI.Model
{
    public class EditableObject<T> : BaseObject
    {
        public EditableObject()
        {
            Name = "Editable " + typeof(T);
        }

        public EditableObject(string name) : base(name)
        {
            
        }

        public T CurrentValue
        {
            get => currentValue;
            set
            {
                LastValue = currentValue;
                currentValue = value;
                OnPropertyChanged(nameof(CurrentValue));
            }
        }

        public T LastValue
        {
            get => lastValue;
            set
            {
                lastValue = value;
                OnPropertyChanged(nameof(LastValue));
            }
        }

        public void Undo()
        {
            CurrentValue = LastValue;
        }

        private T currentValue;
        private T lastValue;
    }
}
