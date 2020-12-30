using System;
using System.Collections.Generic;
using System.Text;

namespace ExamWork.Task2
{
    public abstract class WashBox
    {
        public int BoxNumber { get; set; }
        public string Washer { get; set; }
    }

    public interface ICarWashStrategy
    {
        void WashCar();
    }

    //Passenger - Легковой
    public class PassengerCar : WashBox, ICarWashStrategy
    {
        public void WashCar()
        {
            Console.WriteLine("I wash only Small car");
        }
    }
    
    //Suv - Джип
    public class SuvCar : ICarWashStrategy
    {
        public void WashCar()
        {
            Console.WriteLine("I wash small car and big car");
        }
    }

    public class CarStrategy

    {
        public ICarWashStrategy ContextStrategy { get; set; }

        public CarStrategy(ICarWashStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void Wash()
        {
            ContextStrategy.WashCar();
        }
    }
}
