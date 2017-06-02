﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace Elmo.Model
{
    /// <summary>
    /// 实体类BookStock。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BookStock")]
    [Serializable]
    public partial class BookStock : Entity
    {
        #region Model
		private int _BookStockId;
		private int _BookId;
		private int _TotalStock;
		private int? _SellNum;
		private int? _ReturnNum;
		private int? _SpoiledNum;

		/// <summary>
		/// 
		/// </summary>
		[Field("BookStockId")]
		public int BookStockId
		{
			get{ return _BookStockId; }
			set
			{
				this.OnPropertyValueChange("BookStockId");
				this._BookStockId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("BookId")]
		public int BookId
		{
			get{ return _BookId; }
			set
			{
				this.OnPropertyValueChange("BookId");
				this._BookId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TotalStock")]
		public int TotalStock
		{
			get{ return _TotalStock; }
			set
			{
				this.OnPropertyValueChange("TotalStock");
				this._TotalStock = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SellNum")]
		public int? SellNum
		{
			get{ return _SellNum; }
			set
			{
				this.OnPropertyValueChange("SellNum");
				this._SellNum = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ReturnNum")]
		public int? ReturnNum
		{
			get{ return _ReturnNum; }
			set
			{
				this.OnPropertyValueChange("ReturnNum");
				this._ReturnNum = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SpoiledNum")]
		public int? SpoiledNum
		{
			get{ return _SpoiledNum; }
			set
			{
				this.OnPropertyValueChange("SpoiledNum");
				this._SpoiledNum = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.BookStockId,
			};
        }
		/// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.BookStockId;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.BookStockId,
				_.BookId,
				_.TotalStock,
				_.SellNum,
				_.ReturnNum,
				_.SpoiledNum,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BookStockId,
				this._BookId,
				this._TotalStock,
				this._SellNum,
				this._ReturnNum,
				this._SpoiledNum,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "BookStock");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BookStockId = new Field("BookStockId", "BookStock", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BookId = new Field("BookId", "BookStock", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalStock = new Field("TotalStock", "BookStock", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SellNum = new Field("SellNum", "BookStock", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReturnNum = new Field("ReturnNum", "BookStock", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SpoiledNum = new Field("SpoiledNum", "BookStock", "");
        }
        #endregion
	}
}