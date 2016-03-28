using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public class ChangeDetail
	{
		public long Quantity { get; set; }
		public long Amount { get; set; }
		public MoneyType MoneyType { get; set; }
	}
}
