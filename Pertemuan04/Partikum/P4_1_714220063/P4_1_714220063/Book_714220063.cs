using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220063
{
    public class Book_714220063 : Product_714220063
    {
        protected string pageCount;

        public Book_714220063(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                this.pageCount = value;
            }
        }
    }
}