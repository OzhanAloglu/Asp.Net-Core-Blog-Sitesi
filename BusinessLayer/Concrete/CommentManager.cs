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
    public class CommentManager : ICommentServices
    {

        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentdal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentdal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentdal.Update(comment);
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentWithBlog()
        {
            return _commentdal.GetListWithBlog();
        }

        public List<Comment> GetList(int id)
        {
            return _commentdal.GetListAll(x=>x.BlogID==id);
        }
    }
}
