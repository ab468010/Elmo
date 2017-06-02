using System;
using System.Data;

namespace Elmo.Common
{

    /// <summary>
    /// 字段信息
    /// </summary>
    [Serializable]
    public class Field:Attribute
    {
        public Field(string fieldName) : this(fieldName, null) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="tableName"></param>
        public Field(string fieldName, string tableName) : this(fieldName, tableName, null, null, fieldName) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="tableName"></param>
        /// <param name="description"></param>
        public Field(string fieldName, string tableName, string description) : this(fieldName, tableName, null, null, description) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="tableName"></param>
        /// <param name="parameterDbType"></param>
        /// <param name="parameterSize"></param>
        /// <param name="description"></param>
        public Field(string fieldName, string tableName, DbType? parameterDbType, int? parameterSize, string description) : this(fieldName, tableName, parameterDbType, parameterSize, description, null) { }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="tableName"></param>
        /// <param name="parameterDbType"></param>
        /// <param name="parameterSize"></param>
        /// <param name="description"></param>
        /// <param name="aliasName"></param>
        public Field(string fieldName, string tableName, DbType? parameterDbType, int? parameterSize, string description, string aliasName)
        {
            this.fieldName = fieldName;
            this.tableName = tableName;
            this.description = description;
            this.aliasName = aliasName;
            this.parameterDbType = parameterDbType;
            this.parameterSize = parameterSize;
        }


        #region 字段

        /// <summary>
        /// 字段名
        /// </summary>
        private string fieldName;

        /// <summary>
        /// 表名
        /// </summary>
        public string tableName;

        /// <summary>
        /// 字段别名
        /// </summary>
        private string aliasName;

        /// <summary>
        /// 字段描述
        /// </summary>
        private string description;

        /// <summary>
        /// 字段数据库中类型
        /// </summary>
        private DbType? parameterDbType;

        /// <summary>
        /// 字段数据库中长度
        /// </summary>
        private int? parameterSize;

        /// <summary>
        /// 所有字段   就是  *  
        /// </summary>
        public static readonly Field All = new Field("*");
        #endregion
    }
}
