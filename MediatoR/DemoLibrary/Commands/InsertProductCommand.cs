using DemoLibrary.Abstractions.Messaging;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoLibrary.Commands
{
    public record InsertProductCommand(string Name, double Price): ICommand<Product>;
}
