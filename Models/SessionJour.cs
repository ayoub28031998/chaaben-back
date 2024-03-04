using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class SessionJour
    {
        public string DateSession { get; set; } = null!;
        public decimal MontantSession { get; set; }
    }
}
