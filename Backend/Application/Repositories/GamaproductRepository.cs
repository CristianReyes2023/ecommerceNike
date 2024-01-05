using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class GamaproductRepository : GenericRepository<Gamaprodruct>, IGamaproduct
    {
        private readonly NikeContext _context;

        public GamaproductRepository(NikeContext context) : base(context)
        {
            _context = context;
        }
    }
}