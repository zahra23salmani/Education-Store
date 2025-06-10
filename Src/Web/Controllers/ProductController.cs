using Application.Features.ProductBrands.Queries.GetAll;
using Application.Features.Products.Queries.Get;
using Application.Features.Products.Queries.GetAll;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllProductsQuery(), cancellationToken));
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> Get([FromRoute] int id, CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetProductQuery(id), cancellationToken));
        }
        

    }
}
