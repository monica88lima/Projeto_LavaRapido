using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Context;
using Repository.Interface;
using Service;
using Service.DTOs;
using Service.Interface;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers().AddJsonOptions(options =>
                                                 options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
                                             options.UseMySql(mySqlConnection,
                                             ServerVersion.AutoDetect(mySqlConnection)));
builder.Services.AddAutoMapper(typeof(DtoMappingProfile));
builder.Services.AddScoped<IClienteRespository, ClienteRepository>();
builder.Services.AddScoped<IPistaLavagemRepository,PistaLavagemRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IClienteService,ClienteService>();
builder.Services.AddScoped<IPistaLavagem, VerificarPistaLavagem>();
builder.Services.AddScoped<ILogin, Login>();

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
