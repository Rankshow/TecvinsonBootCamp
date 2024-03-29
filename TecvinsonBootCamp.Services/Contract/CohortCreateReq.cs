﻿namespace TecvinsonBootCamp.Services.Contract
{
    public class CohortCreateReq
    {
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
