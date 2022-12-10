using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
         public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            double kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            double streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Kilometerstand_SollNichtVerändertWerdenBeiNegativemWert()
        {
            //Arragne
            double kilometerstand = 10;
            Auto a = new Auto(kilometerstand);
            double streckeInKilometern = -10;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(kilometerstand, a.Kilometerstand);
        }
        [TestMethod]
        public void Verbrauch_KannBerechnetWerden()
        {
            //Arrange
            double kilometerstand = 10;
            double fuellstandInLiter = 30;
            double verbrauch = 5.7;
            Auto a = new Auto(kilometerstand, fuellstandInLiter, verbrauch);
            double streckeInKilometern = 100;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(24.3, a.FuellstandInLiter);
        }
        [TestMethod]
        public void Fahren_MitZuWenigFuellstand()
        {
            //Arrange
            double kilometerstand = 0;
            double fuellstandInLiter = 10;
            double verbrauch = 5.7;
            Auto a = new Auto(kilometerstand, fuellstandInLiter, verbrauch);
            double streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreNotEqual(kilometerstand, a.Kilometerstand);

            //Wird aufgrund des nächsten Tests auf diesen Wert gesetzt
            //Würde man den else-Block weg lassen,
            //würde der Wert auf dem Standartwert bleiben
        }
        [TestMethod]
        public void Fahren_KannNurSoVielWieDieFuellmengeHergibt()
        {
            //Arrange
            double kilometerstand = 0;
            double fuellstandInLiter = 10;
            double verbrauch = 10;
            Auto a = new Auto(kilometerstand, fuellstandInLiter, verbrauch);
            double streckeInKilometern = 400;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(fuellstandInLiter/verbrauch*100, a.Kilometerstand);
        }
    }
}
