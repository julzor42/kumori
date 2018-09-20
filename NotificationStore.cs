using System;
using System.Collections.Generic;
using System.Linq;
using kumori.Models;

namespace kumori.Stores
{
    public class NotificationStore
        {
	        private static List<NotificationModel> Notifications = new List<NotificationModel>();
		        private static int LastId = 1;

        public static IList<NotificationModel> GetNotifications() => Notifications;

        public static NotificationModel Add(string Title)
	        {
		            lock (Notifications)
			                {
					                var Notification = new NotificationModel { Id = LastId++, Title = Title };
							                Notifications.Add(Notification);
									                return Notification;
											            }
												            }
												            
       public static NotificationModel Add(NotificationModel Model)
       {
         Model.Id = LastId++;
         Notifications.Add(Model);
         return Model;
       } 

        public static NotificationModel GetById(int Id)
	        {
		            var notification = NotificationStore.GetNotifications().SingleOrDefault(x => x.Id == Id);
			                if (notification == null)
					            {
						                    throw new Exception($"Couldn't find notification id {Id}");
								                }

            return notification;
	            }
		        }
			}
