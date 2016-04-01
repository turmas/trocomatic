using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trocomatic.Core.DataContracts;
using Trocomatic.Infrastructure;
namespace Trocomatic.Core
{
	public class TrocomaticManager
	{
		private readonly IChangeProcessorFactory _factory;
		//private readonly ILogger _logger;
		public TrocomaticManager(IChangeProcessorFactory factory)
		{
			IocFactory.Register(
					Component.For<ILogger>()
					.ImplementedBy<FileLogger>()
					.ImplementedBy<EventLogger>()
				);

			this._factory = factory;
			//this._logger = LoggerFactory.GetLogger();
		}

		public GetChangeResponse GetChange(GetChangeRequest request)
		{
			GetChangeResponse response = new GetChangeResponse();

			ILogger _logger = IocFactory.Resolve<ILogger>();

			try
			{
				_logger.Save(request, LogType.Request);
				if (request.IsValid == false)
				{
					response.Reports = request.ValidationReport;
					return response;
				}

				response.TotalChangeAmount = request.PaidAmount - request.ProductAmount;
				response.Details.AddRange(GetChangeDetails(response.TotalChangeAmount));
			}
			catch (Exception ex)
			{
				_logger.Save(ex, LogType.Exception);
				OperationReport report = new OperationReport();
				report.Message = "A operação não foi realizada.";
				report.MessageType = OperationReport.MessageTypeEnum.Error;

				response.Reports.Add(report);
			}
			_logger.Save(response, LogType.Response);
			return response;
		}

		private List<ChangeDetail> GetChangeDetails(long changeAmount)
		{
			List<ChangeDetail> details = new List<ChangeDetail>();

			//Pega o processador de acordo com o valor do troco
			IChangeProcessor processor = _factory.GetProcessor(changeAmount);
			while (changeAmount > 0 && processor != null)
			{
				//Processa o troco
				details.AddRange(processor.GetChange(ref changeAmount));
				//Pega o processador de acordo com o valor restante se existe
				processor = _factory.GetProcessor(changeAmount);
			}
			if (changeAmount > 0)
				throw new Exception("Não é possível dar o troco");

			return details;

		}
	}
}
