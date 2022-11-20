using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
	public class BlogManager : IBlogService

	{
		IBlogDataAccessL _blogdataaccessl;

		public BlogManager(IBlogDataAccessL blogdataaccessl)
		{
			_blogdataaccessl = blogdataaccessl;
		}

		public void BlogAdd(Blog blog) => throw new NotImplementedException();
		public void BlogDelete(Blog blog) => throw new NotImplementedException();
		public void BlogUpdate(Blog blog) => throw new NotImplementedException();


        //public List<Blog> GetBlogListWithCategory()
        //{
        //    throw new NotImplementedException();
        //}
		public List<Blog> GetBlogListWithCategory()
		{
			return _blogdataaccessl.GetListWithCategory();   //
		}

		public List<Blog> List => throw new NotImplementedException();

		public Blog GetById(int id) => throw new NotImplementedException();

		public List<Blog> GetBlogByID(int id)
		{
			return _blogdataaccessl.GetListAll(x => x.BlogID == id);
		}
		public List<Blog> GetList() => _blogdataaccessl.GetListAll();

		public List<Blog> GetBlogListByWriter(int id)
		{
			 throw new NotImplementedException();
        }

		
	}
}
