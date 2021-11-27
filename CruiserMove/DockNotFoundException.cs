using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockNotFoundException : Exception
    {
        public DockNotFoundException(int i) : base("Не найден крейсер по месту: " + i) { }
    }
}
