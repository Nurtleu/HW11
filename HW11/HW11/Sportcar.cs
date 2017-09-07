using System;

namespace HW11
{
    public class SportCar : Car
    {
        public SportCar(int distance, Finish finish, Drive drive) : base(distance, 10, finish, drive) { }
        public override void Go()
        {
            Random random = new Random();
            Speed = random.Next(maxSpeed);
            Ride += Speed;
            if (Ride >= distance)
            {
                finish(this);
            }
        }
        public override void IsReady() { }
        public override void Steady() { }
    }
}