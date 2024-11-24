public sealed class SimpleSingleton3
{
    private static readonly SimpleSingleton3 instace = new SimpleSingleton3();

    // Private constructor ensures that an object is not instantiated from outside the class
    private SimpleSingleton3()
    {

    }

    // Public static property to get the single instace of the class
    public static SimpleSingleton3 Instance
    {
        get
        {
            return instace;
        }
    }
}
