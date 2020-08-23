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
        [Column("country")]
        public string Country { get; set; }
        [Column("city")]
        public string City { get; set; }
    }
}