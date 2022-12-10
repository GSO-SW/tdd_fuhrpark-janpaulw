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
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Kilometerstand_SollNichtVerändertWerdenBeiNegativemWert()
        {
            //Arragne
            int kilometerstand = 10;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = -10;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(kilometerstand, a.Kilometerstand);
        }
        [TestMethod]
        public void Verbrauch_KannBerechnetWerden()
        {
            //Arrange
            int kilometerstand = 10;
            double fuellstandInLiter = 30;
            double verbrauch = 5.7;
            Auto a = new Auto(kilometerstand, fuellstandInLiter, verbrauch);
            int streckeInKilometern = 100;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(24.3, a.FuellstandInLiter);
        }
        [TestMethod]
        public void Fahren_MitZuWenigFuellstand()
        {
            //Arrange
            int kilometerstand = 10;
            double fuellstandInLiter = 10;
            double verbrauch = 5.7;
            Auto a = new Auto(kilometerstand, fuellstandInLiter, verbrauch);
            int streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(10, a.Kilometerstand);
        }
    }
}
