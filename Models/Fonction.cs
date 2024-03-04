using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class Fonction
    {
        public Fonction()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public string CodeFonction { get; set; } = null!;
        public string Libelle { get; set; } = null!;

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
