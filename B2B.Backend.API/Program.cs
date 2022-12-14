using Autofac;
using Autofac.Extensions.DependencyInjection;
using B2B.Backend.API.Modules;
using B2B.Backend.Core.Repositories;
using B2B.Backend.Core.UnitOfWorks;
using B2B.Backend.Repository.Contexts;
using B2B.Backend.Repository.Repositories;
using B2B.Backend.Repository.UnitOfWorks;
using B2B.Backend.Service.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<B2BDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(B2BDbContext)).GetName().Name);
    });
});

builder.Services.AddAutoMapper(typeof(GeneralMapping));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new AutofacRepoServiceModule()));

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
