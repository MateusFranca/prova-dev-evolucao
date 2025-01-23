using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BlazorApp.Models.Generic;

namespace BlazorApp.Models
{
    [Table("services")]
    public class Service : Base
    {
        [Required(ErrorMessage = "O nome do serviço é obrigatório.")]
        [Column("name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "O valor sugerido é obrigatório.")]
        [Column("operation_value")]
        public string? OptionValue { get; set; }
        [Column("estimated time")]
        public string? EstimatedTime { get; set; }
        [Column("guarantee")]
        public string? Guarantee { get; set; }
        [Column("type")]
        public string? Type { get; set; }
        [Column("company_id")]
        public Guid CompanyId { get; set; }
    }
}