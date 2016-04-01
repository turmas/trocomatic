using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public interface ILogger
	{
		//void GenerateRequestLog(object request, [CallerMemberName] string methodName = null);
		//void GenerateResponseLog(object request, [CallerMemberName] string methodName = null);
		//void GenerateExceptionLog(Exception ex, [CallerMemberName] string methodName = null);

		void Save(object data, LogType type, [CallerMemberName] string methodName = null);
	}
}
