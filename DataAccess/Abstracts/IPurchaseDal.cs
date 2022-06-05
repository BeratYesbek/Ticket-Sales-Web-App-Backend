﻿using Core.DataAccess;
using Entity.Concretes;
using Entity.Concretes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IPurchaseDal : IEntityRepository<Purchase>
    {
        List<TicketOrderDto> GetByUserId(int userId);
    }
}
