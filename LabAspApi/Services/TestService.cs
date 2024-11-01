using Dapper;
using LabAspApi.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace LabAspApi.Services
{
    public class TestService
    {
        private readonly IDbConnection _db;

        public TestService(IDbConnection db)
        {
            _db = db;
        }

        public async Task<IEnumerable<TestEntity>> GetTestsAsync()
        {
            var sql = "SELECT * FROM TB_TEST";
            return await _db.QueryAsync<TestEntity>(sql);
        }

        public async Task<TestEntity?> GetTestAsync(int id)
        {
            var sql = "SELECT * FROM TB_TEST WHERE Id = @Id";
            return await _db.QueryFirstOrDefaultAsync<TestEntity>(sql, new { Id = id });
        }

        public async Task<int> CreateTestAsync(TestEntity testEntity)
        {
            var sql = "INSERT INTO TB_TEST (Test) VALUES (@Test); SELECT CAST(SCOPE_IDENTITY() as int)";
            return await _db.QuerySingleAsync<int>(sql, testEntity);
        }

        public async Task<int> UpdateTestAsync(int id, string newTestValue)
        {
            var sql = "UPDATE TB_TEST SET Test = @Test WHERE Id = @Id";
            return await _db.ExecuteAsync(sql, new { Test = newTestValue, Id = id });
        }

        public async Task<int> DeleteTestAsync(int id)
        {
            var sql = "DELETE FROM TB_TEST WHERE Id = @Id";
            return await _db.ExecuteAsync(sql, new { Id = id });
        }
    }
}