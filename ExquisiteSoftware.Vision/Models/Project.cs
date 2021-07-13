using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExquisiteSoftware.Vision.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public FeeType FeeType { get; set; }
        public decimal Fee { get; set; }
        public decimal MaximumFees { get; set; }
    }

    public enum FeeType
    {
        FlatRate,
        Hourly
    }
}