using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class CompteurPiece
    {
        public string CodeSociete { get; set; } = null!;
        public string NomPiecer { get; set; } = null!;
        public string PrefixPiece { get; set; } = null!;
        public string Annee { get; set; } = null!;
        public string Compteur { get; set; } = null!;
    }
}
