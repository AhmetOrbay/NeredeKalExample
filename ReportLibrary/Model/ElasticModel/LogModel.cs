﻿using Microsoft.Extensions.Logging;

namespace ReportLibrary.Models
{
    public class LogModel
    {
        public LogLevel LogLevel { get; set; }
        public string Messages { get; set; }
        public DateTime LogCreateDate { get; set; }
    }

}
