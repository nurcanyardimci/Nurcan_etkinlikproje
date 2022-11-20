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
	public class WriterManager : IWriterService
	{
		IWriterDataAccessL _writerdataaccessl;

		public WriterManager(IWriterDataAccessL writerdataaccessl)
		{
			_writerdataaccessl = writerdataaccessl;
		}

		public void WriterAdd(Writer writer)
		{
			_writerdataaccessl.Insert(writer); 
		}
	}
}
