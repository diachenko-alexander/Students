using DAL.Models;
using DAL.Context;
using BLL.DTO;
using AutoMapper;
using BLL.Mapper;

namespace BLL.Services
{
    public class BaseService
    {
        protected StudentsDB db;

        protected static MapperConfiguration config = new AutoMapperConfiguration().Configure();
        protected IMapper iMapper = config.CreateMapper();
    }
}
