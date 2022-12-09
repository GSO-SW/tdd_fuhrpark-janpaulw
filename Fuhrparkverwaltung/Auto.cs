using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double fuellstandInLiter;
        private double verbrauch;

        public Auto(int kilometerstand, double fuellstandInLiter, double verbrauch) : this(kilometerstand)
        {
            this.fuellstandInLiter = fuellstandInLiter;
            this.verbrauch = verbrauch;
        }

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public void Fahren(int zurueckgelegteStreckeInKm)
        {
            if (zurueckgelegteStreckeInKm > 0)
            {
                this.kilometerstand += zurueckgelegteStreckeInKm;
                fuellstandInLiter -=  (verbrauch*100) / zurueckgelegteStreckeInKm;
            }
        }
        public int Kilometerstand
        {
            get 
            { 
                return this.kilometerstand;
            }
        }
        public double FuellstandInLiter
        {
            get
            {
                return fuellstandInLiter;
            }
        }
    }
}
