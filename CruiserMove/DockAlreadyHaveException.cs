using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("На парковке уже есть такой крейсер"){ }
    }
}
