using System;
using System.ComponentModel;

namespace StackJudgeCore.Company.Entities
{
    public class Address
    {
        [ReadOnly(true)]
        public int? Id { get; }

        [ReadOnly(true)]
        public int? CompanyId { get; }

        [ReadOnly(true)]
        public string RawAddress { get; }

        [ReadOnly(true)]
        public string GoogleAddress { get; }

        [ReadOnly(true)]
        public Decimal PinLong { get; }

        [ReadOnly(true)]
        public Decimal PinLat { get; }

        [ReadOnly(true)]
        public Decimal ManualPinLong { get; }

        [ReadOnly(true)]
        public Decimal ManualPinLat { get; }

        public Address(
            int? id,
            int? companyId,
            string rawAddress,
            string googleAddress,
            decimal pinLong,
            decimal pinLat,
            decimal manualPinLong,
            decimal manualPinLat
        )
        {
            Id = id;
            CompanyId = companyId;
            RawAddress = rawAddress;
            GoogleAddress = googleAddress;
            PinLong = pinLong;
            PinLat = pinLat;
            ManualPinLong = manualPinLong;
            ManualPinLat = manualPinLat;
        }
    }
}
