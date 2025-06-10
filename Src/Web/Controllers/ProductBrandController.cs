using Application.Features.ProductBrands.Queries.GetAll;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductBrandController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductBrand>>> Get(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllProductBrandQuery(), cancellationToken));
        }
    }
}
