using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public enum MoneyType
	{
		Undefided = 0,
		Silver,
		Bill,
		Coin,
		Candy
	}

	public abstract class Money
	{
		public long Amount { get; set; }

		public abstract MoneyType Type { get;  }
	}
}
