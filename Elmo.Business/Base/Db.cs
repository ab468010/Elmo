using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;

namespace Elmo.Business.Base
{
    public class Db
    {
        public static readonly DbSession Context = new DbSession("Conn");

        static Db()
        {
            Context.RegisterSqlLogger(delegate (string sql) 
            {

            } );
        }
    }
}
