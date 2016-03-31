using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public class LogRecord
	{
		public DateTime Date { get; set; }
		public string Method { get; set; }
		public string Message { get; set; }
		public LogType Type { get; set; }

		public override string ToString()
		{
			return Date.ToString("dd/MM/yyyy hh:mm:ss") + "-" + Type + "-" + Method
				+ "-" + Message;
		}
	}

	public enum LogType
	{
		Request,
		Response,
		Exception
	}
}
