using Microsoft.EntityFrameworkCore;

namespace Coinbase
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {

        }
        
        //The dataset property for the cryptocurrencies
        
        //the dataset property for the APIkeys
    }
}