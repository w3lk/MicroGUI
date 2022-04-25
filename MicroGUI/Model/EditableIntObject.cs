using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroGUI.Model
{
    public class EditableIntObject : EditableObject<int>
    {
        public EditableIntObject()
        {
        }

        public EditableIntObject(string name) : base(name)
        {
        }
    }
}
