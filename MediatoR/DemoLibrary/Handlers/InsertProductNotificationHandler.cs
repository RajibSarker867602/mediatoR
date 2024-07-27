using DemoLibrary.Notifications;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertProductNotificationHandler(ILogger<InsertProductNotificationHandler> logger) : INotificationHandler<InsertProductNotification>
    {
        public Task Handle(InsertProductNotification notification, CancellationToken cancellationToken)
        {
            logger.LogInformation($"New product has been created with id: {notification.Id}");
            return Task.CompletedTask;
        }
    }
}
