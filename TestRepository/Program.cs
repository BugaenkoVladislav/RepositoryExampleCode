using Microsoft.EntityFrameworkCore;
using TestRepository;
using TestRepository.Entities;
using TestRepository.Interfaces;
using TestRepository.Reposories;
using TestRepository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Def")));
// Регистрация Репозиториев
builder.Services.AddScoped<UserService>().AddScoped<UserRepository>().AddScoped<UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

