using Microsoft.EntityFrameworkCore;
using TechAssessment.Core.Entities;
using TechAssessment.Repositories;
using TechAssessment.Repositories.DbContexts;
using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services;
using TechAssessment.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CalendarDbContext>(options =>
    options.UseInMemoryDatabase("CalendarDb"));

// Add repository and service dependencies
builder.Services.AddScoped<ICalendarService, CalendarService>();
builder.Services.AddScoped<ICalendarEntityService<Attendee>, AttendeeService>();
builder.Services.AddScoped<ICalendarEntityService<CalendarEvent>, CalendarEventService>();

builder.Services.AddScoped<ICalendarEntityRepository<Attendee>, AttendeeRepository>();
builder.Services.AddScoped<ICalendarEntityRepository<CalendarEvent>, CalendarEventRepository>();

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
