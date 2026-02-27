using System;

namespace InheritanceExample
{

    public class Car
    {
        public int CarId { get; set; }
        public string CaraName { get; set; }

        public Car(int id,string name)
        {
            CarId = id;
            CaraName = name;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Carid :{CarId},  Carname:{CaraName}");
        }
    }
    public class NewCar:Car
    {
        public double CarAge { get; set; }

        public NewCar(int id, string name, double age):base(id,name)
        {
            CarAge = age;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Car id:{CarId}, CarName:{CaraName}, Car age :{CarAge}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewCar newCar = new NewCar(1,"Swift",0.1);
            newCar.ShowDetails();
        }
    }
}
