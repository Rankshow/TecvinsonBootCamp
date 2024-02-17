
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TecvinsonBootCamp.Core.Interfaces;
using TecvinsonBootCamp.Respositories.Data;
using TecvinsonBootCamp.Respositories.Implementation;
using TecvinsonBootCamp.Services.Contract;
using TecvinsonBootCamp.Services.Implementation;
using TecvinsonBootCamp.Services.Interfaces;
using TecvinsonBootCamp.Services.Validation;

namespace TecvinsonBootCamp.Presentatio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<TecvinsonDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            // Add services to the container.
            builder.Services.AddScoped<ICohortService, CohortService>();
            builder.Services.AddScoped<ICohortRepositories, CohortRepositories>();
            builder.Services.AddScoped<IValidator<CohortCreateReq>, CohortCreateReqValidation>();

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

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
