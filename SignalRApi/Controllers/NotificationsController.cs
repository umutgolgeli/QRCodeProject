using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignallR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        public readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        } 

        [HttpGet]
        public IActionResult NotificationList() 
		{
            return Ok(_notificationService.TGetListAll());
        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }
		[HttpGet("GetAllNotificationByFalse")]
		public IActionResult GetAllNotificationByFalse()
		{
			return Ok(_notificationService.TGetAllNotificationByFalse());
		}
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto) {
			Notification notification = new Notification()
            {
				Type = createNotificationDto.Type,
				Icon = createNotificationDto.Icon,
				Description = createNotificationDto.Description,
				Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				Status = false

			};
            _notificationService.TAdd(notification);
			return Ok("Ekleme başarıyla  yapıldı");
		}
		
		[HttpDelete("{id}")]
		public IActionResult DeleteNotification(int id)
		{
			var value = _notificationService.TGetByID(id);
			_notificationService.TDelete(value);
			return Ok("Bildirim Alanı Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetAbout(int id)
		{
			var value = _notificationService.TGetByID(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
		{
			Notification notification = new Notification()
			{
				NotificationID = updateNotificationDto.NotificationID,
				Type = updateNotificationDto.Type,
				Icon = updateNotificationDto.Icon,
				Description = updateNotificationDto.Description,
				Date = updateNotificationDto.Date,
				Status = updateNotificationDto.Status
			};

			_notificationService.TUpdate(notification);
			return Ok("Bildirim Alanı Güncellendi");
		}
		
	}
}
