using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtSylDailyReportingSystem.Comands.Models
{
    class Task
    {
        private static int _taskCounter = 0;
        public int Id { get; set; }
        public string Description { get; set; }

        public Task(string description)
        {
            this.Id = _taskCounter++;
            this.Description = description;
        }
    }
}
