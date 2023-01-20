using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public  BlogValidator() 
        {

            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez");

            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görseli Boş Geçilemez");

            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150  karakterden az veri girişi yapın");

            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Lütfen 4 karakterden fazla veri girişi yapın");
            RuleFor(x => x.BlogContent).MinimumLength(150).WithMessage("Lütfen 150 karakterden fazla veri girişi yapın");






        }


    }
}
