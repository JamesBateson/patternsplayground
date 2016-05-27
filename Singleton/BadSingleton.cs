namespace Singleton.Bad
{
    public class BadSingleton
    {
        //Singletons widely critisized for:
        //Not being thread safe
        //Hard to unit test properly

        private class Singleton
        {
            //TIP: Any time you see a static variable that isn't readonly you should see it as a red flag for thread safety
            private static Singleton instance;

            private Singleton()
            {
                
            }

            public static Singleton Instance
            {
                get
                {
                    //One criticism of singletons is that they are not thread safe.
                    //Two threads could get past "instance == null" and create an instance
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        } 
    }
}