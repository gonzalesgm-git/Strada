using FluentValidation.AspNetCore;
using Strada.API;
using Strada.Application;
using Strada.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddItemApplicationMediatR();
builder.Services.AddPersistence();
builder.Services.AddRepositories();
builder.Services.AddValidators();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.BuildMvc();

var app = builder.Build();
app.Services.InitializeDatabase();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
