using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    public class PersonTrackingSummary : BaseModel
    {

        public int TotalPersons { get; set; }
        public int PresentPersons { get; set; }

        public int AbsentPersons { get; set; }

        public int PersonsOnLeave { get; set; }

        public string TrackingDate { get; set; }

    }

}
