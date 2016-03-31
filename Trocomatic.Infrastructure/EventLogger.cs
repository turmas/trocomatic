using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public class EventLogger : AbstractLogger
	{
		protected override void WriteLog(LogRecord record)
		{
			EventLog.WriteEntry("Trocomatic", record.Message);
		}
	}
}
