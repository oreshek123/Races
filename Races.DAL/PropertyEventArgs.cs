using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Races.DAL.Cars;

namespace Races.DAL
{
    public class PropertyEventArgs
    {
        public object ChangedProperty { get; set; }
        public string Name { get; set; }

        public PropertyEventArgs(object obj, string name)
        {
            this.ChangedProperty = obj;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
