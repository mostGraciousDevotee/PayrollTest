static class Assert
{
    public static bool IsNotNull<T>(T? obj, string message)
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

    public static bool IsNull<T>(T? obj, string message)
    {
        if (obj == null)
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

    public static bool AreEqual(double expected, double result, double tolerance, string message)
    {
        if (Math.Abs(expected - result) <= tolerance)
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