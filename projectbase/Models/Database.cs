using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace projectbase.Models
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Trainer>().Wait();
        }

        public Task<List<Trainer>> GetTrainerAsync()
        {
            return _database.Table<Trainer>().ToListAsync();
        }

        public Task<int> SaveTrainerAsync(Trainer trainer)
        {
            if (trainer.ID != 0)
            {
                return _database.UpdateAsync(trainer);
            }
            else
            {
                return _database.InsertAsync(trainer);
            }
            
        }

        public Task<int> DeleteAllTrainerAsync()
        {
            return _database.DeleteAllAsync<Trainer>();
        }
    }
}
