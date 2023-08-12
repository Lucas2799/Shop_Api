using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Comands.Handlers
{
    public interface ICreateCustomerHandler
    {
         CreateCustomerResponse Handle (CreateCustomerRequest request);

    
    }
}