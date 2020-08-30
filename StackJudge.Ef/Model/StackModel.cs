using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackJudgeEf.Model
{
    [Table("stack")]
    public class StackModel
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("type_id")]
        public int TypeId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("members_on_stack_id")]
        public int MembersOnStackId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}
