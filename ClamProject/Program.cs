using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ClamProject.Data;
using ClamProject.Services;
using ClamProject.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//Add db context service
builder.Services.AddDbContext<ClamDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
