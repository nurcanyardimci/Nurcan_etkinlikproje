using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDataAccessL _categoryDataAccessL;

        public CategoryManager(ICategoryDataAccessL categoryDataAccessL)
        {
            _categoryDataAccessL = categoryDataAccessL;
        }

     
        public void CategoryAdd(Category category, EfCategoryRepository efCategoryRepository)
        {
            _categoryDataAccessL.Insert(category);
        } 

        public void CategoryDelete(Category category, EfCategoryRepository efCategoryRepository)
        {
            _categoryDataAccessL.Delete(category);
        }
        public void CategoryUpdate(Category category, EfCategoryRepository efCategoryRepository)
        {
            _categoryDataAccessL.Update(category);
        } 
        public Category GetById(int id, EfCategoryRepository efCategoryRepository)
        {
            return _categoryDataAccessL.GetByID(id);
        } 
        public List<Category> GetList(EfCategoryRepository efCategoryRepository)
        {
            return _categoryDataAccessL.GetListAll();
        }

        public object GetList() => throw new NotImplementedException();
        void ICategoryService.CategoryAdd(Category category) => throw new NotImplementedException();
        void ICategoryService.CategoryDelete(Category category) => throw new NotImplementedException();
        void ICategoryService.CategoryUpdate(Category category) => throw new NotImplementedException();
        Category ICategoryService.GetById(int id) => throw new NotImplementedException();
        List<Category> ICategoryService.GetList() => throw new NotImplementedException();
       
    }
}
