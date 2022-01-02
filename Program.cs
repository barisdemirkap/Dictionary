using System;
using System.Collections.Generic ;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collections.generic
            Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(10, "bilbo baggins");
            users.Add(12, "Aragorn son of arathorn");
            users.Add(18, "gandalf the grey");
            users.Add(20, "faramir");
            // Dizinin elemanlarina erisim
            Console.WriteLine("***** elemanlara erisim****") ;
            Console.WriteLine(users[12]) ;

            foreach (var item in users)
                Console.WriteLine(item) ;

        }
    }
}