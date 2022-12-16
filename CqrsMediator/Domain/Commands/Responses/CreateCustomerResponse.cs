namespace CqrsMediator.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
