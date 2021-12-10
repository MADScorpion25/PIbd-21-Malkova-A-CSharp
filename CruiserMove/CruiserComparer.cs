using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class CruiserComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is CruiserSimp && y is WarCruiser)
            {
                return -1;

            }
            if (x is WarCruiser && y is CruiserSimp)
            {
                return 1;

            }
            if (x is CruiserSimp && y is CruiserSimp)
            {
                return ComparerCruiser((CruiserSimp)x, (CruiserSimp)y);
            }
            if (x is WarCruiser && y is WarCruiser)
            {
                return ComparerWarCruiser((WarCruiser)x, (WarCruiser)y);
            }

            return 0;
        }
        private int ComparerCruiser(CruiserSimp x, CruiserSimp y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerWarCruiser(WarCruiser x, WarCruiser y)
        {
            var res = ComparerCruiser(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.HelicopterStation != y.HelicopterStation)
            {
                return x.HelicopterStation.CompareTo(y.HelicopterStation);
            }
            if (x.Artillery != y.Artillery)
            {
                return x.Artillery.CompareTo(y.Artillery);
            }
            if (x.Locator != y.Locator)
            {
                return x.Locator.CompareTo(y.Locator);
            }
            return 0;
        }
    }
}
