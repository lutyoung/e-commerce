using OnlineCom.Web.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Interface.IServices
{
    public interface ICategoryService
    {
        public List<CategoryDto> GetAll();

    }
}
