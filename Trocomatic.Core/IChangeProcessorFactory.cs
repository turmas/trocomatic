using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core
{
	public interface IChangeProcessorFactory
	{
		IChangeProcessor GetProcessor(long changeAmount);
	}

	public class ChangeProcessorFactory : IChangeProcessorFactory
	{
		public IChangeProcessor GetProcessor(long changeAmount)
		{
			//Pega todas as classes que implementam IChangeProcessor		 
			var processors = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(s => s.GetTypes())
				.Where(p => typeof(IChangeProcessor).IsAssignableFrom(p) && !p.IsInterface).
				Select(x => Activator.CreateInstance(x));
			//Ordena os processadores pelo maior valor minimo existente
			foreach (IChangeProcessor processor in processors.OrderByDescending(x => 
				((IChangeProcessor)x).ExistingAmounts.Min()))
			{
				if(changeAmount > processor.ExistingAmounts.Min())
					return processor;
			}

			return null;
		}
	}
}
