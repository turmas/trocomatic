using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trocomatic.Core.DataContracts;

namespace Trocomatic.Core
{
	public interface IChangeProcessor 
	{
		List<ChangeDetail> GetChange(ref long changeAmount);

		long[] ExistingAmounts { get; }
	}
}
