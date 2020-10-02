using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackJudgeEf.Model
{
    [Table("company")]
    public class CompanyModel
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("company_size_id")]
        public int CompanySize { get; set; }

        [Column("it_size_id")]
        public int ItSize { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}