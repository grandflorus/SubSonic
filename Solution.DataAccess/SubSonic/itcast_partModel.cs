 
using System;
using System.Text;

namespace Solution.DataAccess.Model
{
    /// <summary>
    /// itcast_part表实体类
    /// </summary>
    public partial class itcast_part
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

		string _Unit = "";
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			get { return _Unit; }
			set { _Unit = value; }
		}

		string _AssemCode = "";
		/// <summary>
		/// 
		/// </summary>
		public string AssemCode
		{
			get { return _AssemCode; }
			set { _AssemCode = value; }
		}

		string _AssemName = "";
		/// <summary>
		/// 
		/// </summary>
		public string AssemName
		{
			get { return _AssemName; }
			set { _AssemName = value; }
		}

		string _Spec = "";
		/// <summary>
		/// 
		/// </summary>
		public string Spec
		{
			get { return _Spec; }
			set { _Spec = value; }
		}

		string _VehicleModelID = "";
		/// <summary>
		/// 
		/// </summary>
		public string VehicleModelID
		{
			get { return _VehicleModelID; }
			set { _VehicleModelID = value; }
		}

		string _LocationStock = "";
		/// <summary>
		/// 
		/// </summary>
		public string LocationStock
		{
			get { return _LocationStock; }
			set { _LocationStock = value; }
		}

		string _AssemSourceCode = "";
		/// <summary>
		/// 
		/// </summary>
		public string AssemSourceCode
		{
			get { return _AssemSourceCode; }
			set { _AssemSourceCode = value; }
		}

		string _RepairPrd = "";
		/// <summary>
		/// 
		/// </summary>
		public string RepairPrd
		{
			get { return _RepairPrd; }
			set { _RepairPrd = value; }
		}

		string _VendorID = "";
		/// <summary>
		/// 
		/// </summary>
		public string VendorID
		{
			get { return _VendorID; }
			set { _VendorID = value; }
		}

		string _ProBatch = "";
		/// <summary>
		/// 
		/// </summary>
		public string ProBatch
		{
			get { return _ProBatch; }
			set { _ProBatch = value; }
		}

		DateTime _ProDate = new DateTime(1900,1,1);
		/// <summary>
		/// 
		/// </summary>
		public DateTime ProDate
		{
			get { return _ProDate; }
			set { _ProDate = value; }
		}

		string _ProLocation = "";
		/// <summary>
		/// 
		/// </summary>
		public string ProLocation
		{
			get { return _ProLocation; }
			set { _ProLocation = value; }
		}

		string _TypeCode = "";
		/// <summary>
		/// 
		/// </summary>
		public string TypeCode
		{
			get { return _TypeCode; }
			set { _TypeCode = value; }
		}

		string _TypeName = "";
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			get { return _TypeName; }
			set { _TypeName = value; }
		}

		string _Remark = "";
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			get { return _Remark; }
			set { _Remark = value; }
		}

		/// <summary>
        /// 输出实体所有值
        /// </summary>
        /// <returns></returns>
		public string ToString(){
			var sb = new StringBuilder();
			sb.Append("Id=" +　Id + "; ");
			sb.Append("Unit=" +　Unit + "; ");
			sb.Append("AssemCode=" +　AssemCode + "; ");
			sb.Append("AssemName=" +　AssemName + "; ");
			sb.Append("Spec=" +　Spec + "; ");
			sb.Append("VehicleModelID=" +　VehicleModelID + "; ");
			sb.Append("LocationStock=" +　LocationStock + "; ");
			sb.Append("AssemSourceCode=" +　AssemSourceCode + "; ");
			sb.Append("RepairPrd=" +　RepairPrd + "; ");
			sb.Append("VendorID=" +　VendorID + "; ");
			sb.Append("ProBatch=" +　ProBatch + "; ");
			sb.Append("ProDate=" +　ProDate + "; ");
			sb.Append("ProLocation=" +　ProLocation + "; ");
			sb.Append("TypeCode=" +　TypeCode + "; ");
			sb.Append("TypeName=" +　TypeName + "; ");
			sb.Append("Remark=" +　Remark + "; ");
			return sb.ToString();
        }

    } 

}


