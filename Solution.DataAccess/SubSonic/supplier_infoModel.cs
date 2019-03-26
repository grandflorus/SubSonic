 
using System;
using System.Text;

namespace Solution.DataAccess.Model
{
    /// <summary>
    /// supplier_info表实体类
    /// </summary>
    public partial class supplier_info
    {

		int _Id = 0;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

		string _supplier_code = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_code
		{
			get { return _supplier_code; }
			set { _supplier_code = value; }
		}

		string _supplier_name = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_name
		{
			get { return _supplier_name; }
			set { _supplier_name = value; }
		}

		string _supplier_connecter = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_connecter
		{
			get { return _supplier_connecter; }
			set { _supplier_connecter = value; }
		}

		string _supplier_phone = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_phone
		{
			get { return _supplier_phone; }
			set { _supplier_phone = value; }
		}

		string _supplier_address = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_address
		{
			get { return _supplier_address; }
			set { _supplier_address = value; }
		}

		string _supplier_distance = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_distance
		{
			get { return _supplier_distance; }
			set { _supplier_distance = value; }
		}

		string _supplier_product = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_product
		{
			get { return _supplier_product; }
			set { _supplier_product = value; }
		}

		string _supplier_account = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_account
		{
			get { return _supplier_account; }
			set { _supplier_account = value; }
		}

		string _supplier_type = "";
		/// <summary>
		/// 
		/// </summary>
		public string supplier_type
		{
			get { return _supplier_type; }
			set { _supplier_type = value; }
		}

		/// <summary>
        /// 输出实体所有值
        /// </summary>
        /// <returns></returns>
		public string ToString(){
			var sb = new StringBuilder();
			sb.Append("Id=" +　Id + "; ");
			sb.Append("supplier_code=" +　supplier_code + "; ");
			sb.Append("supplier_name=" +　supplier_name + "; ");
			sb.Append("supplier_connecter=" +　supplier_connecter + "; ");
			sb.Append("supplier_phone=" +　supplier_phone + "; ");
			sb.Append("supplier_address=" +　supplier_address + "; ");
			sb.Append("supplier_distance=" +　supplier_distance + "; ");
			sb.Append("supplier_product=" +　supplier_product + "; ");
			sb.Append("supplier_account=" +　supplier_account + "; ");
			sb.Append("supplier_type=" +　supplier_type + "; ");
			return sb.ToString();
        }

    } 

}


