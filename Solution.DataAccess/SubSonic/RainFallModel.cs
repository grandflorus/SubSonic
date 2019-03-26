 
using System;
using System.Text;

namespace Solution.DataAccess.Model
{
    /// <summary>
    /// RainFall表实体类
    /// </summary>
    public partial class RainFall
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

		int _AddYear = 0;
		/// <summary>
		/// 
		/// </summary>
		public int AddYear
		{
			get { return _AddYear; }
			set { _AddYear = value; }
		}

		double _RainCount = 0;
		/// <summary>
		/// 
		/// </summary>
		public double RainCount
		{
			get { return _RainCount; }
			set { _RainCount = value; }
		}

		/// <summary>
        /// 输出实体所有值
        /// </summary>
        /// <returns></returns>
		public string ToString(){
			var sb = new StringBuilder();
			sb.Append("Id=" +　Id + "; ");
			sb.Append("AddYear=" +　AddYear + "; ");
			sb.Append("RainCount=" +　RainCount + "; ");
			return sb.ToString();
        }

    } 

}


