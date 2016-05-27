namespace Singleton
{
    using System;

    public class MediumSingleton
    {
        public class Singleton
        {
            private static readonly object mutex = new Object();
            private static Singleton instance;

            private Singleton()
            {
                
            }

            public static Singleton Instance
            {
                get
                {
                    //This is using "double check" locking by testing for instance == null before entering lock.  Don't need to worry about locking if an instance already exists
                    //Technically this isn't really thread safe because of "memory barriers"

                    if (instance == null)
                    {
                        lock (mutex)
                        {
                            if (instance == null)
                            {
                                instance = new Singleton();
                            }

                        }
                    }
                    return instance;    
                }
            }
        } 
    }
}