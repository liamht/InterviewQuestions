using System;
using System.Threading.Tasks;
namespace InterviewQuestions
{
    /// <summary>
    /// What will happen when I execute the DoWork method? write your answer below
    /// 
    /// 
    /// Answer:
    /// 
    /// </summary>
    public class Question9
    {
        private readonly IRepository<DatabaseObject> _database;

        private Question9(IRepository<DatabaseObject> database)
        {
            _database = database;
        }

        public void DoWork()
        {
            var dbObject = GetObjectByIdAsync(5);
            DoMoreWork(dbObject.Result);
        }

        private void DoMoreWork(DatabaseObject obj)
        {
            throw new NotImplementedException();
        }

        private async Task<DatabaseObject> GetObjectByIdAsync(int id)
        {
            var dbObject = await _database.GetObjectFromDatabaseAsync(id);
            return dbObject;
        }

        private interface IRepository<T>
        {
            Task<T> GetObjectFromDatabaseAsync(int id);
        }

        private class DatabaseObject
        {
            public int Id { get; set; }
        }
    }
}
