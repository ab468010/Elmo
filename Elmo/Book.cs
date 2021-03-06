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
    /// 实体类Book。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Book")]
    [Serializable]
    public partial class Book : Entity
    {
        #region Model
		private int _BookId;
		private string _Name;
		private string _Authors;
		private string _Translators;
		private int? _Bindings;
		private string _ISBN;
		private string _Press;
		private int? _Language;
		private string _Images;
		private float _Price;
		private string _Summary;
		private DateTime? _CreatedOn;
		private DateTime? _ModifiedOn;
		private int? _CreatedBy;
		private int? _Owner;
		private string _Description;
		private int _StatusCode;

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
		[Field("Name")]
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange("Name");
				this._Name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Authors")]
		public string Authors
		{
			get{ return _Authors; }
			set
			{
				this.OnPropertyValueChange("Authors");
				this._Authors = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Translators")]
		public string Translators
		{
			get{ return _Translators; }
			set
			{
				this.OnPropertyValueChange("Translators");
				this._Translators = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Bindings")]
		public int? Bindings
		{
			get{ return _Bindings; }
			set
			{
				this.OnPropertyValueChange("Bindings");
				this._Bindings = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ISBN")]
		public string ISBN
		{
			get{ return _ISBN; }
			set
			{
				this.OnPropertyValueChange("ISBN");
				this._ISBN = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Press")]
		public string Press
		{
			get{ return _Press; }
			set
			{
				this.OnPropertyValueChange("Press");
				this._Press = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Language")]
		public int? Language
		{
			get{ return _Language; }
			set
			{
				this.OnPropertyValueChange("Language");
				this._Language = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Images")]
		public string Images
		{
			get{ return _Images; }
			set
			{
				this.OnPropertyValueChange("Images");
				this._Images = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Price")]
		public float Price
		{
			get{ return _Price; }
			set
			{
				this.OnPropertyValueChange("Price");
				this._Price = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Summary")]
		public string Summary
		{
			get{ return _Summary; }
			set
			{
				this.OnPropertyValueChange("Summary");
				this._Summary = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CreatedOn")]
		public DateTime? CreatedOn
		{
			get{ return _CreatedOn; }
			set
			{
				this.OnPropertyValueChange("CreatedOn");
				this._CreatedOn = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ModifiedOn")]
		public DateTime? ModifiedOn
		{
			get{ return _ModifiedOn; }
			set
			{
				this.OnPropertyValueChange("ModifiedOn");
				this._ModifiedOn = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CreatedBy")]
		public int? CreatedBy
		{
			get{ return _CreatedBy; }
			set
			{
				this.OnPropertyValueChange("CreatedBy");
				this._CreatedBy = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Owner")]
		public int? Owner
		{
			get{ return _Owner; }
			set
			{
				this.OnPropertyValueChange("Owner");
				this._Owner = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Description")]
		public string Description
		{
			get{ return _Description; }
			set
			{
				this.OnPropertyValueChange("Description");
				this._Description = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("StatusCode")]
		public int StatusCode
		{
			get{ return _StatusCode; }
			set
			{
				this.OnPropertyValueChange("StatusCode");
				this._StatusCode = value;
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
				_.BookId,
			};
        }
		/// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.BookId;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.BookId,
				_.Name,
				_.Authors,
				_.Translators,
				_.Bindings,
				_.ISBN,
				_.Press,
				_.Language,
				_.Images,
				_.Price,
				_.Summary,
				_.CreatedOn,
				_.ModifiedOn,
				_.CreatedBy,
				_.Owner,
				_.Description,
				_.StatusCode,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._BookId,
				this._Name,
				this._Authors,
				this._Translators,
				this._Bindings,
				this._ISBN,
				this._Press,
				this._Language,
				this._Images,
				this._Price,
				this._Summary,
				this._CreatedOn,
				this._ModifiedOn,
				this._CreatedBy,
				this._Owner,
				this._Description,
				this._StatusCode,
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
			public readonly static Field All = new Field("*", "Book");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BookId = new Field("BookId", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Authors = new Field("Authors", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Translators = new Field("Translators", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Bindings = new Field("Bindings", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISBN = new Field("ISBN", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Press = new Field("Press", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Language = new Field("Language", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Images = new Field("Images", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Price = new Field("Price", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Summary = new Field("Summary", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatedOn = new Field("CreatedOn", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ModifiedOn = new Field("ModifiedOn", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreatedBy = new Field("CreatedBy", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Owner = new Field("Owner", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Description = new Field("Description", "Book", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field StatusCode = new Field("StatusCode", "Book", "");
        }
        #endregion
	}
}