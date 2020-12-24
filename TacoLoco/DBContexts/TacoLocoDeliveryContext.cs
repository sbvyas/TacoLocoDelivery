using Microsoft.EntityFrameworkCore;
using TacoLoco.Entities;

namespace TacoLoco.DBContexts
{
	public class TacoLocoDeliveryContext : DbContext
	{		

		public TacoLocoDeliveryContext(DbContextOptions<TacoLocoDeliveryContext> options) : base(options)
		{			
		}

		public DbSet<TacoLocoDelivery> TacoLocoDelivery { get; set; }

      
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         // seed the database with dummy data
         modelBuilder.Entity<TacoLocoDelivery>().HasData(
             new TacoLocoDelivery()
             {
                DeliveryId = 1,
                FirstName = "Shivani",
                LastName = "Vyas",
                StreetAddress1 = "Canton",
                StreetAddress2 = "",
                City = "Canton",
                State = "Michigan",
                ZipCode = 48188,
                PhoneNumber = "1234567890",
                DeliveryStatus = Entities.TacoLocoDelivery.Status.Recieved
             },
             new TacoLocoDelivery()
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
                DeliveryStatus = Entities.TacoLocoDelivery.Status.Shipped
             },
             new TacoLocoDelivery()
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
                DeliveryStatus = Entities.TacoLocoDelivery.Status.Delivered
             },
             new TacoLocoDelivery()
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
                DeliveryStatus = Entities.TacoLocoDelivery.Status.Delivered
             },
             new TacoLocoDelivery()
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
                DeliveryStatus = Entities.TacoLocoDelivery.Status.Shipped
             }            
             );
         base.OnModelCreating(modelBuilder);
      }
      }
}
