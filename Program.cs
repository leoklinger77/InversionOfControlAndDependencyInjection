using IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Startup startup = new Startup(new ServiceCollection());

var client = startup.ServiceProvider.GetService<ICliente>();

foreach (var item in client.GetAllOrder())
{
    Console.WriteLine($"Id: {item}");
};

internal class Startup
{
    public IConfigurationRoot Configuration;
    public IServiceProvider ServiceProvider;

    public Startup(IServiceCollection serviceCollection)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(Path.Combine($"appsettings.json"), false)
            .AddJsonFile(Path.Combine($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json"), false)
            .Build();

        ConfigureServices(serviceCollection);
        ServiceProvider = serviceCollection.BuildServiceProvider();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<ICliente, Cliente>();
        services.AddSingleton<IPedido, Pedido>();
    }
}