using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public class LogInterceptor : IInterceptor
	{
		public void Intercept(IInvocation invocation)
		{
			
			invocation.Proceed();
			
		}
	}
}
