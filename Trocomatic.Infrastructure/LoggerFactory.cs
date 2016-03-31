using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Infrastructure
{
	public static class LoggerFactory
	{
		public static ILogger GetLogger()
		{
			string logConfig = GetLogConfig();

			switch (logConfig)
			{
				case "EventViewer": return new EventLogger();

				// Se nao tem configuração, retorna o default
				default: return new FileLogger(); 
			}
		}

		private static string GetLogConfig()
		{
			return System.Configuration.ConfigurationManager.AppSettings["LogType"];
		}
	}
}
