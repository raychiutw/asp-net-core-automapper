using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperSample.Models;

namespace AutoMapperSample.MappingProfiles
{
    public class UserProfie : Profile
    {
        public UserProfie()
        {
            // 建立 Profile 對照定義
            CreateMap<UserResultModel, UserViewModel>();
        }
    }
}