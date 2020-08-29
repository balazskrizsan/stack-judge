using System;

namespace StackJudge.Requests
{
    public class AddressPostRequest
    {
        public string  RawAddress     { get; set; }
        public string  GoogleAddress  { get; set; }
        public Decimal PingLong       { get; set; }
        public Decimal PingLat        { get; set; }
        public Decimal ManualPingLong { get; set; }
        public Decimal ManualPingLat  { get; set; }
    }
}