using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TacoLoco.Controllers;
using TacoLoco.Entities;

namespace TacoLocoTest
{
	[TestClass]
	public class TestTacoLocoDeliveryController
	{
		[TestMethod]
		public void GetTacoLocoDeliveries_ShouldReturnAllTacoLocoDeliveries()
		{
			var aTestdeliveries = GetTestAllTacoLocoDeliveries();        
         //Assert.IsNotNull(result);
         //Assert.AreEqual(2, result.Count());

      }

		private List<TacoLocoDelivery> GetTestAllTacoLocoDeliveries()
		{
			var aTestTacoLocoDeliveryList = new List<TacoLocoDelivery>();
         aTestTacoLocoDeliveryList.Add(new TacoLocoDelivery {
            DeliveryId = 1,
            FirstName = "Shivani",
            LastName = "Vyas",
            StreetAddress1 = "Canton",
            StreetAddress2 = "",
            City = "Canton",
            State = "Michigan",
            ZipCode = 48188,
            PhoneNumber = "1234567890",
            DeliveryStatus = TacoLoco.Entities.TacoLocoDelivery.Status.Recieved
         });

         aTestTacoLocoDeliveryList.Add(new TacoLocoDelivery()
         {
            DeliveryId = 2,
            FirstName = "Bob",
            LastName = "Arnold",
            StreetAddress1 = "Lauree Ville Dr",
            StreetAddress2 = "House Number 1103",
            City = "Detroit",
            State = "Michigan",
            ZipCode = 48100,
            PhoneNumber = "1568217890",
            DeliveryStatus = TacoLoco.Entities.TacoLocoDelivery.Status.Shipped
         });
         aTestTacoLocoDeliveryList.Add(new TacoLocoDelivery()
         {
            DeliveryId = 3,
            FirstName = "John",
            LastName = "Smith",
            StreetAddress1 = "Queens Ln",
            StreetAddress2 = "Apt Honeycomb Circle, 1212",
            City = "Canton",
            State = "Michigan",
            ZipCode = 48188,
            PhoneNumber = "1234567890",
            DeliveryStatus = TacoLoco.Entities.TacoLocoDelivery.Status.Delivered
         });
         aTestTacoLocoDeliveryList.Add(new TacoLocoDelivery()
         {
            DeliveryId = 4,
            FirstName = "Steve",
            LastName = "Jobs",
            StreetAddress1 = "McLumpha Dr",
            StreetAddress2 = "House # 1001",
            City = "Los Angeles",
            State = "California",
            ZipCode = 57814,
            PhoneNumber = "9997845896",
            DeliveryStatus = TacoLoco.Entities.TacoLocoDelivery.Status.Delivered
         });
         aTestTacoLocoDeliveryList.Add(new TacoLocoDelivery()
         {
            DeliveryId = 5,
            FirstName = "Bill",
            LastName = "Gates",
            StreetAddress1 = "Mountain View Ln",
            StreetAddress2 = "House # 007",
            City = "San Francisco",
            State = "California",
            ZipCode = 415205,
            PhoneNumber = "8833052351",
            DeliveryStatus = TacoLoco.Entities.TacoLocoDelivery.Status.Shipped
         });
         return aTestTacoLocoDeliveryList;
		}
	}
}
