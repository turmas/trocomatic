using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public class Bill: Money
	{
		public override MoneyType Type
		{
			get { return MoneyType.Bill; }
		}
	}

	public class Coin : Money
	{
		public override MoneyType Type
		{
			get { return MoneyType.Coin; }
		}
	}
}
