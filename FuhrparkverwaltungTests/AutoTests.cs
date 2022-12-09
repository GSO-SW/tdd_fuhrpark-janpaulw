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
    }
}
