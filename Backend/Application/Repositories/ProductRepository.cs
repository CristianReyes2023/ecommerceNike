using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProduct
    {
        private readonly NikeContext _context;

        public ProductRepository(NikeContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Object>> GetBasketballShoes()
        {
            var results = await(from _product in _context.Products
                                join _gamaproduct in _context.Gamaprodructs on _product.IdGamaProductFk equals _gamaproduct.Id
                                where _product.IdGamaProductFk == 2
                                select new 
                                {
                                    NameProduct = _product.NameProduct,
                                    Price = _product.Price
                                }).ToListAsync();
            return results;
        }

        public async Task<IEnumerable<Object>> GetRunningShoes()
        {
            var results = await (from _product in _context.Products
                                join _gamaproduct in _context.Gamaprodructs on _product.IdGamaProductFk equals _gamaproduct.Id
                                where _product.IdGamaProductFk == 1
                                select new 
                                {
                                    NameProduct = _product.NameProduct,
                                    Price = _product.Price
                                }).ToListAsync();
            return results;
        }

        public async Task<IEnumerable<Object>> GetCasualSneakers()
        {
            var results = await(from _product in _context.Products
                                join _gamaproduct in _context.Gamaprodructs on _product.IdGamaProductFk equals _gamaproduct.Id
                                where _product.IdGamaProductFk == 5
                                select new
                                {
                                    NameProduct = _product.NameProduct,
                                    Price = _product.Price
                                }).ToListAsync();
            return results;
        }
    }
}