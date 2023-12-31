﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models.RabbitMq
{
    public class ConsumeModel
    {
        public long HotelId { get; set; }
        public long ReportId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }

        public string GoogleLocation { get; set; }
    }
}
