 
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
    /// A class which represents the supplier_info table in the SolutionDataBase Database.
    /// </summary>
    public partial class supplier_info: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<supplier_info> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<supplier_info>(new Solution.DataAccess.DataModel.SolutionDataBaseDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<supplier_info> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(supplier_info item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                supplier_info item=new supplier_info();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<supplier_info> _repo;
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
        public supplier_info(string connectionString, string providerName) {

            _db=new Solution.DataAccess.DataModel.SolutionDataBaseDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                supplier_info.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<supplier_info>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public supplier_info(){
			_db=new Solution.DataAccess.DataModel.SolutionDataBaseDB();
            Init();            
        }

		public void ORMapping(IDataRecord dataRecord)
        {
            IReadRecord readRecord = SqlReadRecord.GetIReadRecord();
            readRecord.DataRecord = dataRecord;   
               
            Id = readRecord.get_int("Id",null);
               
            supplier_code = readRecord.get_string("supplier_code",null);
               
            supplier_name = readRecord.get_string("supplier_name",null);
               
            supplier_connecter = readRecord.get_string("supplier_connecter",null);
               
            supplier_phone = readRecord.get_string("supplier_phone",null);
               
            supplier_address = readRecord.get_string("supplier_address",null);
               
            supplier_distance = readRecord.get_string("supplier_distance",null);
               
            supplier_product = readRecord.get_string("supplier_product",null);
               
            supplier_account = readRecord.get_string("supplier_account",null);
               
            supplier_type = readRecord.get_string("supplier_type",null);
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

        public supplier_info(Expression<Func<supplier_info, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<supplier_info> GetRepo(string connectionString, string providerName){
            Solution.DataAccess.DataModel.SolutionDataBaseDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Solution.DataAccess.DataModel.SolutionDataBaseDB();
            }else{
                db=new Solution.DataAccess.DataModel.SolutionDataBaseDB(connectionString, providerName);
            }
            IRepository<supplier_info> _repo;
            
            if(db.TestMode){
                supplier_info.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<supplier_info>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<supplier_info> GetRepo(){
            return GetRepo("","");
        }
        
        public static supplier_info SingleOrDefault(Expression<Func<supplier_info, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            supplier_info single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static supplier_info SingleOrDefault(Expression<Func<supplier_info, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            supplier_info single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<supplier_info, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<supplier_info, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<supplier_info> Find(Expression<Func<supplier_info, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<supplier_info> Find(Expression<Func<supplier_info, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<supplier_info> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<supplier_info> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<supplier_info> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<supplier_info> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<supplier_info> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<supplier_info> GetPaged(int pageIndex, int pageSize) {
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
			sb.Append("supplier_code=" +　supplier_code + "; ");
			sb.Append("supplier_name=" +　supplier_name + "; ");
			sb.Append("supplier_connecter=" +　supplier_connecter + "; ");
			sb.Append("supplier_phone=" +　supplier_phone + "; ");
			sb.Append("supplier_address=" +　supplier_address + "; ");
			sb.Append("supplier_distance=" +　supplier_distance + "; ");
			sb.Append("supplier_product=" +　supplier_product + "; ");
			sb.Append("supplier_account=" +　supplier_account + "; ");
			sb.Append("supplier_type=" +　supplier_type + "; ");
			return sb.ToString();
        }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(supplier_info)){
                supplier_info compare=(supplier_info)obj;
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
                            return this.supplier_code.ToString();
                    }

        public string DescriptorColumn() {
            return "supplier_code";
        }
        public static string GetKeyColumn()
        {
            return "Id";
        }        
        public static string GetDescriptorColumn()
        {
            return "supplier_code";
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

        string _supplier_code;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_code
        {
            get { return _supplier_code; }
            set
            {
                if(_supplier_code!=value || _isLoaded){
                    _supplier_code=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_code");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_name;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_name
        {
            get { return _supplier_name; }
            set
            {
                if(_supplier_name!=value || _isLoaded){
                    _supplier_name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_connecter;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_connecter
        {
            get { return _supplier_connecter; }
            set
            {
                if(_supplier_connecter!=value || _isLoaded){
                    _supplier_connecter=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_connecter");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_phone;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_phone
        {
            get { return _supplier_phone; }
            set
            {
                if(_supplier_phone!=value || _isLoaded){
                    _supplier_phone=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_phone");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_address;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_address
        {
            get { return _supplier_address; }
            set
            {
                if(_supplier_address!=value || _isLoaded){
                    _supplier_address=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_address");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_distance;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_distance
        {
            get { return _supplier_distance; }
            set
            {
                if(_supplier_distance!=value || _isLoaded){
                    _supplier_distance=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_distance");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_product;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_product
        {
            get { return _supplier_product; }
            set
            {
                if(_supplier_product!=value || _isLoaded){
                    _supplier_product=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_product");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_account;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_account
        {
            get { return _supplier_account; }
            set
            {
                if(_supplier_account!=value || _isLoaded){
                    _supplier_account=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_account");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _supplier_type;
		/// <summary>
		/// 
		/// </summary>
        public string supplier_type
        {
            get { return _supplier_type; }
            set
            {
                if(_supplier_type!=value || _isLoaded){
                    _supplier_type=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="supplier_type");
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


        public static void Delete(Expression<Func<supplier_info, bool>> expression) {
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

