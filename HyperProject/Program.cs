using HyperProject.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICarRepository, InMemoryCarRepository>();
builder.Services.AddScoped<IBusRepository, InMemoryBusRepository>();
builder.Services.AddScoped<IBoatRepository, InMemoryBoatRepository>();


builder.Services.AddScoped<ICarRepository, SQLCarRepository>();
builder.Services.AddScoped<IBusRepository, SQLBusRepository>();
builder.Services.AddScoped<IBoatRepository, SQLBoatRepository>();




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VehicleDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDatabase")));
    builder.Services.AddAutoMapper(typeof(MappingProfile));

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
