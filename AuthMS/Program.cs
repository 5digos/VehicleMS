using Application.Dtos.Request;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.ITransmissionTypeServices;
using Application.Interfaces.IServices.IVehicleCategoryServices;
using Application.Interfaces.IServices.IVehicleServices;
using Application.Interfaces.IServices.IVehicleStatusServices;
using Application.Interfaces.IValidators;
using Application.UseCase.TransmissionTypeServices;
using Application.UseCase.VehicleCategoryServices;
using Application.UseCase.VehicleServices;
using Application.UseCase.VehicleStatusServices;
using Application.Validators;
using FluentValidation;
using Infrastructure.Persistence;
using Infrastructure.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#if DEBUG
builder.Configuration.AddUserSecrets<Program>();
#endif

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "VehicleMS", Version = "1.0" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});


// Custom            
var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//Services
builder.Services.AddScoped<IVehicleGetServices, VehicleGetServices>();
builder.Services.AddScoped<IVehicleStatusGetServices, VehicleStatusGetServices>();
builder.Services.AddScoped<ITransmissionTypeGetServices, TransmissionTypeGetServices>();
builder.Services.AddScoped<IVehicleCategoryGetServices, VehicleCategoryGetServices>();


//Validators
builder.Services.AddValidatorsFromAssemblyContaining<GetVehiclesRequestValidator>();
builder.Services.AddScoped<IValidatorHandler<GetVehiclesRequest>, ValidatorHandler<GetVehiclesRequest>>();

//CQRS
builder.Services.AddScoped<IVehicleQuery, VehicleQuery>();
builder.Services.AddScoped<IVehicleStatusQuery, VehicleStatusQuery>();
builder.Services.AddScoped<ITransmissionTypeQuery, TransmissionTypeQuery>();
builder.Services.AddScoped<IVehicleCategoryQuery, VehicleCategoryQuery>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();


app.Use(async (context, next) =>
{
    // Continúa con la solicitud
    await next();

    // Si el estado de la respuesta es 401 (No autorizado), añade los encabezados CORS
    if (context.Response.StatusCode == 401)
    {
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
        context.Response.Headers.Add("Access-Control-Allow-Headers", "Authorization, Content-Type");

    }
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthentication();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();
