using System.ComponentModel.DataAnnotations.Schema;
using BlazorApp.Models.Generic;

namespace BlazorApp.Models
{
    [Table("companies")]
    public class Company : Base
    {
        [Column("reason")]
        public string? Reason { get; set; }

        [Column("cnpj")]
        public string? CNPJ { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}