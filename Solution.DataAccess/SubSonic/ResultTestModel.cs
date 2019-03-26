 
using System;
using System.Text;

namespace Solution.DataAccess.Model
{
    /// <summary>
    /// ResultTest表实体类
    /// </summary>
    public partial class ResultTest
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

		string _SummerTest = "";
		/// <summary>
		/// 
		/// </summary>
		public string SummerTest
		{
			get { return _SummerTest; }
			set { _SummerTest = value; }
		}

		/// <summary>
        /// 输出实体所有值
        /// </summary>
        /// <returns></returns>
		public string ToString(){
			var sb = new StringBuilder();
			sb.Append("Id=" +　Id + "; ");
			sb.Append("SummerTest=" +　SummerTest + "; ");
			return sb.ToString();
        }

    } 

}


