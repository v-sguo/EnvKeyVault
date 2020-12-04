using System;

namespace TestEnvKeyVault
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySecret = Environment.GetEnvironmentVariable("cvatPassword");
            Console.WriteLine($"This is mySecret: {mySecret}");
            if(mySecret == "Admin200812!")
            {
                Console.WriteLine("Correct Environment Variable");
            }
            else
            {
                Console.WriteLine("Wrong Environment Variable");
            }
        }
    }
}
