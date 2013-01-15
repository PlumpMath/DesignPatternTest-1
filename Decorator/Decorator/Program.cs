using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            new FlyingCar(new DeliveryCar(new SportsCar(new NormalCar()))).Drive();

            Console.ReadKey();
        }
    }

    public class FlyingCar : DecorateCar
    {
        public FlyingCar(VirtualCar car)
            : base(car)
        {
        }

        public override void Drive()
        {
            Car.Drive();
            Console.WriteLine("Flying...");
        }
    }

    public class SportsCar : DecorateCar
    {
        public SportsCar(VirtualCar car) : base(car)
        {
        }

        public override void Drive()
        {
            Car.Drive();
            Console.WriteLine("Sporting...");
        }
    }

    public class DeliveryCar : DecorateCar
    {
        public DeliveryCar(VirtualCar car)
            : base(car)
        {
        }

        public override void Drive()
        {
            Car.Drive();
            Console.WriteLine("Delivering...");
        }
    }

    public class DecorateCar:VirtualCar
    {
        public DecorateCar(VirtualCar car)
        {
            Car = car;
        }
        public VirtualCar Car { get; set; }

        public override void Drive()
        {
        }
    }

    public class NormalCar:VirtualCar
    {
        public override void Drive()
        {
            Console.WriteLine("Normal Car ");
        }  
    }

    public abstract class VirtualCar
    {
        public virtual void Drive()
        {
        }
    }

}
