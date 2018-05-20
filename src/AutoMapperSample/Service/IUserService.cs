using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperSample.Models;

namespace AutoMapperSample.Service
{
    public interface IUserService
    {
        IEnumerable<UserResultModel> Get();
    }
}