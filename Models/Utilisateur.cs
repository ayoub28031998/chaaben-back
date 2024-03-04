using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class Utilisateur
    {
        public string NomUtilisateur { get; set; } = null!;
        public string CodeSociete { get; set; } = null!;
        public string CodeFonction { get; set; } = null!;
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string MotDePasse { get; set; } = null!;
        public bool? Actif { get; set; }
        public bool SessionOuvert { get; set; }
        public bool SupperAdmin { get; set; }

        public virtual Fonction CodeFonctionNavigation { get; set; } = null!;
        public virtual Societe CodeSocieteNavigation { get; set; } = null!;
    }
}
