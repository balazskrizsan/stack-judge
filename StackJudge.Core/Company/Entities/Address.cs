using System;

namespace StackJudgeCore.Company.Entities
{
    public class Address
    {
        public int?    Id            { get; set; }
        public int     CompanyId     { get; set; }
        public string  RawAddress    { get; set; }
        public string  GoogleAddress { get; set; }
        public Decimal PinLong       { get; set; }
        public Decimal PinLat        { get; set; }
        public Decimal ManualPinLong { get; set; }
        public Decimal ManualPinLat  { get; set; }
    }
}