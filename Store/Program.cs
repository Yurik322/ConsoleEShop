using System;
using Store.Data;
using Microsoft.Extensions.DependencyInjection;
using Store.Core;
using Store.Core.ApplicationService;
using Store.Core.ApplicationService.Implementations;
using Store.Data.Repositories;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticDb.InitData();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IDataRepository, DataRepository>();
            serviceCollection.AddScoped<IDataService, DataService>();
            serviceCollection.AddScoped<IPrinter, Printer>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.ShowMenu();
            Console.ReadLine();
        }
	}
}
