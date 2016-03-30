using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trocomatic.Core.DataContracts;

namespace Trocomatic.Core
{
	public class CoinChangeProcessor : IChangeProcessor 
	{
		public List<ChangeDetail> GetChange(ref long changeAmount)
		{
			List<ChangeDetail> details = new List<ChangeDetail>();
			 
		 
			int index = 0;


			while (changeAmount > 0 && ExistingAmounts.Length > index)
			{
				long currentAmount = ExistingAmounts[index];
				long quantity = changeAmount / currentAmount;

				if (quantity > 0)
				{

					details.Add(new ChangeDetail()
					{
						Amount = currentAmount,
						MoneyType = MoneyType.Coin,
						Quantity = quantity

					});

					changeAmount = changeAmount % currentAmount;
				}

				index = index + 1;
			}
			return details;
		}

		public long[] ExistingAmounts { get { return new long[] { 100, 50, 25, 10, 5 }; } }
	}
}
