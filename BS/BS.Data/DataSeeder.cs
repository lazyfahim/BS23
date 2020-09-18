using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BS.Data
{
    public abstract class DataSeeder
    {
        protected readonly DbContext _dbContext;

        public DataSeeder(DbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public abstract Task SeedAsync();

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }

}
