 
using System;
using System.Text;

namespace Solution.DataAccess.Model
{
    /// <summary>
    /// DataPassTest表实体类
    /// </summary>
    public partial class DataPassTest
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

		string _a = "";
		/// <summary>
		/// 
		/// </summary>
		public string a
		{
			get { return _a; }
			set { _a = value; }
		}

		string _b = "";
		/// <summary>
		/// 
		/// </summary>
		public string b
		{
			get { return _b; }
			set { _b = value; }
		}

		string _c = "";
		/// <summary>
		/// 
		/// </summary>
		public string c
		{
			get { return _c; }
			set { _c = value; }
		}

		string _d = "";
		/// <summary>
		/// 
		/// </summary>
		public string d
		{
			get { return _d; }
			set { _d = value; }
		}

		/// <summary>
        /// 输出实体所有值
        /// </summary>
        /// <returns></returns>
		public string ToString(){
			var sb = new StringBuilder();
			sb.Append("Id=" +　Id + "; ");
			sb.Append("a=" +　a + "; ");
			sb.Append("b=" +　b + "; ");
			sb.Append("c=" +　c + "; ");
			sb.Append("d=" +　d + "; ");
			return sb.ToString();
        }

    } 

}


