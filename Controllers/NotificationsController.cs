using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kumori.Models;
using kumori.Stores;

namespace kumori.Controllers
{
 [Route("api/[controller]")]
     [ApiController]
         public class NotificationsController : ControllerBase
	     {
	             [HttpGet]
		             public IEnumerable<NotificationModel> Get() => NotificationStore.GetNotifications();

        [HttpGet("{id}")]
	        public ActionResult<object> Get(int id) => NotificationStore.GetById(id);

        [HttpGet("ack/{id}")]
	        public ActionResult<string> Ack(int id)
		        {
			            var note = NotificationStore.GetById(id);
				                note.Read = DateTime.Now;
						            return $"ok {id}";
							            }

          [HttpPost("create")]
	        public NotificationModel Post([FromBody] NotificationModel notification)
		        {
              return NotificationStore.Add(notification);
            }
        }
}
