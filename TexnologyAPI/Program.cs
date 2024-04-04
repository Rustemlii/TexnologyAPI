using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Map;
using DataAccess.Entity;
using DataAccess.MyContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext
builder.Services.AddDbContext<Context>(opt=>
opt.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));

//AutoMapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MyMapper());
});
builder.Services.AddSingleton(mappingConfig.CreateMapper());

//Services

builder.Services.AddScoped<ICategory,CategoryService>();
builder.Services.AddScoped<IMarka,MarkaService>();
builder.Services.AddScoped<IModel,ModelService>();

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
