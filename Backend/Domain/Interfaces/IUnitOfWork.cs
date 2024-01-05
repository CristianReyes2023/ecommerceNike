using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICity Cities {get;}
        IClient Clients {get;}
        IAddress Addresses {get;}
        ICountry Countries {get;}
        IGamaproduct Gamaproducts {get;}
        IOrder Orders {get;}
        IProduct Products {get;}
        IState States {get;}

        Task<int> SaveAsync();
    }
}