using System;

namespace HW11
{
    public class Truck : Car
    {
        public Truck(int distance, Finish finish, Drive race) : base(distance, 7, finish, race) { }
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