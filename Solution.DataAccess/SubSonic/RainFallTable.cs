 
using System;

namespace Solution.DataAccess.DataModel {
        /// <summary>
        /// Table: RainFall
        /// </summary>

        public class RainFallTable {
			/// <summary>
			/// 表名
			/// </summary>
			public static string TableName {
				get{
        			return "RainFall";
      			}
			}

			/// <summary>
			/// 
			/// </summary>
   			public static string Id{
			      get{
        			return "Id";
      			}
		    }
			/// <summary>
			/// 
			/// </summary>
   			public static string AddYear{
			      get{
        			return "AddYear";
      			}
		    }
			/// <summary>
			/// 
			/// </summary>
   			public static string RainCount{
			      get{
        			return "RainCount";
      			}
		    }
                    
        }
}
