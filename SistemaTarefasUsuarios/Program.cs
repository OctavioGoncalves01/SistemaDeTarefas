using Microsoft.EntityFrameworkCore;
using SistemaTarefasUsuarios.Data;
using SistemaTarefasUsuarios.Repositorios;
using SistemaTarefasUsuarios.Repositorios.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaTarefasDBContext>(
        options => options.UseSqlServer
                    (
                        builder.Configuration.GetConnectionString("DefaultConnection")
                    )
    );

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

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
