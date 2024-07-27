using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Notifications;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eComApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await _mediator.Send(new GetProductsQuery());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _mediator.Send(new GetProductByIdQuery(id));
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<Product> Post([FromBody] Product product)
        {
            var response = await _mediator.Send(new InsertProductCommand(product.Name, product.Price));
            
            // publish notification for product insert
            await _mediator.Publish(new InsertProductNotification(response.Id));
            
            return response;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
