﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtSylDailyReportingSystem.Comands.Models
{
    class DailyNote
    {
        public DateTime CameInTime { get; set; }
        public DateTime CameOutTime { get; set; }
        public List<Task> Tasks { get; set; }
    }
}