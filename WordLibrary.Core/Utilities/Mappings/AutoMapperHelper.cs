using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordLibrary.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        static IMapper _mapper;
        public AutoMapperHelper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            List<T> result = _mapper.Map<List<T>, List<T>>(list);
                 return result;
        }
        public static T MapToSameType<T>(T obj)
        {
            T result = _mapper.Map<T, T>(obj);
            return result;
        }
    }
}
