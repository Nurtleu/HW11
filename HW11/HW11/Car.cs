using System;


namespace HW11
{
    public abstract class Car
    {
        public delegate void Finish(Car car);
        protected Finish finish;
        public int Ride { get; protected set; }
        protected int distance;
        protected int maxSpeed;
        public int Speed { get; set; }
        public Car(int distance, int maxSpeed, Finish finish, Drive drive)
        {
            Ride = 0;
            this.distance = distance;
            this.maxSpeed = maxSpeed;
            this.finish = finish;
            drive.ready += IsReady;
            drive.steady += Steady;
        }

        public abstract void IsReady();
        public abstract void Steady();
        public abstract void Go();
    }
}
