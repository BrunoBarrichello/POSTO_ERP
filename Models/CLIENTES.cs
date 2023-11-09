using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POSTO_ERP.Models
{
    [Table("CLIENTES")]
    public class CLIENTES
    {
        
        [Column("CNPJ_CPF")]
        [Display(Name = "CNPJ / CPF")]
        [Key]
        public string? CNPJ_CPF { get; set; }

        [Column("CLIENTES")]
        [Display(Name = "Código")]
        public int CODIGO { get; set; }

    }
}