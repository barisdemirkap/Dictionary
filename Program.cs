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
            
            //Count 

            Console.WriteLine(users.Count) ;

            //Contains
            Console.WriteLine("**** Contains *****");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("sam"));

            // Remove

            Console.WriteLine("******Remove****") ;
            users.Remove(12) ;
            foreach (var item in users)
                Console.WriteLine(item.Value) ;
            
            // Keys
            Console.WriteLine("*****Keys******") ;
            foreach (var item in users.Keys)
                Console.WriteLine(item) ;

            // Values
            Console.WriteLine("*****Values******") ;
            foreach (var item in users.Values)
                Console.WriteLine(item) ;
            

        }   
    }
}