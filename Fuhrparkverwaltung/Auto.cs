using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private double kilometerstand;
        private double fuellstandInLiter;
        private double verbrauch;

        public Auto(double kilometerstand, double fuellstandInLiter, double verbrauch) : this(kilometerstand)
        {
            this.fuellstandInLiter = fuellstandInLiter;
            this.verbrauch = verbrauch;
        }

        public Auto(double kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public void Fahren(double zurueckgelegteStreckeInKm)
        {
            if (zurueckgelegteStreckeInKm > 0)
            {
                if (FuellstandZuNiedrig(zurueckgelegteStreckeInKm))
                {
                    fuellstandInLiter -=  (verbrauch/100) * zurueckgelegteStreckeInKm;
                    this.kilometerstand += zurueckgelegteStreckeInKm;
                }
                else
                {
                    kilometerstand += (fuellstandInLiter / verbrauch) * 100;
                }
            }
        }

        private bool FuellstandZuNiedrig(double zurueckgelegteStreckeInKm)
        {
            if (fuellstandInLiter >= (verbrauch/100*zurueckgelegteStreckeInKm))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Kilometerstand
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
