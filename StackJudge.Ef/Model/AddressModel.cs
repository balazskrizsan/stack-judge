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

        [Column("full_address")]
        public string FullAddress { get; set; }

        [Column("marker_lat")]
        public Decimal MarkerLat { get; set; }

        [Column("marker_lng")]
        public Decimal MarkerLng { get; set; }

        [Column("manual_marker_lat")]
        public Decimal ManualMarkerLat { get; set; }

        [Column("manual_marker_lng")]
        public Decimal ManualMarkerLng { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}