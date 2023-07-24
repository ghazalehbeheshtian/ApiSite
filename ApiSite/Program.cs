using ApiSite.Contexts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ApiSite.Models.Dtos;
using ApiSite.Models.Entities;
using ApiSite.Repository;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ProductResponse>();
builder.Services.AddScoped<ProductRequest>();
builder.Services.AddScoped<ProductEntity>();
builder.Services.AddScoped<ProductRepository>();


builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DataDB")));












var app = builder.Build();


app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
