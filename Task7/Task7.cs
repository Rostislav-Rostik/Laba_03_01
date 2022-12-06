using System.Transactions;
using System.Xml.Linq;
using System.Xml.Serialization;

internal class Program
{
    class Car
    {
        private string model;
        private double fuel_amount;
        private double fuel_rate;
        private double distance;

        public string Model { get; set; } 
        public double FuelAmount { get; set; }
        public string FuelRate { get; set; }
        public double Distance { get; set; }
        
        public Car (string model, double fuel_amount, double fuel_rate)
        {
            this.model = model;
            this.fuel_amount = fuel_amount;
            this.fuel_rate = fuel_rate;
            this.distance = 0;
        }

        public static bool Drive (Car car, double distance)
        {
            double kilometr = car.fuel_amount / car.fuel_rate;

            if (kilometr >= distance)
            {
                double l = distance * car.fuel_rate;
                car.FuelAmount -= l;
                car.distance += distance;
                return true;
            }

            return false;
        }

    }

    static void Main()
    {
        var car = new List<Car>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var list_car = Console.ReadLine().Split();
            var model = list_car[0];
            double fuelamount = double.Parse(list_car[1]);
            double fuelrate = double.Parse(list_car[2]);

            car.Add(new Car(model, fuelamount, fuelrate));
        }

        var temp = Console.ReadLine();

        while (temp != "End" || temp != "end")
        {
            var allComands = Console.ReadLine().Split();

            var model = allComands[1];
            double distance = double.Parse(allComands[2]);

            var tempmodel = car.FirstOrDefault(c => c.Model == model);

            if (!Car.Drive(tempmodel, distance))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            temp = Console.ReadLine();
        }

        foreach (var item in car)
        {
            Console.WriteLine(item.Model + item.FuelAmount + item.Distance);
        }
    }
}