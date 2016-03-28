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

				response.TotalChangeAmount = request.PaidAmount - request.ProductAmount;
				response.Details.AddRange(GetChangeDetails(response.TotalChangeAmount));
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

		private List<ChangeDetail> GetChangeDetails(long changeAmount)
		{
			List<ChangeDetail> details = new List<ChangeDetail>();
			Money[] existingAmounts = AbstractMoneyFactory.GetCurrencyAmounts()
			   .OrderByDescending(x => x.Amount).ToArray();

			int index = 0;


			while (changeAmount > 0 && existingAmounts.Length > index)
			{
				long currentAmount = existingAmounts[index].Amount;
				long quantity = changeAmount / currentAmount;

				if (quantity > 0)
				{

					details.Add(new ChangeDetail()
					{
						Amount = currentAmount,
						MoneyType = existingAmounts[index].Type,
						Quantity = quantity

					});

					changeAmount = changeAmount % currentAmount;
				}

				index = index + 1;
			}
			return details;
		}
	}
}
