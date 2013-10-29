using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Cliente
    {
        [Key]
        [Column("CD_CLIENTE")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NM_CLIENTE")]
        [Required]
        public string Nome { get; set; }

        [Column("DS_EMAIL")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column("CD_SEXO")]
        [Required]
        public char Sexo { get; set; }

        [Column("VL_SALDO_CREDITO")]
        [Required]
        [DataType(DataType.Currency)]
        [Range(0.00, 100.00)]
        public double Saldo { get; set; }

        [Column("DS_LOGRADOURO")]
        public string Logradouro {get; set;}

        [Column("NR_LOGRADOURO")]
        public int Numero {get;set;}

        [Column("DS_COMPLEMENTO")]
        public string Complemento {get; set; }
        
        [Column("NM_BAIRRO")]
        public string Bairro { get; set; }
        
        [Column("NM_CIDADE")]
        public string Cidade { get; set; }
        
        [Column("SG_ESTADO")]
        public string Estado { get; set; }
        
        [Column("NR_CEP")]
        public string CEP { get; set; }
    }
}