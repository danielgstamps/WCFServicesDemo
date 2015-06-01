using System;
using System.ServiceModel;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderServiceHost
{
    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(ClassFinderService.ClassFinderService));
            host.Open();
            Console.WriteLine("ClassFinderService hosted with these endpoints:");
            foreach (var current in host.Description.Endpoints)
            {
                Console.WriteLine(current.Address.ToString());
            }
            Console.ReadLine();
            host.Close();
        }
    }
}