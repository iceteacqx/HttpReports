﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HttpReports.Core.Models
{
    public class ServiceInstanceInfo
    {
        public string Service { get; set; } 

        public string Instance { get; set; } 
     
    }
     
    public class ServiceInstanceInfoModel
    {
        public string Node { get; set; }

        public string LocalIP { get; set; }

        public string LocalPort { get; set; }
    }

}
