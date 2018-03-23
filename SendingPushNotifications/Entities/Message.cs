using System;
using System.Collections.Generic;
using System.Text;

namespace SendingPushNotifications.Entities
{
    public class Message
    {
        public string[] registration_ids { get; set; }
        public Notification notification { get; set; }
        public object data { get; set; }
    }
}
