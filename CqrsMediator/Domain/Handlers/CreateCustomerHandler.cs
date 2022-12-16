using CqrsMediator.Domain.Commands.Requests;
using CqrsMediator.Domain.Commands.Responses;
using MediatR;

namespace CqrsMediator.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Guid = Guid.NewGuid(),
                Name = "Augusto Campos",
                Email = "augustocamposxp@gmail.com",
            };

            return Task.FromResult(result);
        }

    }
}
