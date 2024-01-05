using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string IdClient { get; set; } = null!;

        public string Telephone { get; set; } = null!;

        public int IdAddressFk { get; set; }
    }
}