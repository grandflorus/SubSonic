using System;
using System.Data;

/*
 *   修 改 人：PengFei（彭飞）
 *   修改日期：2017-10-18
* 修改说明：提升subsonic ORMapping的速度
*********************************************/
namespace SubSonic.DataProviders
{
    /// <summary>
    /// 从IDataRecord中读取数据的接口
    /// field 字段名
    /// def 默认值
    /// </summary>
    public interface IReadRecord
    {
        /// <summary>
        /// DataRecord接口
        /// </summary>
        IDataRecord DataRecord { get; set; }
        string get_string(string field);
        string get_string(string field, string def);
        Int32 get_int(string field, Int32? def);
        Int64 get_long(string field, Int32? def);
        bool get_bool(string field, bool? def);
        double get_double(string field, double? def);
        DateTime get_datetime(string field, DateTime? def);
        Decimal get_decimal(string field, Decimal? def);
        Guid get_guid(string field, Guid? def);
        byte get_byte(string field, byte? def);
        byte[] get_bytes(string field, byte[] def);
        short? get_short(string field, short? def);
    }
}
