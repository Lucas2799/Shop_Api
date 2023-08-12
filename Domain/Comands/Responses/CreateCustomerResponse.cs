using System;

namespace Shop.Domain.Comands.Responses

{
    public class CreateCustomerResponse
    {
        public Guid ID {get; set;} 
        public string Name{get; set;}
        public string Email {get; set;}
        public DateTime Date {get; set;}

    }
}