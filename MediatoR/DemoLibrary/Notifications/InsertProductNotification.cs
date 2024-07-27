using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Notifications
{
    public record InsertProductNotification(int Id) : INotification;
}
