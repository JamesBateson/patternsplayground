using System;

namespace Visitor.DoubleDispatch
{
    public class Asteroid
    {
        public virtual void CollideWith(SpaceShip ship)
        {
            Console.WriteLine("Asteroid hit a spaceship");
        }

        public virtual void CollideWith(SpaceShuttle shuttle)
        {
            Console.WriteLine("Asteroid hit a space shuttle");
        }
    }

    public class MassiveAsteroid : Asteroid
    {
        public override void CollideWith(SpaceShip ship)
        {
            Console.WriteLine("Massive asteroid hit a spaceship");
        }

        public override void CollideWith(SpaceShuttle shuttle)
        {
            Console.WriteLine("Massive asteroid hit a space shuttle");
        }
    }
}