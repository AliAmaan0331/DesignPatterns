using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Parallel.Invoke(
                    () => CallEmployee(), 
                    ()=> CallClient()
                );                

                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });

        private static void CallEmployee()
        {
            Singleton employee = Singleton.GetInstance;
            employee.print("Employee here!!");
        }

        private static void CallClient()
        {
            Singleton Client = Singleton.GetInstance;
            Client.print("Client here!!");
        }
    }
}
