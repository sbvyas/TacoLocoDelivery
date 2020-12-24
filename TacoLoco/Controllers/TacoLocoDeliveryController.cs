using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using TacoLoco.Entities;
using TacoLoco.Services;

namespace TacoLoco.Controllers
{
   [ApiController]
   [Route("api/TacoLocoDelivery")]
   public class TacoLocoDeliveryController : ControllerBase
   {
      private readonly ITacoLocoDeliveryRepo aTacoLocoDeliveryRepo;
      public TacoLocoDeliveryController(ITacoLocoDeliveryRepo TacoLocoDeliveryRepo)
      {
         aTacoLocoDeliveryRepo = TacoLocoDeliveryRepo ??
             throw new ArgumentNullException(nameof(TacoLocoDeliveryRepo));
      }
     
      [HttpGet()]
      public IActionResult GetTacoLocoDeliveries()
      {
         try
         {
            var TacoLocoCustomerDeliveries = aTacoLocoDeliveryRepo.GetTacoLocoDeliveries();
            return Ok(TacoLocoCustomerDeliveries);
         }
         catch 
         {
            return NotFound(HttpStatusCode.NotFound);
         }
      }

      [HttpGet("FirstName/{FirstName}/LastName/{LastName}/ZipCode/{ZipCode}")]
      public IActionResult GetTacoLocoDeliveryRecord(string FirstName, string LastName, long ZipCode)
      {
         try
         {
            var aTacoLocoDeliveryRecord = aTacoLocoDeliveryRepo.GetTacoLocoDeliveryRecord(FirstName, LastName, ZipCode);
            if (aTacoLocoDeliveryRecord == null)
            {
               return NotFound(HttpStatusCode.NotFound);
            }

            return Ok(aTacoLocoDeliveryRecord);
         }
         catch 
         {
            return NotFound(HttpStatusCode.NotFound);
         }
      }

      [HttpDelete("{DeliveryId}")]
      public IActionResult DeleteTacoLocoRecord(int DeliveryId)
      {
         try
         {

            aTacoLocoDeliveryRepo.DeleteTacoLocoDeliveryRecord(DeliveryId);
            return Ok(HttpStatusCode.OK);
         }
         catch
         {

            return NotFound(HttpStatusCode.NotFound);
         }
      }

      [HttpPost]
      public IActionResult AddNewTacoLocoDeliveryRecord(TacoLocoDelivery aTacoLocoDelivery)
      {
         try
         {
            aTacoLocoDeliveryRepo.AddNewTacoLocoDelivery(aTacoLocoDelivery);
            return Ok(HttpStatusCode.Created);
         }
         catch
         {
            return BadRequest();
         }
      }

      [HttpPut]
      public IActionResult UpdateTacoLocoDelivery(TacoLocoDelivery aTacoLocoDelivery)
      {
         try
         {
            if (aTacoLocoDelivery == null)
            {
               return BadRequest();
            }
            else
            {
               aTacoLocoDeliveryRepo.UpdateTacoLocoDelivery(aTacoLocoDelivery);
               return Ok(HttpStatusCode.Created);
            }
         }
         catch 
         {

            return BadRequest();
         }
      }
   }
}