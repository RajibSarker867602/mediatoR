﻿using DemoLibrary.Abstractions.Messaging;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetProductsQuery() : IQuery<List<Product>>;
}
