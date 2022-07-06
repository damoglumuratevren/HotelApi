using Hotel.Data.Repositories.IRepo;
using Hotel.Data.Repositories.IRepo.IPersonelRp;
using Hotel.Data.Repositories.Repo;
using Hotel.Data.Repositories.Repo.PersonelRp;
using Hotel.Data.Services.IService;
using Hotel.Data.Services;
using Microsoft.EntityFrameworkCore;
using Hotel.Data.Services.IService.IPersonelSv;
using Hotel.Data.Services.PersonelSv;

namespace Hotel.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped(typeof(IService<>), typeof(Services<>));
            builder.Services.AddScoped<IPersonelTypeRepository, PersonelTypeRepository>();
            builder.Services.AddScoped<IPersonelTypeService, PersonelTypeService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


            // Add services to the container. 
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<Hotel.Data.ApplicationDbContext>(o =>o.UseSqlServer(connectionString));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}