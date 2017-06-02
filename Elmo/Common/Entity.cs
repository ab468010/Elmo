using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmo.Common
{
    public class Entity
    {
        /// <summary>
        /// GetFields
        /// </summary>
        /// <returns></returns>
        public virtual Field[] GetFields() { return null; }
        /// <summary>
        /// GetValues
        /// </summary>
        /// <returns></returns>
        public virtual object[] GetValues() { return null; }
    }


    /// <summary>
    /// 标记实体类表名
    /// </summary>
    public class Table : Attribute
    {
        private string _tableName;
        private string _userName;

        public Table(string tableName)
        {
            this._tableName = tableName;
        }

        public Table(string tableName, string username)
        {
            this._tableName = tableName;
            this._userName = username;
        }

        public string GetTableName()
        {
            return _tableName;
        }

        public string GetUserName()
        {
            return _userName;
        }




    }
}
