using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<Word, Word>();
        }
    }
}
