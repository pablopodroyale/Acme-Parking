namespace AcmeParking.Models
{
    public class Parking
    {
        public ParkingLot ParkingLot { get; set; }


        public Parking(int height,int width)
        {
            ParkingLot = new ParkingLot(height, width, new SearchStrategyFactory());
        }

        public void SetCar(Car car) 
        {
            ParkingLot.SetCar(car);
        }

        public Car GetCar(SearchType searchType, SearchDTO search) 
        {
            Car car = ParkingLot.GetCar(searchType, search);
            return car;
        }
    }
}
