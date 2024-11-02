using GerenciamentoTarefas.AutoMapper;
using GerenciamentoTarefas.Interfaces.IRepository;
using GerenciamentoTarefas.Interfaces.IService;
using GerenciamentoTarefas.Repository.Context;
using GerenciamentoTarefas.Repository.Repositories;
using GerenciamentoTarefas.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITarefaService, TarefasService>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.RegisterMapping();

builder.Services.AddDbContext<GerenciadorTarefasEFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



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
