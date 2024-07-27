using DemoLibrary.Abstractions.Messaging;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetProductByIdHandler : IQueryHandler<GetProductByIdQuery, Product>
    {
        private readonly IMediator _mediator;

        public GetProductByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return products.FirstOrDefault(c => c.Id == request.Id);
        }
    }
}
