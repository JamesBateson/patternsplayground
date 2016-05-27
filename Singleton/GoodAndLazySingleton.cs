namespace Singleton.Bad
{
    using System;

    public class GoodAndLazySingleton
    {
        public class Singleton
        {
            //Let .NET framework deal with all the locking, mutex etc.
            //Only one thread can be in a static initializer and CLR makes sure it's efficient
            //Might use something similar to double-check locking but it will get it right!
            private static readonly Singleton instance = new Singleton();

            //Empty static constructor - forces laziness
            //Will only initialize before it is first used
            static Singleton() {}

            private Singleton()
            {
                
            }

            public static Singleton Instance => instance;
        } 

        public class PsychoticLazySingleton
        {
            private static class SingletonHolder
            {
                internal static readonly PsychoticLazySingleton instance = new PsychoticLazySingleton();    
                static SingletonHolder() {}
            }
            
            private PsychoticLazySingleton()
            {
                
            }

            //Type will be initialized immediately before first use
            //Calling SayHi will call the static constructor which will kick off the instance variable, which calls the regular constructor.
            //So you can make a private nested class to fix this! SayHi will just run without instantiating a PsychoticLazySingleton
            //Only when Instance is requested will there be any instantiantiation of PsychoticLazySingleton
            public static void SayHi()
            {
                Console.WriteLine("Hi");
            }

            public static PsychoticLazySingleton Instance => SingletonHolder.instance;
        } 
    }
}