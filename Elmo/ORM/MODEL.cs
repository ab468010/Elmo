using Elmo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elmo.Common;

namespace Elmo.ORM
{

    [Table("Test")]
    [Serializable]
    public class MODEL:Entity
    {
        [Field("ProductId","Product")]
        public string ProductId { get; set; }


        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
               
            };
        }

        public Field[] GetFields<TFiled>()
        {
            return new Field[] {

            };
        }

    }
}
