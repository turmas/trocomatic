using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public abstract class AbstractMoneyFactory
	{
		public static List<Money> GetCurrencyAmounts()
		{
			List<Money> list = new List<Money>();
  
			FillList(list, MoneyType.Coin, new long[] { 100, 50, 25, 10, 5, 1 });
			FillList(list, MoneyType.Bill, new long[] { 10000, 5000, 2000, 1000, 500, 200 });		 
		 
			
			return list;
		}

		private static void FillList(List<Money> list, MoneyType type, long[] amounts)
		{
			foreach (long x in amounts)
			{
				list.Add(new Money()
				{
					Amount = x,
					Type = type
				});
			}
		}
	}
}
