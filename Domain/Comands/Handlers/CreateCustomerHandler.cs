using MediatR;
using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Comands.Handlers

{
    public class CreateCustomerHandler : 
        IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
           var result = new CreateCustomerResponse{
                ID = Guid.NewGuid(),
                Name = "Lucas Tavares",
                Email = "ltv2234@gmail.com",
                Date = DateTime.Now
           };

           return Task.FromResult(result);
        }
    }
}