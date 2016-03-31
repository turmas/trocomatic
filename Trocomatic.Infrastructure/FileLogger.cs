using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;
using Dlp.Framework;
using System.Diagnostics;

namespace Trocomatic.Infrastructure
{
	public class FileLogger : AbstractLogger
	{
		protected override void WriteLog(LogRecord record)
		{
			string filePath = @"C:\Logs\Trocomatic.log";//app.config
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
