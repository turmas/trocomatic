using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trocomatic.Core.DataContracts;

namespace Trocomatic.Core
{
	public class TrocomaticManager
	{
		public GetChangeResponse GetChange(GetChangeRequest request)
		{
			GetChangeResponse response = new GetChangeResponse();

			try
			{
				if (request.IsValid == false)
				{
					response.Reports = request.ValidationReport;
					return response;
				}

				long changeAmount = request.PaidAmount - request.ProductAmount;

				List<Coin> coins = new List<Coin>();
				long[] amounts = new long[] { 100, 50, 25, 10, 5, 1 };
				int index = 0;
				response.TotalChangeAmount = changeAmount;
				while (changeAmount > 0)
				{
					long currentAmount = amounts[index];
					long quantity = changeAmount / currentAmount;

					if (quantity > 0)
					{
						for (long i = 0; i < quantity; i++)
						{
							coins.Add(new Coin(currentAmount));
						}
						changeAmount = changeAmount % currentAmount;
					}

					index = index + 1;
				}
				response.Coins = coins;	
			}
			catch (Exception)
			{
				OperationReport report = new OperationReport();
				report.Message = "A operação não foi realizada.";
				report.MessageType = OperationReport.MessageTypeEnum.Error;

				response.Reports.Add(report);
			}
			return response;
		}
	}
}
