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
		Bill,
		Coin
	}

	public class Money
	{
		public long Amount { get; set; }

		public MoneyType Type { get; set; }
	}
}
