 
using System;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace Solution.DataAccess.DataModel {
        /// <summary>
        /// Table: supplier_info
        /// Primary Key: 
        /// </summary>

        public class supplier_infoStructs: DatabaseTable {
            
            public supplier_infoStructs(IDataProvider provider):base("supplier_info",provider){
                ClassName = "supplier_info";
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

                Columns.Add(new DatabaseColumn("supplier_code", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_code"
                });

                Columns.Add(new DatabaseColumn("supplier_name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_name"
                });

                Columns.Add(new DatabaseColumn("supplier_connecter", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_connecter"
                });

                Columns.Add(new DatabaseColumn("supplier_phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_phone"
                });

                Columns.Add(new DatabaseColumn("supplier_address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_address"
                });

                Columns.Add(new DatabaseColumn("supplier_distance", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_distance"
                });

                Columns.Add(new DatabaseColumn("supplier_product", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1,
					PropertyName = "supplier_product"
                });

                Columns.Add(new DatabaseColumn("supplier_account", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_account"
                });

                Columns.Add(new DatabaseColumn("supplier_type", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150,
					PropertyName = "supplier_type"
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
            
            public IColumn supplier_code{
                get{
                    return this.GetColumn("supplier_code");
                }
            }
				
            
            public IColumn supplier_name{
                get{
                    return this.GetColumn("supplier_name");
                }
            }
				
            
            public IColumn supplier_connecter{
                get{
                    return this.GetColumn("supplier_connecter");
                }
            }
				
            
            public IColumn supplier_phone{
                get{
                    return this.GetColumn("supplier_phone");
                }
            }
				
            
            public IColumn supplier_address{
                get{
                    return this.GetColumn("supplier_address");
                }
            }
				
            
            public IColumn supplier_distance{
                get{
                    return this.GetColumn("supplier_distance");
                }
            }
				
            
            public IColumn supplier_product{
                get{
                    return this.GetColumn("supplier_product");
                }
            }
				
            
            public IColumn supplier_account{
                get{
                    return this.GetColumn("supplier_account");
                }
            }
				
            
            public IColumn supplier_type{
                get{
                    return this.GetColumn("supplier_type");
                }
            }
				
            
                    
        }
        
}
