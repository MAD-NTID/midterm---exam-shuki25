using System.Collections.Generic;
using System.Threading.Tasks;
using Coinbase.Models;

namespace Coinbase.Repositories
{
    public class CryptoCurrencyRepository: ICryptocurrencyRepository
    {
        public async Task<IEnumerable<Cryptocurrency>> All()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cryptocurrency> Get(int rank)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cryptocurrency> Create(Cryptocurrency cryptocurrency)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cryptocurrency> Update(Cryptocurrency cryptocurrency)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int rank)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<MarketCap>> MarketCap()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cryptocurrency>> Search(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cryptocurrency>> PriceRange(int min, int max)
        {
            throw new System.NotImplementedException();
        }
    }
}