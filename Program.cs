using System;

namespace TestEnvKeyVault
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySecret = Environment.GetEnvironmentVariable("MySecret");
            if(mySecret == "IHave3Cats")
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
