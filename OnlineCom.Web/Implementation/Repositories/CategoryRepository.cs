using OnlineCom.Web.Context;
using OnlineCom.Web.Interface.IRepositories;
using OnlineCom.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Implementation.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineComContext _context;

        public CategoryRepository(OnlineComContext context)
        {
            _context = context;
        }

        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public List<Category> GetAll()
        {
            var list = _context.Categories.ToList();
            return list;
        }

        public Category GetById(int id)
        {
            var getbyId = _context.Categories.Find(id);

            return getbyId;
        }
    }
}
