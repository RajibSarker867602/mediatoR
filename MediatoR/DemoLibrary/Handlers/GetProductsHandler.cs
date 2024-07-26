using DemoLibrary.Data;
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
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<Product>>
    {
        private readonly IDataAccess _dataAccess;

        public GetProductsHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetProducts());
        }
    }
}
