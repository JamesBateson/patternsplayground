using NUnit.Framework;

namespace Visitor.DoubleDispatch
{
    public class DoubleDispatch
    {
        public static void RunDoubleDispatchCode()
        {
            var asteroid = new Asteroid();
            var massiveAsteroid = new MassiveAsteroid();
            var spaceship = new SpaceShip();
            var shuttle = new SpaceShuttle();

            //Outputs: Asteroid hit a spaceship - as expected
            asteroid.CollideWith(spaceship);

            //Outputs: Asteroid hit a space shuttle - as expected
            asteroid.CollideWith(shuttle);

            //Outputs: Massive asteroid hit a spaceship - as expected
            massiveAsteroid.CollideWith(spaceship);

            //Outputs: Massive asteroid hit a space shuttle - as expected
            massiveAsteroid.CollideWith(shuttle);

            //Outputs: Massive asteroid hit a SPACESHIP - expected space shuttle
            //Problem is that the method is chosen only based on massiveAsteroid2
            //Not the massiveAsteroid2 AND shuttle2
            Asteroid massiveAsteroid2 = new MassiveAsteroid();
            SpaceShip shuttle2 = new SpaceShuttle();
            massiveAsteroid2.CollideWith(shuttle2);

            //TRY WITH THE ASSETS
        } 
    }
}