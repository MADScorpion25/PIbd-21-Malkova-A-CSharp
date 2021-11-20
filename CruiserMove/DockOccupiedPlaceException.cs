using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockOccupiedPlaceException : Exception
    {
        public DockOccupiedPlaceException() : base("Док не пустой, невозможно загрузить файл") { }
    }
}
