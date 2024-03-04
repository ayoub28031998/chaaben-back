using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using API_SurveillenceCommerciale.Models;

namespace API_SurveillenceCommerciale.Context
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Banque> Banques { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<CompteurPiece> CompteurPieces { get; set; } = null!;
        public virtual DbSet<Fonction> Fonctions { get; set; } = null!;
        public virtual DbSet<ImageClient> ImageClients { get; set; } = null!;
        public virtual DbSet<Lettre> Lettres { get; set; } = null!;
        public virtual DbSet<Maitre> Maitres { get; set; } = null!;
        public virtual DbSet<NatureTraite> NatureTraites { get; set; } = null!;
        public virtual DbSet<ParametreDiver> ParametreDivers { get; set; } = null!;
        public virtual DbSet<Rdv> Rdvs { get; set; } = null!;
        public virtual DbSet<SessionJour> SessionJours { get; set; } = null!;
        public virtual DbSet<Societe> Societes { get; set; } = null!;
        public virtual DbSet<Specialite> Specialites { get; set; } = null!;
        public virtual DbSet<TelephoneClient> TelephoneClients { get; set; } = null!;
        public virtual DbSet<TypeRdv> TypeRdvs { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public virtual DbSet<Ville> Villes { get; set; } = null!;
        public virtual DbSet<VueLettre> VueLettres { get; set; } = null!;
        public virtual DbSet<VueListeClientRegle> VueListeClientRegles { get; set; } = null!;
        public virtual DbSet<VueListeImpaye> VueListeImpayes { get; set; } = null!;
        public virtual DbSet<VueListeRdv> VueListeRdvs { get; set; } = null!;
        public virtual DbSet<VueSuivieClient> VueSuivieClients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\sql2014;database=ISS_Traite;User ID=sa;Password=ideal2s;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banque>(entity =>
            {
                entity.HasKey(e => e.MatriculeBanque);

                entity.ToTable("Banque");

                entity.Property(e => e.MatriculeBanque).HasMaxLength(10);

                entity.Property(e => e.LibelleBanque).HasMaxLength(60);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.MatriculeClient);

                entity.ToTable("Client");

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.Adresse).HasMaxLength(2000);

                entity.Property(e => e.Adresse2)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adresse3)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdresseTravail).HasMaxLength(2000);

                entity.Property(e => e.AdresseTravail2)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cadrtrv)
                    .HasMaxLength(50)
                    .HasColumnName("CADRTRV");

                entity.Property(e => e.Cadrtrv1)
                    .HasMaxLength(50)
                    .HasColumnName("CADRTRV1");

                entity.Property(e => e.DateCin)
                    .HasMaxLength(50)
                    .HasColumnName("DateCIN");

                entity.Property(e => e.DateCreation).HasMaxLength(50);

                entity.Property(e => e.DateReglement).HasMaxLength(10);

                entity.Property(e => e.Hist)
                    .HasMaxLength(50)
                    .HasColumnName("HIST");

                entity.Property(e => e.Matdom)
                    .HasMaxLength(50)
                    .HasColumnName("MATDOM");

                entity.Property(e => e.MatriculeBanque).HasMaxLength(10);

                entity.Property(e => e.MatriculeVille).HasMaxLength(10);

                entity.Property(e => e.NumeroCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeroCIN");

                entity.Property(e => e.NumeroCnss)
                    .HasMaxLength(50)
                    .HasColumnName("NumeroCNSS");

                entity.Property(e => e.Observation).HasMaxLength(4000);

                entity.Property(e => e.RaisonSociale).HasMaxLength(2000);

                entity.Property(e => e.RaisonSociale1)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.Reglement).HasMaxLength(10);

                entity.Property(e => e.Ribbancaire)
                    .HasMaxLength(50)
                    .HasColumnName("RIBBancaire");

                entity.Property(e => e.Telephone).HasMaxLength(2000);

                entity.Property(e => e.Telephone2)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TypeClient).HasMaxLength(10);

                entity.Property(e => e.VilleCompte).HasMaxLength(50);
            });

            modelBuilder.Entity<CompteurPiece>(entity =>
            {
                entity.HasKey(e => new { e.CodeSociete, e.NomPiecer });

                entity.ToTable("CompteurPiece");

                entity.Property(e => e.CodeSociete).HasMaxLength(6);

                entity.Property(e => e.NomPiecer)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Annee)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Compteur)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrefixPiece)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Fonction>(entity =>
            {
                entity.HasKey(e => e.CodeFonction);

                entity.ToTable("Fonction");

                entity.Property(e => e.CodeFonction).HasMaxLength(6);

                entity.Property(e => e.Libelle)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ImageClient>(entity =>
            {
                entity.HasKey(e => e.MatriculeClient);

                entity.ToTable("ImageClient");

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.Image1).HasColumnType("image");

                entity.Property(e => e.Image2).HasColumnType("image");

                entity.Property(e => e.Image3).HasColumnType("image");

                entity.Property(e => e.Image4).HasColumnType("image");

                entity.Property(e => e.ImageCin1)
                    .HasColumnType("image")
                    .HasColumnName("ImageCIN1");

                entity.Property(e => e.ImageCin2)
                    .HasColumnType("image")
                    .HasColumnName("ImageCIN2");
            });

            modelBuilder.Entity<Lettre>(entity =>
            {
                entity.HasKey(e => new { e.NumeroLettre, e.Mois });

                entity.ToTable("Lettre");

                entity.Property(e => e.NumeroLettre).HasMaxLength(50);

                entity.Property(e => e.Mois)
                    .HasMaxLength(50)
                    .HasColumnName("MOIS");

                entity.Property(e => e.Acompte1).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte2).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte3).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte4).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte5).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.BordRet1)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET1");

                entity.Property(e => e.BordRet2)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET2");

                entity.Property(e => e.BordRet3)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET3");

                entity.Property(e => e.BordRet4)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BordRet5)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeAval1).HasMaxLength(10);

                entity.Property(e => e.CodeAval2).HasMaxLength(10);

                entity.Property(e => e.CodeAval3).HasMaxLength(10);

                entity.Property(e => e.CodeAval4).HasMaxLength(50);

                entity.Property(e => e.CompteBanquaire).HasMaxLength(50);

                entity.Property(e => e.DateAcompte1).HasMaxLength(50);

                entity.Property(e => e.DateAcompte2).HasMaxLength(50);

                entity.Property(e => e.DateAcompte3).HasMaxLength(50);

                entity.Property(e => e.DateAcompte4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateAcompte5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateBorderau).HasMaxLength(50);

                entity.Property(e => e.DateBorderauAu)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateBorderauDu)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateBorderauRetour).HasMaxLength(50);

                entity.Property(e => e.DateHeureAcompte1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateHeureAcompte2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateHeureAcompte3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateHeureAcompte4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateHeureAcompte5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateHeurePayement)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateLettre).HasMaxLength(50);

                entity.Property(e => e.DatePayement).HasMaxLength(50);

                entity.Property(e => e.Dhamen)
                    .HasMaxLength(500)
                    .HasColumnName("DHAMEN");

                entity.Property(e => e.Echea)
                    .HasMaxLength(10)
                    .HasColumnName("ECHEA");

                entity.Property(e => e.Echeance).HasMaxLength(50);

                entity.Property(e => e.ErrSonia)
                    .HasMaxLength(500)
                    .HasColumnName("ERR_SONIA");

                entity.Property(e => e.Hist)
                    .HasMaxLength(50)
                    .HasColumnName("HIST");

                entity.Property(e => e.Impaye).HasMaxLength(10);

                entity.Property(e => e.Juridique)
                    .HasMaxLength(50)
                    .HasColumnName("JURIDIQUE");

                entity.Property(e => e.MatriculeBanque).HasMaxLength(10);

                entity.Property(e => e.MatriculeClient).HasMaxLength(50);

                entity.Property(e => e.MatriculeVille).HasMaxLength(10);

                entity.Property(e => e.MatriculeVilleAller)
                    .HasMaxLength(10)
                    .HasColumnName("MatriculeVilleALLER");

                entity.Property(e => e.MatriculeVilleClient).HasMaxLength(50);

                entity.Property(e => e.MntInt)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("MNT_INT");

                entity.Property(e => e.MontantFacture).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MontantLettre).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MontantPayee).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Nomcli)
                    .HasMaxLength(100)
                    .HasColumnName("NOMCLI");

                entity.Property(e => e.Numborerr)
                    .HasMaxLength(50)
                    .HasColumnName("NUMBORERR");

                entity.Property(e => e.Numclit)
                    .HasMaxLength(50)
                    .HasColumnName("NUMCLIT");

                entity.Property(e => e.NumeroBorderau).HasMaxLength(10);

                entity.Property(e => e.NumeroBorderauRetour).HasMaxLength(50);

                entity.Property(e => e.NumeroFacture).HasMaxLength(20);

                entity.Property(e => e.NumeroLettreGenerer).HasMaxLength(10);

                entity.Property(e => e.Numreg)
                    .HasMaxLength(50)
                    .HasColumnName("NUMREG");

                entity.Property(e => e.Regle).HasMaxLength(50);

                entity.Property(e => e.Remarque)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remise).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Utilisateur)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Verse)
                    .HasMaxLength(50)
                    .HasColumnName("VERSE");
            });

            modelBuilder.Entity<Maitre>(entity =>
            {
                entity.HasKey(e => e.MatriculeMaitre);

                entity.ToTable("Maitre");

                entity.Property(e => e.MatriculeMaitre).HasMaxLength(10);

                entity.Property(e => e.LibelleMaitre).HasMaxLength(60);
            });

            modelBuilder.Entity<NatureTraite>(entity =>
            {
                entity.HasKey(e => e.CodeNatureTraite);

                entity.ToTable("NatureTraite");

                entity.Property(e => e.CodeNatureTraite).HasMaxLength(10);

                entity.Property(e => e.LibelleNatureTraite).HasMaxLength(50);
            });

            modelBuilder.Entity<ParametreDiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ParametreDiver");

                entity.Property(e => e.Assujetti)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChoixUniteAv).HasColumnName("ChoixUniteAV");

                entity.Property(e => e.CodeClientDetail)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeClientPassager).HasMaxLength(6);

                entity.Property(e => e.CodeCompte)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeFournisseurPassager).HasMaxLength(6);

                entity.Property(e => e.CodeSociete).HasMaxLength(6);

                entity.Property(e => e.DateDebutExercice).HasColumnType("datetime");

                entity.Property(e => e.DateFinExercice).HasColumnType("datetime");

                entity.Property(e => e.DepotAchat).HasMaxLength(6);

                entity.Property(e => e.DepotVente).HasMaxLength(6);

                entity.Property(e => e.ImpressionMatricielle)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MargePerte).HasColumnType("numeric(9, 3)");

                entity.Property(e => e.MargeProfit).HasColumnType("numeric(9, 3)");

                entity.Property(e => e.ModeCalculPrix)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'DPA')");

                entity.Property(e => e.ModeGestionStock)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'FIFO')");

                entity.Property(e => e.MotPasseAdministrateur)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MotPasseModification)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MotPasseSuppression)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreDecimalAchat)
                    .HasColumnType("numeric(9, 0)")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.NombreDecimalVente)
                    .HasColumnType("numeric(9, 0)")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.TauxAvanceImpot)
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TauxFodec).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TauxInteret).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TauxMajoration).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");

                entity.Property(e => e.ValeurStock)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'V')");
            });

            modelBuilder.Entity<Rdv>(entity =>
            {
                entity.HasKey(e => new { e.CodeConserner, e.DateRdv, e.MatriculeClient });

                entity.ToTable("RDV");

                entity.Property(e => e.CodeConserner).HasMaxLength(10);

                entity.Property(e => e.DateRdv)
                    .HasColumnType("datetime")
                    .HasColumnName("DateRDV");

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.CodeNatureTraite)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.HeureCreation).HasColumnType("datetime");

                entity.Property(e => e.NomUtilisateur)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sujet).HasMaxLength(3000);
            });

            modelBuilder.Entity<SessionJour>(entity =>
            {
                entity.HasKey(e => e.DateSession)
                    .HasName("PK_Session");

                entity.ToTable("SessionJour");

                entity.Property(e => e.DateSession).HasMaxLength(50);

                entity.Property(e => e.MontantSession).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.HasKey(e => e.CodeSociete);

                entity.ToTable("Societe");

                entity.Property(e => e.CodeSociete).HasMaxLength(6);

                entity.Property(e => e.Adresse).HasMaxLength(1500);

                entity.Property(e => e.CodeBanque).HasMaxLength(6);

                entity.Property(e => e.CodeCnam)
                    .HasMaxLength(50)
                    .HasColumnName("CodeCNAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeForme)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodePostal).HasMaxLength(10);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .HasColumnName("FAX");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Mail).HasMaxLength(60);

                entity.Property(e => e.MatriculeFiscale).HasMaxLength(20);

                entity.Property(e => e.Observation).HasMaxLength(1500);

                entity.Property(e => e.Pays).HasMaxLength(30);

                entity.Property(e => e.RaisonSociale).HasMaxLength(600);

                entity.Property(e => e.RegistreCommerce).HasMaxLength(20);

                entity.Property(e => e.Responsable).HasMaxLength(60);

                entity.Property(e => e.RibBanquaire)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteWeb).HasMaxLength(60);

                entity.Property(e => e.Tel1).HasMaxLength(30);

                entity.Property(e => e.Tel2).HasMaxLength(30);

                entity.Property(e => e.Ville).HasMaxLength(30);
            });

            modelBuilder.Entity<Specialite>(entity =>
            {
                entity.HasKey(e => e.MatriculeSpecialite);

                entity.ToTable("Specialite");

                entity.Property(e => e.MatriculeSpecialite).HasMaxLength(10);

                entity.Property(e => e.LibelleSpecialite).HasMaxLength(60);
            });

            modelBuilder.Entity<TelephoneClient>(entity =>
            {
                entity.HasKey(e => new { e.MatriculeClient, e.Telephone })
                    .HasName("PK_TelephoneClient_1");

                entity.ToTable("TelephoneClient");

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.Telephone).HasMaxLength(8);
            });

            modelBuilder.Entity<TypeRdv>(entity =>
            {
                entity.HasKey(e => e.MatriculeTypeRdv);

                entity.ToTable("TypeRDV");

                entity.Property(e => e.MatriculeTypeRdv)
                    .HasMaxLength(10)
                    .HasColumnName("MatriculeTypeRDV");

                entity.Property(e => e.LibelleTypeRdv)
                    .HasMaxLength(60)
                    .HasColumnName("LibelleTypeRDV");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.NomUtilisateur);

                entity.ToTable("Utilisateur");

                entity.Property(e => e.NomUtilisateur).HasMaxLength(20);

                entity.Property(e => e.Actif)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodeFonction).HasMaxLength(6);

                entity.Property(e => e.CodeSociete).HasMaxLength(6);

                entity.Property(e => e.MotDePasse)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nom)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CodeFonctionNavigation)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(d => d.CodeFonction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utilisateur_Fonction");

                entity.HasOne(d => d.CodeSocieteNavigation)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(d => d.CodeSociete)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utilisateur_Societe");
            });

            modelBuilder.Entity<Ville>(entity =>
            {
                entity.HasKey(e => e.MatriculeVille);

                entity.ToTable("Ville");

                entity.Property(e => e.MatriculeVille).HasMaxLength(10);

                entity.Property(e => e.LibelleVille).HasMaxLength(60);
            });

            modelBuilder.Entity<VueLettre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VUE_LETTRE");

                entity.Property(e => e.Acompte1).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte2).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte3).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.BordRet1)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET1");

                entity.Property(e => e.BordRet2)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET2");

                entity.Property(e => e.BordRet3)
                    .HasMaxLength(50)
                    .HasColumnName("BORD_RET3");

                entity.Property(e => e.CodeAval1).HasMaxLength(10);

                entity.Property(e => e.CodeAval2).HasMaxLength(10);

                entity.Property(e => e.CodeAval3).HasMaxLength(10);

                entity.Property(e => e.CodeAval4).HasMaxLength(50);

                entity.Property(e => e.CompteBanquaire).HasMaxLength(50);

                entity.Property(e => e.DateAcompte1).HasMaxLength(50);

                entity.Property(e => e.DateAcompte2).HasMaxLength(50);

                entity.Property(e => e.DateAcompte3).HasMaxLength(50);

                entity.Property(e => e.DateBorderau).HasMaxLength(50);

                entity.Property(e => e.DateBorderauRetour).HasMaxLength(50);

                entity.Property(e => e.DateLettre).HasMaxLength(50);

                entity.Property(e => e.DatePayement).HasMaxLength(50);

                entity.Property(e => e.Dhamen)
                    .HasMaxLength(500)
                    .HasColumnName("DHAMEN");

                entity.Property(e => e.Echea)
                    .HasMaxLength(10)
                    .HasColumnName("ECHEA");

                entity.Property(e => e.Echeance).HasMaxLength(50);

                entity.Property(e => e.ErrSonia)
                    .HasMaxLength(500)
                    .HasColumnName("ERR_SONIA");

                entity.Property(e => e.Hist)
                    .HasMaxLength(50)
                    .HasColumnName("HIST");

                entity.Property(e => e.Impaye).HasMaxLength(10);

                entity.Property(e => e.Juridique)
                    .HasMaxLength(50)
                    .HasColumnName("JURIDIQUE");

                entity.Property(e => e.MatriculeBanque).HasMaxLength(10);

                entity.Property(e => e.MatriculeClient).HasMaxLength(50);

                entity.Property(e => e.MatriculeVille).HasMaxLength(10);

                entity.Property(e => e.MatriculeVilleAller)
                    .HasMaxLength(10)
                    .HasColumnName("MatriculeVilleALLER");

                entity.Property(e => e.MatriculeVilleClient).HasMaxLength(50);

                entity.Property(e => e.MntInt)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("MNT_INT");

                entity.Property(e => e.Mois)
                    .HasMaxLength(50)
                    .HasColumnName("MOIS");

                entity.Property(e => e.MontantFacture).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MontantLettre).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MontantPayee).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Nomcli)
                    .HasMaxLength(50)
                    .HasColumnName("NOMCLI");

                entity.Property(e => e.Numborerr)
                    .HasMaxLength(50)
                    .HasColumnName("NUMBORERR");

                entity.Property(e => e.Numclit)
                    .HasMaxLength(50)
                    .HasColumnName("NUMCLIT");

                entity.Property(e => e.NumeroBorderau).HasMaxLength(10);

                entity.Property(e => e.NumeroBorderauRetour).HasMaxLength(50);

                entity.Property(e => e.NumeroFacture).HasMaxLength(20);

                entity.Property(e => e.NumeroLettre).HasMaxLength(50);

                entity.Property(e => e.NumeroLettreGenerer).HasMaxLength(10);

                entity.Property(e => e.Numreg)
                    .HasMaxLength(50)
                    .HasColumnName("NUMREG");

                entity.Property(e => e.RaisonSociale).HasMaxLength(2000);

                entity.Property(e => e.Regle).HasMaxLength(50);

                entity.Property(e => e.Verse)
                    .HasMaxLength(50)
                    .HasColumnName("VERSE");
            });

            modelBuilder.Entity<VueListeClientRegle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vue_ListeClientRegle");

                entity.Property(e => e.Adresse).HasMaxLength(2000);

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.RaisonSociale).HasMaxLength(2000);

                entity.Property(e => e.Telephone).HasMaxLength(2000);

                entity.Property(e => e.Telephone2).HasMaxLength(2000);
            });

            modelBuilder.Entity<VueListeImpaye>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VUE_ListeImpaye");

                entity.Property(e => e.DateLettre).HasMaxLength(50);

                entity.Property(e => e.DateRdv)
                    .HasColumnType("datetime")
                    .HasColumnName("DateRDV");

                entity.Property(e => e.Echeance).HasMaxLength(50);

                entity.Property(e => e.Impaye).HasMaxLength(10);

                entity.Property(e => e.MatriculeClient).HasMaxLength(50);

                entity.Property(e => e.MontantLettre).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Nomcli)
                    .HasMaxLength(100)
                    .HasColumnName("NOMCLI");

                entity.Property(e => e.NumeroLettre).HasMaxLength(50);
            });

            modelBuilder.Entity<VueListeRdv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vue_ListeRDV");

                entity.Property(e => e.CodeConserner).HasMaxLength(10);

                entity.Property(e => e.CodeNatureTraite).HasMaxLength(10);

                entity.Property(e => e.DateRdv)
                    .HasColumnType("datetime")
                    .HasColumnName("DateRDV");

                entity.Property(e => e.LibelleTypeRdv)
                    .HasMaxLength(60)
                    .HasColumnName("LibelleTypeRDV");

                entity.Property(e => e.LibelleVille).HasMaxLength(60);

                entity.Property(e => e.MatriculeClient).HasMaxLength(10);

                entity.Property(e => e.NomUtilisateur).HasMaxLength(20);

                entity.Property(e => e.RaisonSociale).HasMaxLength(2000);

                entity.Property(e => e.Sujet).HasMaxLength(3000);

                entity.Property(e => e.Telephone).HasMaxLength(2000);

                entity.Property(e => e.Telephone2).HasMaxLength(2000);
            });

            modelBuilder.Entity<VueSuivieClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VueSuivieClient");

                entity.Property(e => e.Acompte1).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte2).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Acompte3).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CodeNature)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DatePayement).HasMaxLength(50);

                entity.Property(e => e.Echeance).HasMaxLength(50);

                entity.Property(e => e.Impaye).HasMaxLength(10);

                entity.Property(e => e.Juridique)
                    .HasMaxLength(50)
                    .HasColumnName("JURIDIQUE");

                entity.Property(e => e.MatriculeClient).HasMaxLength(50);

                entity.Property(e => e.Mois)
                    .HasMaxLength(50)
                    .HasColumnName("MOIS");

                entity.Property(e => e.MontantLettre).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MontantPayee).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.NumeroBorderau).HasMaxLength(10);

                entity.Property(e => e.NumeroFacture).HasMaxLength(20);

                entity.Property(e => e.NumeroLettre).HasMaxLength(50);

                entity.Property(e => e.NumeroLettreGenerer).HasMaxLength(10);

                entity.Property(e => e.Regle).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
