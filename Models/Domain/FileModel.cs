using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test4.Models.Domain
{
    public class FileModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Interface { get; set; }
        public string Nom { get; set; }
        public int Nbligne { get; set; }
        public DateTime Créé { get; set; }
        public string Type { get; set; }
        public string Statut { get; set; }
        public Boolean Pré_execution_succes { get; set; }
        public int Pré_execution_resultat { get; set; }
        public Boolean Pré_execution_echec { get; set; }
        public Boolean Post_execution_succes { get; set; }
        public int Post_execution_resultat { get; set; }
        public Boolean Post_execution_echec { get; set; }
    }
}

