using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Comands.Handlers;
using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Controllers{
    [ApiController]
    public class CustomerController : ControllerBase{
        [HttpPost]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody]CreateCustomerRequest comand
        ){
            return handler.Handle(comand);

        }

    }
}