using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NikeContext _context;

        public UnitOfWork(NikeContext context)
        {
            _context = context;
        }

        private IAddress _address;
        private ICity _cities;
        private IClient _clients;
        private ICountry _countries;
        private IGamaproduct _gamaproducts;
        private IOrder _orders;
        private IProduct _products;
        private IState _states;

        public IAddress Addresses // 2611
        {
            get
            {
                if (_address == null)
                {
                    _address = new AddressRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _address;
            }
        }
        public ICity Cities // 2611
        {
            get
            {
                if (_cities == null)
                {
                    _cities = new CityRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _cities;
            }
        }
        public IClient Clients // 2611
        {
            get
            {
                if (_clients == null)
                {
                    _clients = new ClientRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _clients;
            }
        }
        public ICountry Countries // 2611
        {
            get
            {
                if (_countries == null)
                {
                    _countries = new CountryRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _countries;
            }
        }
        public IGamaproduct Gamaproducts // 2611
        {
            get
            {
                if (_gamaproducts == null)
                {
                    _gamaproducts = new GamaproductRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _gamaproducts;
            }
        }
        public IOrder Orders // 2611
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new OrderRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _orders;
            }
        }
        public IProduct Products // 2611
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _products;
            }
        }
        public IState States // 2611
        {
            get
            {
                if (_states == null)
                {
                    _states = new StateRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _states;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}