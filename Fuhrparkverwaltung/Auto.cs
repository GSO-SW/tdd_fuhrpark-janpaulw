using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        #region Attribute
        private double kilometerstand;
        private double fuellstandInLiter;
        private double verbrauch;
        #endregion


        #region Konstruktoren
        public Auto(double kilometerstand, double fuellstandInLiter, double verbrauch) : this(kilometerstand)
        {
            this.fuellstandInLiter = fuellstandInLiter;
            this.verbrauch = verbrauch;
        }
        public Auto(double kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }
        #endregion


        #region Fahren
        public void Fahren(double zurueckgelegteStreckeInKm)
        {
            if (ZurueckgelegteKilometerGroesserAlsNull(zurueckgelegteStreckeInKm))
            {
                if (FuellstandZuNiedrig(zurueckgelegteStreckeInKm))
                {
                    FuellstandUndKilometeranzahlBerechnen(zurueckgelegteStreckeInKm);
                }
                else
                {
                    kilometerstand += (fuellstandInLiter / verbrauch) * 100;
                }
            }
        }
        #endregion


        #region Verarbeitung der Abfragen in Methoden
        private bool ZurueckgelegteKilometerGroesserAlsNull(double zurueckgelegteStreckeInKm)
        {
            if (zurueckgelegteStreckeInKm > 0)
            {
                return true;
            }
            else
            {
                return false;
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
        private void FuellstandUndKilometeranzahlBerechnen(double zurueckgelegteStreckeInKm)
        {
            fuellstandInLiter -= (verbrauch * 100) / zurueckgelegteStreckeInKm;
            this.kilometerstand += zurueckgelegteStreckeInKm;
        }
        #endregion


        #region Eigenschaften
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
        #endregion
    }
}
