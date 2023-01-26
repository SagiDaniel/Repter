using RepterAPI.Infrastructure;

namespace RepterAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // DBContext behivása (dependency injection)
            builder.Services.AddDbContext<DBContext>();

            // A DBSeeder behivása
            builder.Services.AddScoped<DBSeeder>();

            var app = builder.Build();

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // Az indulás után a DBSeeder seedelõ eljárását hivom meg
            using (var scope = app.Services.CreateScope())
            {
                var seed = scope.ServiceProvider.GetRequiredService<DBSeeder>();
                seed.InitDatabase();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}