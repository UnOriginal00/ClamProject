using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using ClamBackend.Data;
using ClamBackend.Services;
using ClamBackend.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//Add db context service.
builder.Services.AddDbContext<ClamDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ITeamService,TeamService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Jwt
string jwtSecret = builder.Configuration["JwtSettings:Secret"];
string jwtIssuer = builder.Configuration["JwtSettings:Issuer"];

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
