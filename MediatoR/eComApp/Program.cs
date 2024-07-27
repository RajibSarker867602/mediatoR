using DemoLibrary;
using DemoLibrary.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// adding mediatoR
builder.Services.AddSingleton<IDataAccess, DemoDataAccess>();
//builder.Services.AddMediatR(typeof(DemoLibraryMediatorEntryPoint).Assembly);
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DemoLibraryMediatorEntryPoint).Assembly));

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
