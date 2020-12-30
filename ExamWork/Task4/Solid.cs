using System;
using System.Collections.Generic;
using System.Text;

namespace ExamWork.Task4
{
    public abstract class Car {
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
    }

    public class PassengerCars : Car, IPassengerCar
    {
        public void Drive()
        {
            Console.WriteLine("I drive light car");
        }

        public void Repair()
        {
            Console.WriteLine("I repair light car");
        }
    }

    public class Minivan : PassengerCars {}
    
    public class Suv : PassengerCars {}

    public class Sedan : PassengerCars {}

    public class Freight : Car, IFreightCar
    {
        public void Drive()
        {
            Console.WriteLine("I drive Freight");
        }

        public void Repair()
        {
            Console.WriteLine("I repair Freight");
        }
    }

    public class Buses : Car, IBusesCar
    {
        public void Drive()
        {
            Console.WriteLine("I drive buses");
        }

        public void Repair()
        {
            Console.WriteLine("I repair bus");
        }
    }

    public interface IPassengerCar
    {
        public void Drive();
        public void Repair();
    }

    public interface IFreightCar
    {
        public void Drive();
        public void Repair();
    }

    public interface IBusesCar
    {
        public void Drive();
        public void Repair();
    }

}
