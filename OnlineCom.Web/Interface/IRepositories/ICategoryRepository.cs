using OnlineCom.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Interface.IRepositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();

        public Category GetById(int id);

        public Category AddCategory(Category category);
    }
}
