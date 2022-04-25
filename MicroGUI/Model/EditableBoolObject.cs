using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroGUI.Model
{
    public class EditableBoolObject : EditableObject<bool>
    {
        public EditableBoolObject()
        {
        }

        public EditableBoolObject(string name) : base(name)
        {
        }
    }
}
