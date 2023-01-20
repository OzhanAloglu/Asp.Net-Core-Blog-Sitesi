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
    public class NewsLetterManager : INewsLetterServices
    {
        INewsLetterDal _newsletterdal;

        public NewsLetterManager(INewsLetterDal newsletterdal)
        {
            _newsletterdal = newsletterdal;
        }

        public void AddNewsLetter(NewsLetter newsletter)
        {
           _newsletterdal.Insert(newsletter);
        }
    }
}
