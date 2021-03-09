using System;

namespace opdrach1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] broers = { "Peter", "is", "de", "broer", "van", "Hans" };
            string[] broer = { "Hans", "is", "de", "broer", "van", "Peter" };
            foreach (string i in broers)
            {
                Console.WriteLine(i);
            }
            foreach (string i in broer)
            {
                Console.WriteLine(i);
            }
        }
    }
}


