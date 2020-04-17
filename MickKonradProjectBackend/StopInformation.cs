using System;
using System.Collections.Generic;

namespace MickKonradProjectBackend
{
    public class StopInformation
    {
        public string StopId { set; get; }
        public string ErrorCode { set; get; }
        public string ErrorMessage { set; get; }
        public int NumberOfResults { set; get; }
        public string Timestamp { set; get; }
        public List<DueTimes> dueTimes;
 
    }
}