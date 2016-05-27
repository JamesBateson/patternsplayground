namespace Singleton.Bad
{
    using System;

    public class GoodButEagerSingleton
    {
        //Can use this most of the time if you don't care whether Singleton constructor is called lazily or not.

        public class Singleton
        {
            //Let .NET framework deal with all the locking, mutex etc.
            //Only one thread can be in a static initializer and CLR makes sure it's efficient
            //Might use something similar to double-check locking but it will get it right!
            private static readonly Singleton instance = new Singleton();

            private Singleton()
            {
                
            }

            public static Singleton Instance => instance;
        } 
    }
}