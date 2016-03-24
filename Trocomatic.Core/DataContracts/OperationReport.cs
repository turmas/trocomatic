using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public class OperationReport
	{
		public enum MessageTypeEnum
		{
			Undefined = 0,
			Error = 1,
			Info = 2
		}

		public MessageTypeEnum MessageType { get; set; }

		public string Message { get; set; }

		public string FieldName { get; set; }
	}
}
