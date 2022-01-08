using OnlineCom.Web.Dtos;
using OnlineCom.Web.Interface.IRepositories;
using OnlineCom.Web.Interface.IServices;
using OnlineCom.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Implementation.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryrepo;

        public CategoryService(ICategoryRepository categoryrepo)
        {
            _categoryrepo = categoryrepo;
        }

        public List<CategoryDto> GetAll()
        {
            var list = _categoryrepo.GetAll().Select(a => new CategoryDto
            {
                Id = a.Id,
                CategoryName = a.CategoryName,
                DisplayOrder = a.DisplayOrder
            }).ToList();

            return list;
        }
    }
}
