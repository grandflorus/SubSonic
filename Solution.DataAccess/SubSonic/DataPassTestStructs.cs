 
using System;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace Solution.DataAccess.DataModel {
        /// <summary>
        /// Table: DataPassTest
        /// Primary Key: 
        /// </summary>

        public class DataPassTestStructs: DatabaseTable {
            
            public DataPassTestStructs(IDataProvider provider):base("DataPassTest",provider){
                ClassName = "DataPassTest";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0,
					PropertyName = "Id"
                });

                Columns.Add(new DatabaseColumn("a", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50,
					PropertyName = "a"
                });

                Columns.Add(new DatabaseColumn("b", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50,
					PropertyName = "b"
                });

                Columns.Add(new DatabaseColumn("c", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "c"
                });

                Columns.Add(new DatabaseColumn("d", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "d"
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
            
            public IColumn a{
                get{
                    return this.GetColumn("a");
                }
            }
				
            
            public IColumn b{
                get{
                    return this.GetColumn("b");
                }
            }
				
            
            public IColumn c{
                get{
                    return this.GetColumn("c");
                }
            }
				
            
            public IColumn d{
                get{
                    return this.GetColumn("d");
                }
            }
				
            
                    
        }
        
}
