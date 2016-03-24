using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public class Coin
	{

		public long Amount { get; private set; }

		public Coin(long amount)
		{
			this.Amount = amount;
		}
	}
}
