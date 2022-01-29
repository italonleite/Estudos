using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Data;
using UnitOfShop.Data.Interfaces;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interfaces;

namespace UnitOfShop.Controllers
{
   [ApiController]
   [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _uow;

          
        public OrderController(ICustomerRepository customerRepository, IOrderRepository orderRepository, IUnitOfWork uow)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
            _uow = uow;

        }
        [HttpPost]
       [Route("")]
        public Order Post()
        {
            try
            {
                var customer = new Customer() {name = "italo" };
                var order = new Order() {Number = 123, Customer = customer };

                _customerRepository.save(customer);
                _orderRepository.save(order);
                throw new Exception();
                _uow.Commit();

                return order;

            }
            catch 
            {
                _uow.Rollback();
                return null;
            }
           
        }
    }
}
