using Application.Contracts;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.Get
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IUnitOfWork _uow;
        public GetProductQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var entity = await _uow.Repository<Product>().GetByIdAsync(request.Id, cancellationToken);
            if (entity == null) throw new Exception("error message");
            return entity;
        }
    }
}
