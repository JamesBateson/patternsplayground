namespace Singleton.Bad
{
    using System;

    public class LazyTSingletonS
    {
        public class Singleton
        {
            private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton(), true);

            private Singleton()
            {
                
            }

            public static Singleton Instance => lazyInstance.Value;
        } 
    }
}