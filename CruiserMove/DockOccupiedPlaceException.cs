using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockOccupiedPlaceException : Exception
    {
        public DockOccupiedPlaceException(String key) : base($"Док с именем {key} уже существует") { }
    }
}
