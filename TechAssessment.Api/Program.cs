using TechAssessment.Core.Entities;
using TechAssessment.Repositories;
using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services;
using TechAssessment.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

// Add repository and service dependencies
builder.Services.AddScoped<ICalendarService, CalendarService>();
builder.Services.AddScoped<IEnitityService<Attendee>, AttendeeService>();
builder.Services.AddScoped<IEnitityService<Event>, EventService>();
builder.Services.AddScoped<ICalendarRepository, CalendarRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
