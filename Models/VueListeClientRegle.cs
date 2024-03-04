using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class VueListeClientRegle
    {
        public string MatriculeClient { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Telephone2 { get; set; } = null!;
        public string RaisonSociale { get; set; } = null!;
    }
}
