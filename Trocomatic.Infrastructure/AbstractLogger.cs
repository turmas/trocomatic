using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public abstract class AbstractLogger : ILogger
	{
		public void GenerateExceptionLog(Exception ex,
	[CallerMemberName] string methodName = null)
		{
			WriteLog(new LogRecord()
			{
				Type = LogType.Exception,
				Message = ex.ToString(),
				Method = methodName,
				Date = DateTime.Now

			});
		}
		public void GenerateRequestLog(object request,
			[CallerMemberName] string methodName = null)
		{
			string logData = Serializer.JsonSerialize(request);

			WriteLog(new LogRecord()
			{
				Type = LogType.Request,
				Message = logData,
				Method = methodName,
				Date = DateTime.Now

			});
		}
		public void GenerateResponseLog(object request,
			[CallerMemberName] string methodName = null)
		{

			string logData = Serializer.JsonSerialize(request);

			WriteLog(new LogRecord()
			{
				Type = LogType.Response,
				Message = logData,
				Method = methodName,
				Date = DateTime.Now

			});
		}

		protected abstract void WriteLog(LogRecord record);

		public void Save(object data, LogType type, string methodName = null)
		{
			if (data is Exception) {
				data = data.ToString();
			}

			string logData = Serializer.JsonSerialize(data);

			WriteLog(new LogRecord()
			{
				Type = type,
				Message = logData,
				Method = methodName,
				Date = DateTime.Now
			});
		}
	}
}
