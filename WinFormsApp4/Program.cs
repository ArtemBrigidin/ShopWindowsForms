using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<InputWindow>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            string connectionString = @"Data Source={DATA BASE};Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IUserRepository, UserRepository>(provider => new UserRepository(connectionString));
                    services.AddTransient<IShopRepository, ShopRepository>(provider => new ShopRepository(connectionString));
                    services.AddTransient<IProductRepository, ProductRepository>(provider => new ProductRepository(connectionString));
                    services.AddTransient<InputWindow>();
                    services.AddTransient<RegistrationForm>();
                    services.AddTransient<AuthorizeForm>();
                    services.AddTransient<MainWindow>();
                });
        }
    }
}