using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Juliet.Web.Models
{
    public class PubgSquadTrackerModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public float KdRatio { get; set; }
        public float Top10Ratio { get; set; }
        public float WinLossRatio { get; set; }
    }
}