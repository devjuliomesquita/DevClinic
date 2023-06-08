using Serilog;

namespace DevClinic.API.Configurations
{
    public static class LogSerilog_Config
    {
        public static void AddLogSerilogConfiguration(this IServiceCollection services)
        {
            string environmentDev = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentDev}.json")
                .Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            services.AddSerilog(logger);

            try
            {
                Log.Information("API iniciada.");
            }
            catch (Exception ex)
            {

                Log.Fatal(ex, "Erro Demoníaco.");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
