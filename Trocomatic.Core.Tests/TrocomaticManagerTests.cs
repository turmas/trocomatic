using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Trocomatic.Core.DataContracts;

namespace Trocomatic.Core.Tests
{
	[TestClass]
	public class TrocomaticManagerTests
	{
		[TestMethod]
		public void GetChangeValorPagoZeradoTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 0;
			request.ProductAmount = 10;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsFalse(resultado.Success);
			Assert.AreEqual(0, resultado.Coins.Count);
			Assert.AreEqual(Messages.TrocomaticManager_ValorPagoInvalido, resultado.Reports.First().Message);
			Assert.AreEqual("GetChangeRequest.PaidAmount", resultado.Reports.First().FieldName);
			Assert.AreEqual(OperationReport.MessageTypeEnum.Error, resultado.Reports.First().MessageType);
		}

		[TestMethod]
		public void GetChangeValorProdutoZeradoTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 10;
			request.ProductAmount = 0;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsFalse(resultado.Success);
			Assert.AreEqual(0, resultado.Coins.Count);
			Assert.AreEqual(Messages.TrocomaticManager_ValorProdutoInvalido, resultado.Reports.First().Message);
			Assert.AreEqual("GetChangeRequest.ProductAmount", resultado.Reports.First().FieldName);
			Assert.AreEqual(OperationReport.MessageTypeEnum.Error, resultado.Reports.First().MessageType);
		}

		[TestMethod]
		public void GetChangeValorPagoNegativoTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = -100;
			request.ProductAmount = 10;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsFalse(resultado.Success);
			Assert.AreEqual(0, resultado.Coins.Count);
			Assert.AreEqual(Messages.TrocomaticManager_ValorPagoInvalido, resultado.Reports.First().Message);
			Assert.AreEqual("GetChangeRequest.PaidAmount", resultado.Reports.First().FieldName);
			Assert.AreEqual(OperationReport.MessageTypeEnum.Error, resultado.Reports.First().MessageType);
		}

		[TestMethod]
		public void GetChangeValorProdutoNegativoTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 10;
			request.ProductAmount = -190;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsFalse(resultado.Success);
			Assert.AreEqual(0, resultado.Coins.Count);
			Assert.AreEqual(Messages.TrocomaticManager_ValorProdutoInvalido, resultado.Reports.First().Message);
			Assert.AreEqual("GetChangeRequest.ProductAmount", resultado.Reports.First().FieldName);
			Assert.AreEqual(OperationReport.MessageTypeEnum.Error, resultado.Reports.First().MessageType);
		}

		[TestMethod]
		public void GetChangeOne100CoinTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 120;
			request.ProductAmount = 20;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsTrue(resultado.Success);
			Assert.AreEqual(1, resultado.Coins.Count);
			Assert.AreEqual(100, resultado.Coins.First().Amount);
		}

		[TestMethod]
		public void GetChangeMultipleCoinsTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 100;
			request.ProductAmount = 25;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsTrue(resultado.Success);
			Assert.AreEqual(2, resultado.Coins.Count);
			Assert.AreEqual(50, resultado.Coins.First().Amount);
			Assert.AreEqual(25, resultado.Coins.Last().Amount);
		}

		[TestMethod]
		public void GetChangeInsufficientPaidAmountTest()
		{
			//Arrange
			TrocomaticManager manager = new TrocomaticManager();
			GetChangeRequest request = new GetChangeRequest();
			request.PaidAmount = 20;
			request.ProductAmount = 120;
			//Act
			GetChangeResponse resultado = manager.GetChange(request);
			//Assert
			Assert.IsFalse(resultado.Success);
			Assert.AreEqual(0, resultado.Coins.Count);
			Assert.AreEqual(Messages.TrocomaticManager_ValorPagoInsuficiente, resultado.Reports.First().Message);
			Assert.AreEqual("GetChangeRequest.PaidAmount", resultado.Reports.First().FieldName);
		}
	}
}