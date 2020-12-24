using System.Collections.Generic;
using TacoLoco.Entities;

namespace TacoLoco.Services
{
	public interface ITacoLocoDeliveryRepo
	{
		IEnumerable<TacoLocoDelivery> GetTacoLocoDeliveries();

		IEnumerable<TacoLocoDelivery> GetTacoLocoDeliveryRecord(string FirstName, string LastName, long ZipCode);

		void DeleteTacoLocoDeliveryRecord(int DeliveryRecordId);
		void AddNewTacoLocoDelivery(TacoLocoDelivery TacoLocoDelivery);

		void UpdateTacoLocoDelivery(TacoLocoDelivery TacoLocoDelivery);
	}
}
