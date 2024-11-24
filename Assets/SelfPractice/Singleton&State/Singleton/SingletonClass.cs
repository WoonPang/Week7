public class SimpleSingleton2
{
    public static volatile SimpleSingleton2 instance = null;
    private static readonly object padlock = new object();

    public static SimpleSingleton2 Instace
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimpleSingleton2();
                    }
                }
            }
            return instance;
        }
    }
}
