////TASK 1


//using static Abstract_class__Abstract_method__Virtual_methods__Override__Sealed.Car;

//namespace Abstract_class__Abstract_method__Virtual_methods__Override__Sealed
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            DateTime now = DateTime.Now;
//            Vehicle[] vehicles = new Vehicle[]
//        {
//            new Car("Toyota", "Prius", "Blue", 2, 200, now, 4, false),
//            new Car("Tesla", "Model 3", "Red", 3, 250, now, 4, true),
//            new Bicycle("Giant", "Defy Advanced", "Black", 2, 30, now, "Road Bike")

//        };
//            Car car = new Car("Lada", "07", "Black", 20, 300, now, 4, false);
//            AddVehicle(ref vehicles, car);

//            foreach (var vehicle in vehicles)
//            {
//                Console.WriteLine("Vehicle Information:");
//                vehicle.GetInfo();
//                vehicle.DefineNatureHarmness();
//                Console.WriteLine($"Average Speed: {vehicle.AverageSpeed():F2} km/h");
//                Console.WriteLine($"Vehicle Type: {vehicle.GetType().Name}\n");
//            }
//        }
//        public static void AddVehicle(ref Vehicle[] vehicles, Vehicle vehicle)
//        {
//            Array.Resize(ref vehicles, vehicles.Length + 1);
//            vehicles[vehicles.Length - 1] = vehicle;
//        }
//    }

//    public abstract class Vehicle
//    {
//        private DateTime productionDate;

//        public string FactoryName { get; set; }
//        public string Model { get; set; }

//        public string Color { get; set; }
//        public int DriveTime { get; set; }

//        public int DrivePath { get; set; }

//        public DateTime ProductionDate { get; }



//        protected Vehicle(string factoryName, string model, string color, int driveTime, int drivePath, DateTime productionDate)
//        {
//            FactoryName = factoryName;
//            Model = model;
//            Color = color;
//            DriveTime = driveTime;
//            DrivePath = drivePath;
//            ProductionDate = productionDate;
//        }

//        public abstract void DefineNatureHarmness();

//        public int AverageSpeed()
//        {
//            return DrivePath / DriveTime;
//        }

//        public virtual void GetInfo()
//        {
//            Console.WriteLine($"Factory: {FactoryName}");
//            Console.WriteLine($"Model: {Model}");
//            Console.WriteLine($"Color: {Color}");
//            Console.WriteLine($"Drive Time: {DriveTime} hours");
//            Console.WriteLine("Drive Path: {DrivePath} km");
//            Console.WriteLine($"Production Date: {ProductionDate}");

//        }

//        public override string ToString()
//        {
//            return ($"{FactoryName} and {Model}");
//        }

//    }

//    public class Car : Vehicle
//    {

//        public int DoorCount { get; set; }
//        public bool IsElectricCar { get; set; }

//        public Car(string factoryName, string model, string color, int driveTime, int drivePath, DateTime productionDate, int doorCount, bool isElectricCar)
//            : base(factoryName, model, color, driveTime, drivePath, productionDate)
//        {
//            DoorCount = doorCount;
//            IsElectricCar = isElectricCar;
//        }

//        public override void DefineNatureHarmness()
//        {
//            if (IsElectricCar)
//            {
//                Console.WriteLine("Harmness: Low ElectricCar");
//            }

//            else
//            {
//                Console.WriteLine("Harmness: High Car with Oil");
//            }

//        }

//        public class Bicycle : Vehicle
//        {
//            public string Type { get; set; }

//            public Bicycle(string factoryName, string model, string color, int driveTime, int drivePath, DateTime productionDate, string type)
//                : base(factoryName, model, color, driveTime, drivePath, productionDate)
//            {
//                Type = type;
//            }

//            public override void DefineNatureHarmness()
//            {
//                Console.WriteLine("Harmness: None Bicycle");
//            }
//        }


//    }
//}