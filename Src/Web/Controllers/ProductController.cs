using Application.Features.Products.Queries.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllProductsQuery(), cancellationToken));
        }
    }
}
