using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Races.DAL.Cars;

namespace Races.DAL
{
    public interface IPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
