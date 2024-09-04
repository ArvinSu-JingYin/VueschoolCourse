using VueSchool_Test_DataAccessLayer.Providers.Implement;
using VueSchool_Test_DataAccessLayer.Providers.Interface;
using VueSchool_Test_BusinessLayer.Services.Implement;
using VueSchool_Test_BusinessLayer.Services.Interface;


namespace VueSchool_Test_API_sln
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
