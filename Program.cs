using MyErp.Business;
using MyErp.DAL;
using MyErp.DAL.Models;
using MyErp.PrintService;

namespace MyErp.Application;

internal abstract class Program
{
    private static void Main()
    {
        var orderRepository = new OrderRepository();
        var customerRepository = new CustomerRepository();
        var printingService = new PrintingService();

        // Create and save 5 orders
        for (var i = 0; i < 5; i++)
        {
            var order = new Order
            {
                OrderId = i + 1, 
                Amount = (100 * (i + 1)).ToString() 
            };
            orderRepository.Create(order);
        }


        // Create and save 5 customers
        for (var i = 0; i < 5; i++)
        {
            var customer = new Customer
            {
                CustomerId = i + 1,
                FirstName = "Dimitris",
                LastName = "Diamantidis"
            };
            customerRepository.Create(customer);
        }

        // Retrieve all orders and customers
        var orders = orderRepository.GetAll();
        var customers = customerRepository.GetAll();

        // Print first order and first customer
        var firstOrder = orders.FirstOrDefault();
        var firstCustomer = customers.FirstOrDefault();

        if (firstOrder != null) printingService.Print(firstOrder);

        if (firstCustomer != null) printingService.Print(firstCustomer);
    }
}