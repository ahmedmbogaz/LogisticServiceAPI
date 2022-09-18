using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages.Orders
{
    public class AddOrderModel : PageModel
    {
        private readonly IOrderService _orderService;

        public AddOrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return null;
        }


        public async Task<IActionResult> OnPost()
        {
            Order order = new Order()
            {
                ProductId = Order.Id,
                OrderTime=DateTime.Now,
                PhoneNumber=Order.PhoneNumber,
                AddressId=Order.AddressId,
                Status=0,
                ReceivedCustomerName=Order.ReceivedCustomerName
            };

            await _orderService.AddAsync(order);
            return RedirectToAction("OnGet");
        }
    }
}
