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
    public class InsertProductStockUpdateNotificationHandler(ILogger<InsertProductStockUpdateNotificationHandler> logger) : INotificationHandler<InsertProductNotification>
    {
        public Task Handle(InsertProductNotification notification, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Stock has been updated for product id of: {notification.Id}");
            return Task.CompletedTask;
        }
    }
}
