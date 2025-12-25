using ISI_TP2;
using ISI_TP2.Data;
using ISI_TP2.Model;
using ISI_TP2.Services;
using Microsoft.EntityFrameworkCore;
using System;
using static ISI_TP2.Model.LegalFirmContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.
builder.Services.AddDbContext<LegalFirmContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-C0ESI4J;Database=LegalFirmDB;Trusted_Connection=True;TrustServerCertificate=True;");
});

builder.Services.AddScoped<AdvogadoService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<LegalFirmContext>();

    DbSeeder.Seed(context);
}

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
