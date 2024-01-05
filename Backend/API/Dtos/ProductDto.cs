using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string NameProduct { get; set; } = null!;

        public int Price { get; set; }

        public int StockMin { get; set; }

        public int StockMax { get; set; }

        public int StateStock { get; set; }

        public int IdGamaProductFk { get; set; }
    }
}