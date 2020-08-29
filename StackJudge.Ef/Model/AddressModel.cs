using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackJudgeEf.Model
{
    [Table("address")]
    public class AddressModel
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("raw_address")]
        public string RawAddress { get; set; }

        [Column("google_address")]
        public string GoogleAddress { get; set; }

        [Column("pin_long")]
        public Decimal PinLong { get; set; }

        [Column("pin_lat")]
        public Decimal ManualPinLat { get; set; }

        [Column("manual_pin_long")]
        public Decimal ManualPinLong { get; set; }

        [Column("manual_pin_lat")]
        public Decimal PinLat { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}