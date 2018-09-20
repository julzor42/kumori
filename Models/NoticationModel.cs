using System;

namespace kumori.Models
{
    public class NotificationModel
        {
	        #region General
		        public int Id { get; set; }
			        public string Title { get; set; }
				        public string ClassName { get; set; } = "default";
				        public bool Acked {get; set;} = false;
					        #endregion

        #region Dates
	        public DateTime Created { get; set; } = DateTime.Now;
		        public DateTime Read { get; set; }
			        #endregion
				    }
				    }
				    
