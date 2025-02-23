using System.Data;
using BSmartBackEnd.Core.Interfaces;
using Dapper;
using Microsoft.Extensions.Logging;

namespace BSmartBackEnd.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IDbConnection _dbConnection;
        private readonly ILogger<BaseRepository<T>> _logger;

        public BaseRepository(IDbConnection dbConnection, ILogger<BaseRepository<T>> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }



        public async Task<IEnumerable<T>> ExcuteStoredAndReturnIEnumerableAsync(string storedProcedureName, DynamicParameters? parameters = null)
        {
            try
            {

                return await _dbConnection.QueryAsync<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error executing stored procedure '{storedProcedureName}'");
                throw;
            }
        }
    }
}
