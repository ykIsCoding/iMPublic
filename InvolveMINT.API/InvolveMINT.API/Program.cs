using InvolveMINT.API.Infrastructure.Data;
using Serilog;
using Microsoft.EntityFrameworkCore;
using Ardalis.ListStartupServices;
using InvolveMINT.API.SharedKernel;
using InvolveMINT.API.Core;
using InvolveMINT.API.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Configuration
//   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//   .AddJsonFile("appsettings.{env.Environment}.json", optional: true, reloadOnChange: true)
//   .AddEnvironmentVariables();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));

builder.Services.Configure<CookiePolicyOptions>(options =>
{
  options.CheckConsentNeeded = context => true;
  options.MinimumSameSitePolicy = SameSiteMode.None;
});

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
          options.UseNpgsql(connectionString));

// add list services for diagnostic purposes - see https://github.com/ardalis/AspNetCoreStartupServices
builder.Services.Configure<ServiceConfig>(config =>
{
  config.Services = new List<ServiceDescriptor>(builder.Services);

  // optional - default path to view services is /listallservices - recommended to choose your own path
  config.Path = "/listservices";
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IEnrollInProjectService, EnrollInProjectService>();
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

