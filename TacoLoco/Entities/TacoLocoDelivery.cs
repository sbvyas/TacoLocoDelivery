using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TacoLoco.Entities
{
	public class TacoLocoDelivery
	{      
      [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
      public int DeliveryId { get; set; }

      [Required]
      [MaxLength(50)]
      public string FirstName { get; set; }

      [Required]
      [MaxLength(50)]
      public string LastName { get; set; }

      [Required]
      public string StreetAddress1 { get; set; }
            
      public string StreetAddress2 { get; set; }

      [Required]
      public string City { get; set; }

      [Required]
      public string State { get; set; }

      [Required]
      [Range(1, 9999999)]
      public long ZipCode { get; set; }

      [Required]
      public string PhoneNumber { get; set; }

      [Required]
      [JsonConverter(typeof(JsonStringEnumConverter))]
      public Status DeliveryStatus { get; set; }
      public enum Status
      {
         Recieved,
         Shipped,
         Delivered
      }

   }
}
