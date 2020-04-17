using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MickKonradProjectBackend
{
    public class DueTimes
    {
        public string Arrivalstring { set; get; }
        public string DueTime { set; get; }
        public string Departuestring { set; get; }
        public string DepartueDueTime { set; get; }
        public string ScheduledArrivalstring { set; get; }
        public string ScheduledDeparturestring { set; get; }
        public string Destination { set; get; }
        public string DestinationLocalized { set; get; }
        public string Origin { set; get; }
        public string Direction { set; get; }
        public string Operator { set; get; }
        public string OperatorType { set; get; }
        public string AdditionalInformation { set; get; }
        public string LowFloorStatus { set; get; }
        public string Route { set; get; }
        public string SourceTimeStamp { set; get; }
        public string Monitored { set; get; }
    }
}
