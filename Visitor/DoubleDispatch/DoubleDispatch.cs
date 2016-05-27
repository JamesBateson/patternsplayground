using System;
using System.Collections.Generic;
using NUnit.Framework;
using Visitor.Bad;

namespace Visitor.DoubleDispatch
{
    public class DoubleDispatch
    {
        public static void RunDoubleDispatchCodeAssets()
        {
            IAssetOperation netWorth = new NetWorth();
            IAsset bankAccount = new BankAccount();
            IAsset realEstate = new RealEstate();

            var assets = new List<IAsset>()
            {
                bankAccount,
                realEstate
                //etc.
            };

            var overallNetWorth = 0;
            foreach (IAsset asset in assets)
            {
                //I want to write the below but can't - Calculate() cannot resolve based on an IAsset, it needs a concrete IAsset to resolve the method
                //overallNetWorth += netWorth.Calculate(bankAccount);
            }
        }

        public static void RunDoubleDispatchCodeAsteroids()
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
        }
    }
}