using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalCar = new NormalCar();
            var sportsCar = new SportsCar(normalCar);
            var deliveryCar = new DeliveryCar(sportsCar);
            var flyingCar = new FlyingCar(deliveryCar);
            flyingCar.Drive();

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
            Console.Write("Car is ");
        }
    }

    public class NormalCar:VirtualCar
    {
        public override void Drive()
        {
            Console.Write("Normal Car ");
        }  
    }

    public abstract class VirtualCar
    {
        public virtual void Drive()
        {
        }
    }

}
