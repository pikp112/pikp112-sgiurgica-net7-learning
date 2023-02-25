using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WhiteDentalClinic.Application.MappingProfiles;
using WhiteDentalClinic.Application.Services;
using WhiteDentalClinic.DataAccess;
using WhiteDentalClinic.DataAccess.Repositories.CustomerRepository;
using WhiteDentalClinic.DataAccess.Repositories.DentistRepository;
using WhiteDentalClinic.Shared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add dependecy injection
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped<IDentistService,DentistService>();
builder.Services.AddScoped<IDentistRepository, DentistRepository>();

//builder.Services.AddTransient<IClaimService, ClaimService>();   // need to be deleted?

builder.Services.AddAutoMapper(typeof(CustomerProfile));
builder.Services.AddAutoMapper(typeof(DentistProfile));


builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

// Add db connection
builder.Services.AddDbContext<ApiDbTempContext>(options =>
{
    options.UseInMemoryDatabase("TempDb");
});

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
