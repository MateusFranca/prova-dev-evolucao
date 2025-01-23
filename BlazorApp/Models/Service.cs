using System.ComponentModel.DataAnnotations.Schema;
using BlazorApp.Models.Generic;

namespace BlazorApp.Models
{
    [Table("services")]
    public class Service : Base
    {
        [Column("name")]
        public string? Name { get; set; }
        [Column("operation_value")]
        public string? OptionValue { get; set; }
        [Column("estimated time")]
        public string? EstimatedTime { get; set; }
        [Column("guarantee")]
        public string? Guarantee { get; set; }
        [Column("type")]
        public string? Type { get; set; }
    }
}