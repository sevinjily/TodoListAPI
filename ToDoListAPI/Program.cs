using DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Business;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration; //Configuration (elave olundu)


builder.Services.AddDbContext<TodoDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));//DbContext qeydiyyatý(elave olundu)

builder.Services.AddScoped<ITodoItemRepository, EFTodoItemRepository>();//Dependency Injection (Repository, Service)(elave olundu)
builder.Services.AddScoped<ITodoItemService, TodoItemManager>();


builder.Services.AddControllers();//contolleri tanisin deye(elave olundu)
builder.Services.AddAutoMapper(typeof(Program));//automapper islesin deye


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
