using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        public SalesCounter(IEnumerable<Sale> sales) => _sales = sales;

        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new SortedDictionary<string, int>();

            foreach(var sale in _sales)
            {
                if (!dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] = 0;
                }

                dict[sale.ShopName] += sale.Amount;
            }

            return dict;
        }
    }
}
