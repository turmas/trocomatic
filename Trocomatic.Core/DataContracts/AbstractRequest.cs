using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public abstract class AbstractRequest
	{
		public AbstractRequest()
		{
			this.ValidationReport = new List<OperationReport>();
		}

		internal bool IsValid {
			get {
				this.ValidationReport.Clear();
				this.Validate();
				return (this.ValidationReport.Any() == false);
			}
		}

		internal List<OperationReport> ValidationReport { get; set; }

		protected abstract void Validate();

		protected void AddOperationReport(string fieldName, string message,
			OperationReport.MessageTypeEnum messageType = OperationReport.MessageTypeEnum.Error)
		{
			OperationReport report = new OperationReport();
			report.FieldName = this.GetType().Name + "." + fieldName;
			report.Message = message;
			report.MessageType = messageType;

			this.ValidationReport.Add(report);
		}
	}
}
