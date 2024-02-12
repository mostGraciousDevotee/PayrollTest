static class Assert
{
    public static bool AreNotNull<T>(T? obj, string message)
    {
        if (obj != null)
        {
            return true;
        }
        else
        {
            Console.WriteLine(message);
            return false;
        }
    }

    public static bool AreEqual<T>(T expected, T result, string message) where T : IEquatable<T>
    {
        if (expected.Equals(result))
        {
            return true;
        }
        else
        {
            Console.WriteLine(message);
            return false;
        }
    }
}