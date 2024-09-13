using VueSchool_Test_DataAccessLayer.Providers.Implement;
using VueSchool_Test_DataAccessLayer.Providers.Interface;
using VueSchool_Test_BusinessLayer.Services.Implement;
using VueSchool_Test_BusinessLayer.Services.Interface;
using NLog;
using NLog.Web;

namespace VueSchool_Test_API_sln
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            logger.Debug("init main");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.

                builder.Services.AddControllers();

                // NLog: Setup NLog for Dependency injection
                builder.Logging.ClearProviders();
                builder.Host.UseNLog();

                //CORS
                var allowCors = "allowCors";
                builder.Services.AddCors(opt =>
                {
                    opt.AddPolicy(allowCors, policy =>
                    {
                        policy.WithOrigins("*").WithHeaders("*").WithMethods("*");
                    });
                });

                // ConnectionString Provider
                var connectionString = builder.Configuration.GetConnectionString("VueSchool");

                builder.Services.AddSingleton(new DataBaseSetting_Provider(connectionString));

                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                // Add Provider Interface DI
                builder.Services.AddScoped<IVusSchool_Rootobject_Provider, VusSchool_Rootobject_Provider>();
                builder.Services.AddScoped<IVusSchool_Experience_Provider, VusSchool_Experience_Provider>();
                builder.Services.AddScoped<IVusSchool_Data_Service, VusSchool_Data_Service>();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                // CORS
                app.UseCors("allowCors");

                app.UseHttpsRedirection();

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {

                // NLog: catch setup errors
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }

        }
    }
}
