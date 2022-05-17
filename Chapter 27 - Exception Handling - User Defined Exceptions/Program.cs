using System;

namespace UserDefinedException
{
    class TestTemperature
    {
        public static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            try
            {
                temperature.showTemp();
            }
            catch (TempIsZeroException e)
            {
                System.Console.WriteLine($"TempIsZeroException: {e.Message}");
            }
        }
    }
}

public class TempIsZeroException : ApplicationException
{
    public TempIsZeroException(string message) : base (message)
    {

    }
}

public class Temperature
{
    int temperature = 0;

    public void showTemp()
    {
        if (temperature == 0)
        {
            throw new TempIsZeroException("Zero Temperature Found!");
        }
        else 
        {
            System.Console.WriteLine($"Temperature : {temperature}");
        }
    }
}
// pg 212, 213