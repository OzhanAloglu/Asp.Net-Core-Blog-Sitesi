using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterServices
	{
		IWriterDal _ıwriterdal;

		public WriterManager(IWriterDal ıwriterdal)
		{
			_ıwriterdal = ıwriterdal;
		}

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _ıwriterdal.GetListAll(x=>x.WriterID== id);


        }

        public void TAdd(Writer t)
        {
            _ıwriterdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            _ıwriterdal.Delete(t);
        }

        public Writer TGetById(int id)
        {
           return _ıwriterdal.GetByID(id);
        }

        public void TUpdate(Writer t)
        {
            _ıwriterdal.Update(t);
        }

       
	}
}
