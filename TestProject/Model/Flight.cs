﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
    internal class Flight
    {
        public string Id { get; set; }
        public string Airline { get; set; }
        public string Vehicle_id { get; set; }
        public string Org { get; set; }
        public string Dest { get; set; }
        public string Local_depart { get; set; }
        public string Local_arrive { get; set; }
    }
}
