using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Practica3.Data;
using Practica3.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("NorthwindConnectionString");

            ServiceCollection services = new ServiceCollection();
            services.AddScoped<Menu>();
            services.AddScoped<Productos>();
            services.AddScoped<Categorias>();
            services.AddScoped<Suplidores>();
            services.AddScoped<Ordenes>();
            services.AddScoped<OrdenesDetalles>();
            //services.AddScoped<IValidator<Products>, ProductsValidator>();
            services.AddValidatorsFromAssemblyContaining(typeof(Menu));
            services.AddSingleton(configuration);
            services.AddSingleton<ISqlConnectionFactory>(new SqlServerConnectionFactory(connectionString));
            services.AddDbContext<NorthwindContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            //IConfiguration configuration = new ConfigurationBuilder();
            

            try
            {
                var serviceProvider = services.BuildServiceProvider();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mainForm = serviceProvider.GetService<Menu>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            finally
            {
                Log.CloseAndFlush();
            }

            
        }
    }
}
