 
using System;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace Solution.DataAccess.DataModel {
        /// <summary>
        /// Table: itcast_part
        /// Primary Key: 
        /// </summary>

        public class itcast_partStructs: DatabaseTable {
            
            public itcast_partStructs(IDataProvider provider):base("itcast_part",provider){
                ClassName = "itcast_part";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "Id"
                });

                Columns.Add(new DatabaseColumn("Unit", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "Unit"
                });

                Columns.Add(new DatabaseColumn("AssemCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "AssemCode"
                });

                Columns.Add(new DatabaseColumn("AssemName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "AssemName"
                });

                Columns.Add(new DatabaseColumn("Spec", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "Spec"
                });

                Columns.Add(new DatabaseColumn("VehicleModelID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "VehicleModelID"
                });

                Columns.Add(new DatabaseColumn("LocationStock", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "LocationStock"
                });

                Columns.Add(new DatabaseColumn("AssemSourceCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "AssemSourceCode"
                });

                Columns.Add(new DatabaseColumn("RepairPrd", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "RepairPrd"
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "VendorID"
                });

                Columns.Add(new DatabaseColumn("ProBatch", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "ProBatch"
                });

                Columns.Add(new DatabaseColumn("ProDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "ProDate"
                });

                Columns.Add(new DatabaseColumn("ProLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "ProLocation"
                });

                Columns.Add(new DatabaseColumn("TypeCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "TypeCode"
                });

                Columns.Add(new DatabaseColumn("TypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "TypeName"
                });

                Columns.Add(new DatabaseColumn("Remark", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "Remark"
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
            
            public IColumn Unit{
                get{
                    return this.GetColumn("Unit");
                }
            }
				
            
            public IColumn AssemCode{
                get{
                    return this.GetColumn("AssemCode");
                }
            }
				
            
            public IColumn AssemName{
                get{
                    return this.GetColumn("AssemName");
                }
            }
				
            
            public IColumn Spec{
                get{
                    return this.GetColumn("Spec");
                }
            }
				
            
            public IColumn VehicleModelID{
                get{
                    return this.GetColumn("VehicleModelID");
                }
            }
				
            
            public IColumn LocationStock{
                get{
                    return this.GetColumn("LocationStock");
                }
            }
				
            
            public IColumn AssemSourceCode{
                get{
                    return this.GetColumn("AssemSourceCode");
                }
            }
				
            
            public IColumn RepairPrd{
                get{
                    return this.GetColumn("RepairPrd");
                }
            }
				
            
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
				
            
            public IColumn ProBatch{
                get{
                    return this.GetColumn("ProBatch");
                }
            }
				
            
            public IColumn ProDate{
                get{
                    return this.GetColumn("ProDate");
                }
            }
				
            
            public IColumn ProLocation{
                get{
                    return this.GetColumn("ProLocation");
                }
            }
				
            
            public IColumn TypeCode{
                get{
                    return this.GetColumn("TypeCode");
                }
            }
				
            
            public IColumn TypeName{
                get{
                    return this.GetColumn("TypeName");
                }
            }
				
            
            public IColumn Remark{
                get{
                    return this.GetColumn("Remark");
                }
            }
				
            
                    
        }
        
}
