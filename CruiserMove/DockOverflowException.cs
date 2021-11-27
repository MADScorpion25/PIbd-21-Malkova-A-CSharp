using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockOverflowException : Exception
    {
        public DockOverflowException() : base("В доке нет свободных мест"){}
    }
}
