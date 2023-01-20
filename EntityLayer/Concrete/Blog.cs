using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }






        //Alttaki kod Category için ilişki.

        public int CategoryID { get; set; }

        public Category Category { get; set; }


		public int WriterID { get; set; }

		public Writer Writer { get; set; }


		//Alttaki kod Comment ilişkisi.

		public  List<Comment> Comments  { get; set; }

    }
}
