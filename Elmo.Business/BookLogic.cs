using Dos.Common;
using Dos.ORM;
using Elmo.Business.Base;
using Elmo.Model;
using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmo.Business
{
    public class BookLogic
    {

        public BaseResult GetBook(BookParam param)
        {
            var where = new Where<Book>();

            var fs = Db.Context.From<Book>()
                .OrderByDescending(d => new { d.CreatedOn, d.BookId });

            var list = fs.ToList();

            return new BaseResult(true,list);
        }
    }
}
