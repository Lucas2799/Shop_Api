using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Comands.Handlers

{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle (CreateCustomerRequest request){

            // Verifica se o clienete já esta cadastrado
            //Valida os dados
            // Insere o cliente 
            //Envia o E-maisl de boas vindas

            return new CreateCustomerResponse{
                ID = Guid.NewGuid(),
                Name = "Lucas Tavares",
                Email = "ltv2234@gmail.com",
                Date = DateTime.Now
            };

        }
    }
}