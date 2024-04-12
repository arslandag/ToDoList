using Microsoft.EntityFrameworkCore;
using ToDoList.Application.Interfaces;
using ToDoList.Application.Servicies;
using ToDoList.Persistence;
using ToDoList.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ToDoListDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(ToDoListDbContext)));
});

builder.Services.AddScoped<ITargetRepository, TargetRepository>();
builder.Services.AddScoped<ITargetsService, TargetsService>();

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
