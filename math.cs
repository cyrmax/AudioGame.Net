using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AudioGame;

public static class Math
{
    private static Random rnd = new Random();

    public static double absolute(double x)
    {
        return System.Math.Abs(x);
    }

    public static double arc_cosine(double x)
    {
        if (x < -1 | x > 1)
        {
            return 0;
        }
        return System.Math.Acos(x);
    }

    public static double arc_sine(double x)
    {
        if (x < 1 | x > 1)
        {
            return 0;
        }
        return System.Math.Asin(x);
    }

    public static double arc_tangent(double x)
    {
        return System.Math.Atan(x);
    }

    public static double ceiling(double x)
    {
        return System.Math.Ceiling(x);
    }

    public static double cosine(double x)
    {
        return System.Math.Cos(x);
    }

    public static double exponent(double x)
    {
        return System.Math.Exp(x);
    }

    public static double floor(double x)
    {
        return System.Math.Floor(x);
    }

    public static double log(double x)
    {
        return System.Math.Log(x);
    }

    public static double log10(double x)
    {
        return System.Math.Log10(x);
    }

    public static double power(double x, double y)
    {
        return System.Math.Pow(x, y);
    }

    public static long random(long min, long max)
    {
        byte[] buf = new byte[8];
        rnd.NextBytes(buf);
        long longRand = BitConverter.ToInt64(buf, 0);
        return (System.Math.Abs(longRand % (max - min)) + min);
    }

    public static long random(int min, int max)
    {
        return rnd.Next(min, max);
    }

    public static string random_get_state()
    {
        return Serialization.serialize(rnd);
    }

    public static bool random_set_state(string state)
    {
        try
        {
            rnd = (Random)Serialization.deserialize_object(state);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static double round(double value, int decimal_places)
    {
        return System.Math.Round(value, decimal_places);
    }

    public static double sine(double X)
    {
        return System.Math.Sin(X);
    }

    public static double square_root(double value)
    {
        return System.Math.Sqrt(value);
    }

    public static double tangent(double x)
    {
        return System.Math.Tan(x);
    }

}