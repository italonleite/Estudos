using Microsoft.EntityFrameworkCore;
using UnitOfShop.Data;
using UnitOfShop.Data.Interfaces;
using UnitOfShop.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer("Server=DESKTOP-D4JN8G8;Database=UnitShop;Trusted_Connection=True;MultipleActiveResultSets=true"));
// Add services to the container.
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
