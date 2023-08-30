using AcmeParking.Enum;
using AcmeParking.Models;
using AcmeParking.SearchStrategies;

namespace AcmeParkingTests
{
    public class Tests
    {
        private Parking UnderTest;

        [SetUp]
        public void Setup()
        {
            UnderTest = new Parking(2, 2);
        }

        [Test]
        public void GetCarByCode()
        {
            var car = new Car(200, "xyz");
            var car2 = new Car(200, "xyzu");
            UnderTest.SetCar(car);
            UnderTest.SetCar(car2);
            SearchDTO search = new SearchDTO()
            {
                RegistrationNumber = "xyz"
            };
            Car result = UnderTest.GetCar(SearchType.REGISTRATION_NUMBER, search);
            Assert.NotNull(result);
            Assert.That(result.RegistrationNumber, Is.EqualTo("xyz"));
        }

        [Test]
        public void GetCarByWeigth()
        {
            var car = new Car(200, "xyzu");
            var car2 = new Car(300, "xyz");

            UnderTest.SetCar(car);
            UnderTest.SetCar(car2);
            SearchDTO search = new SearchDTO()
            {
                Weight = 200
            };
            Car result = UnderTest.GetCar(SearchType.WEIGHT, search);
            Assert.NotNull(result);
            Assert.That(result.RegistrationNumber, Is.EqualTo("xyzu"));
        }
    }
}