using ExpenseTracker.API.Data;
using ExpenseTracker.API.Repository;
using ExpenseTracker.API.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add dbcontect with connection string
builder.Services.AddDbContext<ExpenseTrackerContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseTracker")));

//Add service dependencies
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();

//Add repository dependencies
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();

//Add controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Map controllers
app.MapControllers();
app.Run();
