using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
	public class CommentManager : ICommentService
	{
		ICommentDataAccessL _commentDataAccessL;

		public CommentManager(ICommentDataAccessL commentDataAccessL)
		{
			_commentDataAccessL = commentDataAccessL;
		}

		public void CommentAdd(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentDataAccessL.GetListAll(x => x.BlogID == id);
		}

		
	}
}
