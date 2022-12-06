﻿using B2B.Backend.Core.Entities;
using B2B.Backend.Core.Repositories;
using B2B.Backend.Core.Services;
using B2B.Backend.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IGenericRepository<Order> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}