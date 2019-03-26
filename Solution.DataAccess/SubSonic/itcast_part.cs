 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using System.Linq.Expressions;
using SubSonic.Schema;
using SubSonic.Repository;
using System.Data.Common;
using SubSonic.SqlGeneration.Schema;

namespace Solution.DataAccess.DataModel
{    
    /// <summary>
    /// A class which represents the itcast_part table in the SolutionDataBase Database.
    /// </summary>
    public partial class itcast_part: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<itcast_part> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<itcast_part>(new Solution.DataAccess.DataModel.SolutionDataBaseDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<itcast_part> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(itcast_part item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                itcast_part item=new itcast_part();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<itcast_part> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Solution.DataAccess.DataModel.SolutionDataBaseDB _db;
        public itcast_part(string connectionString, string providerName) {

            _db=new Solution.DataAccess.DataModel.SolutionDataBaseDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                itcast_part.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<itcast_part>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public itcast_part(){
			_db=new Solution.DataAccess.DataModel.SolutionDataBaseDB();
            Init();            
        }

		public void ORMapping(IDataRecord dataRecord)
        {
            IReadRecord readRecord = SqlReadRecord.GetIReadRecord();
            readRecord.DataRecord = dataRecord;   
               
            Id = readRecord.get_int("Id",null);
               
            Unit = readRecord.get_string("Unit",null);
               
            AssemCode = readRecord.get_string("AssemCode",null);
               
            AssemName = readRecord.get_string("AssemName",null);
               
            Spec = readRecord.get_string("Spec",null);
               
            VehicleModelID = readRecord.get_string("VehicleModelID",null);
               
            LocationStock = readRecord.get_string("LocationStock",null);
               
            AssemSourceCode = readRecord.get_string("AssemSourceCode",null);
               
            RepairPrd = readRecord.get_string("RepairPrd",null);
               
            VendorID = readRecord.get_string("VendorID",null);
               
            ProBatch = readRecord.get_string("ProBatch",null);
               
            ProDate = readRecord.get_datetime("ProDate",null);
               
            ProLocation = readRecord.get_string("ProLocation",null);
               
            TypeCode = readRecord.get_string("TypeCode",null);
               
            TypeName = readRecord.get_string("TypeName",null);
               
            Remark = readRecord.get_string("Remark",null);
                }   

        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public itcast_part(Expression<Func<itcast_part, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<itcast_part> GetRepo(string connectionString, string providerName){
            Solution.DataAccess.DataModel.SolutionDataBaseDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Solution.DataAccess.DataModel.SolutionDataBaseDB();
            }else{
                db=new Solution.DataAccess.DataModel.SolutionDataBaseDB(connectionString, providerName);
            }
            IRepository<itcast_part> _repo;
            
            if(db.TestMode){
                itcast_part.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<itcast_part>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<itcast_part> GetRepo(){
            return GetRepo("","");
        }
        
        public static itcast_part SingleOrDefault(Expression<Func<itcast_part, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            itcast_part single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static itcast_part SingleOrDefault(Expression<Func<itcast_part, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            itcast_part single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<itcast_part, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<itcast_part, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<itcast_part> Find(Expression<Func<itcast_part, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<itcast_part> Find(Expression<Func<itcast_part, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<itcast_part> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<itcast_part> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<itcast_part> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<itcast_part> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<itcast_part> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<itcast_part> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "Id";
        }

        public object KeyValue()
        {
            return this.Id;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
		//********************************************/
		//  *   修 改 人：PengFei（彭飞）
 //*   修改日期：2017-10-18
		// 修改说明：将整个实体变量名与值生成字符串输出
		//********************************************/
        public override string ToString(){
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

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(itcast_part)){
                itcast_part compare=(itcast_part)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.Id;
        }
        
        public string DescriptorValue()
        {
                            return this.Unit.ToString();
                    }

        public string DescriptorColumn() {
            return "Unit";
        }
        public static string GetKeyColumn()
        {
            return "Id";
        }        
        public static string GetDescriptorColumn()
        {
            return "Unit";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _Id;
		/// <summary>
		/// 
		/// </summary>
        public int Id
        {
            get { return _Id; }
            set
            {
                if(_Id!=value || _isLoaded){
                    _Id=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Id");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Unit;
		/// <summary>
		/// 
		/// </summary>
        public string Unit
        {
            get { return _Unit; }
            set
            {
                if(_Unit!=value || _isLoaded){
                    _Unit=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Unit");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AssemCode;
		/// <summary>
		/// 
		/// </summary>
        public string AssemCode
        {
            get { return _AssemCode; }
            set
            {
                if(_AssemCode!=value || _isLoaded){
                    _AssemCode=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AssemCode");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AssemName;
		/// <summary>
		/// 
		/// </summary>
        public string AssemName
        {
            get { return _AssemName; }
            set
            {
                if(_AssemName!=value || _isLoaded){
                    _AssemName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AssemName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Spec;
		/// <summary>
		/// 
		/// </summary>
        public string Spec
        {
            get { return _Spec; }
            set
            {
                if(_Spec!=value || _isLoaded){
                    _Spec=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Spec");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VehicleModelID;
		/// <summary>
		/// 
		/// </summary>
        public string VehicleModelID
        {
            get { return _VehicleModelID; }
            set
            {
                if(_VehicleModelID!=value || _isLoaded){
                    _VehicleModelID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VehicleModelID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LocationStock;
		/// <summary>
		/// 
		/// </summary>
        public string LocationStock
        {
            get { return _LocationStock; }
            set
            {
                if(_LocationStock!=value || _isLoaded){
                    _LocationStock=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LocationStock");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AssemSourceCode;
		/// <summary>
		/// 
		/// </summary>
        public string AssemSourceCode
        {
            get { return _AssemSourceCode; }
            set
            {
                if(_AssemSourceCode!=value || _isLoaded){
                    _AssemSourceCode=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AssemSourceCode");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RepairPrd;
		/// <summary>
		/// 
		/// </summary>
        public string RepairPrd
        {
            get { return _RepairPrd; }
            set
            {
                if(_RepairPrd!=value || _isLoaded){
                    _RepairPrd=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RepairPrd");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VendorID;
		/// <summary>
		/// 
		/// </summary>
        public string VendorID
        {
            get { return _VendorID; }
            set
            {
                if(_VendorID!=value || _isLoaded){
                    _VendorID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VendorID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ProBatch;
		/// <summary>
		/// 
		/// </summary>
        public string ProBatch
        {
            get { return _ProBatch; }
            set
            {
                if(_ProBatch!=value || _isLoaded){
                    _ProBatch=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProBatch");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime _ProDate;
		/// <summary>
		/// 
		/// </summary>
        public DateTime ProDate
        {
            get { return _ProDate; }
            set
            {
                if(_ProDate!=value || _isLoaded){
                    _ProDate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProDate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ProLocation;
		/// <summary>
		/// 
		/// </summary>
        public string ProLocation
        {
            get { return _ProLocation; }
            set
            {
                if(_ProLocation!=value || _isLoaded){
                    _ProLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ProLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TypeCode;
		/// <summary>
		/// 
		/// </summary>
        public string TypeCode
        {
            get { return _TypeCode; }
            set
            {
                if(_TypeCode!=value || _isLoaded){
                    _TypeCode=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TypeCode");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TypeName;
		/// <summary>
		/// 
		/// </summary>
        public string TypeName
        {
            get { return _TypeName; }
            set
            {
                if(_TypeName!=value || _isLoaded){
                    _TypeName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TypeName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Remark;
		/// <summary>
		/// 
		/// </summary>
        public string Remark
        {
            get { return _Remark; }
            set
            {
                if(_Remark!=value || _isLoaded){
                    _Remark=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Remark");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
				_repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }

        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<itcast_part, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
}

