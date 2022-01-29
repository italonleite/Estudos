using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interfaces;

public class OrderRepository : IOrderRepository
{
     private readonly DataContext _context; 
    public OrderRepository(DataContext context)
    {
        _context = context;
    }
    public void save(Order order)
    {
        _context.Orders.Add(order);
       
    }
}