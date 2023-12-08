
using Microsoft.EntityFrameworkCore;
using Restarunt.common.DTOs.service;
using Restarunt.common.Repositories;
using Restarunt.Dao.DB;
using Restarunt.Dao.Repositories;
using Restarunt.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();


builder.Services.AddDbContext<Restarunt_DbContext>(options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:DConn"])
);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
