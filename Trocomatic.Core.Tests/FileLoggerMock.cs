using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trocomatic.Infrastructure;

namespace Trocomatic.Core.Tests
{
	public class FileLoggerMock : AbstractLogger
	{
		protected override void WriteLog(LogRecord record)
		{
			string filePath = @"C:\LogsTest\Trocomatic.log";//app.config
			if (Directory.Exists(Path.GetDirectoryName(filePath)) == false)
			{
				Directory.CreateDirectory(Path.GetDirectoryName(filePath));
			}

			using (StreamWriter file =
			new StreamWriter(filePath, true))
			{
				file.WriteLine(record.ToString());
			}
		}
	}
}
