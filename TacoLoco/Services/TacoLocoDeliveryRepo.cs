using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using TacoLoco.DBContexts;
using TacoLoco.Entities;

namespace TacoLoco.Services
{
	public class TacoLocoDeliveryRepo : ITacoLocoDeliveryRepo, IDisposable
	{
		private readonly TacoLocoDeliveryContext aTacoLocoDeliveryContext;

		public TacoLocoDeliveryRepo(TacoLocoDeliveryContext theTacoLocoCustomerContext)
		{
			aTacoLocoDeliveryContext = theTacoLocoCustomerContext ?? throw new ArgumentNullException(nameof(theTacoLocoCustomerContext));
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				// dispose resources when needed
			}
		}
				
		public IEnumerable<TacoLocoDelivery> GetTacoLocoDeliveries()
		{
			return aTacoLocoDeliveryContext.TacoLocoDelivery.ToList<TacoLocoDelivery>();
		}

		public void DeleteTacoLocoDeliveryRecord(int DeliveryRecordId)
		{			
			var aTacoLocoDeliveryRecord = aTacoLocoDeliveryContext.TacoLocoDelivery.Find(DeliveryRecordId);
			if (aTacoLocoDeliveryRecord == null)
			{
				throw new HttpRequestException("Record not found : " + HttpStatusCode.NotFound);
			}
			else
			{
				aTacoLocoDeliveryContext.TacoLocoDelivery.Remove(aTacoLocoDeliveryRecord);				
				aTacoLocoDeliveryContext.SaveChanges();
			}
		}

		public void AddNewTacoLocoDelivery(TacoLocoDelivery aNewTacoLocoDeliveryRecord)
		{
			aTacoLocoDeliveryContext.TacoLocoDelivery.Add(aNewTacoLocoDeliveryRecord);
			aTacoLocoDeliveryContext.SaveChanges();
		}

		public IEnumerable<TacoLocoDelivery> GetTacoLocoDeliveryRecord(string FirstName, string LastName, long ZipCode)
		{
			var aTacoLocoDeliveryRecord = aTacoLocoDeliveryContext.TacoLocoDelivery
				.Where(i => i.FirstName == FirstName && i.LastName == LastName && i.ZipCode == ZipCode)
				.AsEnumerable<TacoLocoDelivery>();

			return aTacoLocoDeliveryRecord;			
		}

		public void UpdateTacoLocoDelivery(TacoLocoDelivery aTacoLocoDelivery)
		{
			var aUpdatedTacoLocoDeliveryRecord = aTacoLocoDeliveryContext.Update(aTacoLocoDelivery);
			aUpdatedTacoLocoDeliveryRecord.State = EntityState.Modified;
			aTacoLocoDeliveryContext.SaveChanges();
		}
	}
}
