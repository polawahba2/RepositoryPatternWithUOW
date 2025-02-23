using Dapper;

namespace BSmartBackEnd.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public  Task<IEnumerable<T>> ExcuteStoredAndReturnIEnumerableAsync(string StoredProcedureName, DynamicParameters? parameters = null);
    }
}