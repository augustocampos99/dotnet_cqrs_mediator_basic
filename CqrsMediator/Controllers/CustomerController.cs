using CqrsMediator.Domain.Commands.Requests;
using CqrsMediator.Domain.Commands.Responses;
using CqrsMediator.Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediator.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<CreateCustomerResponse> create([FromBody]CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        }
    }
}
