using DemoLibrary.Commands;
using DemoLibrary.Data;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly IDataAccess _dataAccess;

        public InsertProductHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertProduct(request.Name, request.Price));
        }
    }
}
