using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_EF_CRUD_PostgreSQL.Models
{
    [Table("Candidate", Schema = "public")]
    public class Candidate  //property,Model,Entity
    {
        [Key]
        public int candidateId { get; set; }   //PrimaryKey
        [Required]
        public string CandidateName { get; set; }  // not null
        public string Email { get; set; }
        public int MobileNumber { get; set; }
    }
}