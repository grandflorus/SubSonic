 
using System;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace Solution.DataAccess.DataModel {
        /// <summary>
        /// Table: RainFall
        /// Primary Key: Id
        /// </summary>

        public class RainFallStructs: DatabaseTable {
            
            public RainFallStructs(IDataProvider provider):base("RainFall",provider){
                ClassName = "RainFall";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "Id"
                });

                Columns.Add(new DatabaseColumn("AddYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "AddYear"
                });

                Columns.Add(new DatabaseColumn("RainCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "RainCount"
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
            
            public IColumn AddYear{
                get{
                    return this.GetColumn("AddYear");
                }
            }
				
            
            public IColumn RainCount{
                get{
                    return this.GetColumn("RainCount");
                }
            }
				
            
                    
        }
        
}
