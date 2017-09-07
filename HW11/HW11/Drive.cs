using System;
using System.Threading;
using static System.Console;

namespace HW11
{
    public class Drive
    {
        private Car[] cars;

        public delegate void Ready();
        public delegate void Steady();
        public Steady steady;
        public Ready ready;
        private int distance;
        private bool finish;
        public Drive()
        {
            finish = false;
            distance = 100;
            cars = new Car[] { new Sportcar(distance,new Car.Finish(Finish),this ), new Bus(distance, new Car.Finish(Finish),this),
                new Passengercar(distance,new Car.Finish(Finish),this), new Truck(distance,new Car.Finish(Finish),this) };
        }
        public void Go()
        {
            ready();
            WriteLine("Start!");
            Thread.Sleep(1000);
            Clear();
            WriteLine("Attention!");
            Thread.Sleep(1000);
            Clear();
            WriteLine("March!");
            Thread.Sleep(1000);
            Clear();
            steady();
            while (!finish)
            {
                Clear();
                WriteLine("Sports car drove through: "+ cars[0].Ride);
                WriteLine("Bus drove: " + cars[1].Ride);
                WriteLine("Car drove through: " + cars[2].Ride);
                WriteLine("truck drove throughл: " + cars[3].Ride);
                foreach (Car car in cars)
                {
                    car.Go();
                }
                Thread.Sleep(1000);
            }
        }
        private void Finish(Car car)
        {
            finish = true;
            Clear();
            if(car is Truck)
            {
                WriteLine("The truck won!");
            }
            else if(car is Passengercar)
            {
                WriteLine("The car won!");
            }
            else if (car is Bus)
            {
                WriteLine("The bus won!");
            }
            else if (car is Sportcar)
            {
                WriteLine("The sportcar won!");
            }
        }
    }
}
