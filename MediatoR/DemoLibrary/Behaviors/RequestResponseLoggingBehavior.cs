using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoLibrary.Behaviors
{
    public class RequestResponseLoggingBehavior<TRequest, TResponse>(ILogger<RequestResponseLoggingBehavior<TRequest, TResponse>> logger) : IPipelineBehavior<TRequest, TResponse>
        where TRequest : class
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            Guid trackId = Guid.NewGuid();

            // incoming request
            var requestObj = JsonSerializer.Serialize(request);
            logger.LogInformation($"Handling request for {trackId} : {requestObj}");

            // response
            var response = await next();
            var resObj = JsonSerializer.Serialize(response);
            logger.LogInformation($"Response for {trackId} : {resObj}");

            return response;
        }
    }
}
