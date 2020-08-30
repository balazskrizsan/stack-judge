using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackJudgeEf.Model
{
    public class RecursiveStackModel
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("depth")]
        public int Depth { get; set; }

        [Column("path")]
        public string Path { get; set; }
    }
}
