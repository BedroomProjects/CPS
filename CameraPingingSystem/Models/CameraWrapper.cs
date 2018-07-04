using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraPingingSystem.Models
{
    class CameraWrapper
    {
        public int ID { get; set; }
        public string IP_ADDRESS { get; set; }
        public string GATE { get; set; }
        public string LANE { get; set; }
        public string BOOTH { get; set; }
        public string SECTOR { get; set; }

        public string ROAD { get; set; }

    }
}
