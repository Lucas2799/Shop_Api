using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Comands.Handlers;
using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Controllers{
    [ApiController]
    [Route ("v1/customers")]
    public class CustomerController : ControllerBase{
        [HttpPost]
        [Route("")]
        public CreateCustomerResponse Create(

            [FromServices] ICreateCustomerHandler handler,
            [FromBody]CreateCustomerRequest comand
            
        ){
            return handler.Handle(comand);

        }

    }
}