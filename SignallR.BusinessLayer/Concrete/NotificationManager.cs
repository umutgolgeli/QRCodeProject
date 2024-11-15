﻿using SignallR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignallR.BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);   
        }

		public void TChangeStatustoFalse(int id)
		{
			_notificationDal.ChangeStatustoFalse(id);
		}

		public void TChangeStatustoTrue(int id)
		{
			_notificationDal.ChangeStatustoTrue(id);
		}

		public void TDelete(Notification entity)
        {
           _notificationDal.Delete(entity); 
        }

		public List<Notification> TGetAllNotificationByFalse()
		{
			return _notificationDal.GetAllNotificationByFalse();
		}

		public Notification TGetByID(int id)
        {
            return _notificationDal.GetByID(id);
        }

        public List<Notification> TGetListAll()
        {
            return _notificationDal.GetListAll();
        }

        public int TNotificationCountByStatusFalse()
        {
           return _notificationDal.NotificationCountByStatusFalse(); 
        }

        public void TUpdate(Notification entity)
        {
           _notificationDal.Update(entity);
        }
    }
}
