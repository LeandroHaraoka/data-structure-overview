using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureOverview.Queues.CallCenter
{
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Consultant {get; set; }
    }
}