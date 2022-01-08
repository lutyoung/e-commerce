using Microsoft.AspNetCore.Mvc;
using OnlineCom.Web.Interface.IServices;
using OnlineCom.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var list = _categoryService.GetAll().Select(a => new CategoryViewModel
            {
                Id = a.Id,
                CategoryName = a.CategoryName,
                DisplayOrder = a.DisplayOrder
            });

            return View(list);
        }
    }
}
