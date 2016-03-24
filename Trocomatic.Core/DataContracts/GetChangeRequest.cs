using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocomatic.Core.DataContracts
{
	public sealed class GetChangeRequest : AbstractRequest
	{
		public GetChangeRequest() { }

		public long PaidAmount { get; set; }

		public long ProductAmount { get; set; }

		protected override void Validate()
		{
			if (this.PaidAmount <= 0)
				this.AddOperationReport("PaidAmount", Messages.TrocomaticManager_ValorPagoInvalido);

			if (this.ProductAmount <= 0)
				this.AddOperationReport("ProductAmount", Messages.TrocomaticManager_ValorProdutoInvalido);

			long changeAmount = this.PaidAmount - this.ProductAmount;

			if (changeAmount < 0)
				this.AddOperationReport("PaidAmount", Messages.TrocomaticManager_ValorPagoInsuficiente);
		}
	}
}
