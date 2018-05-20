using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperSample.Models;

namespace AutoMapperSample.Service
{
    public class UserService : IUserService
    {
        public IEnumerable<UserResultModel> Get()
        {
            // 簡單回傳 User的集合
            var result = new List<UserResultModel> {
                new UserResultModel(){ Id = 1, Name = "Ray" },
                new UserResultModel(){ Id = 2, Name = "Jessica" }
            };

            return result;
        }
    }
}