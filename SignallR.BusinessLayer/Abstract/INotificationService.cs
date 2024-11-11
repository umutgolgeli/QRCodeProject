using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignallR.BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
         int TNotificationCountByStatusFalse();
		List<Notification> TGetAllNotificationByFalse();
        void TChangeStatustoTrue(int id);
		void TChangeStatustoFalse(int id);

	}
}
