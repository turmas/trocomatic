using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public class GetChangeResponse
	{
		public GetChangeResponse()
		{
			Coins = new List<Coin>();
			Reports = new List<OperationReport>();
		}
		public List<Coin> Coins { get; set; }

		public long TotalChangeAmount { get; set; }

		public bool Success { get { return Reports.All(x => x.MessageType != OperationReport.MessageTypeEnum.Error); } }
 

		public List<OperationReport> Reports { get; set; }

		public void AddOperationReport(string fieldName, string message,
			OperationReport.MessageTypeEnum messageType = OperationReport.MessageTypeEnum.Error)
		{
			OperationReport report = new OperationReport();
			report.FieldName = fieldName;
			report.Message = message;
			report.MessageType = messageType;

			Reports.Add(report);
		}
	}
}
