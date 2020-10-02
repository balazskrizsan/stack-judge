using System;
using System.ComponentModel;

namespace StackJudgeCore.Company.Entities
{
    public class Address
    {
        [ReadOnly(true)] public int? Id { get; }

        [ReadOnly(true)] public int? CompanyId { get; }

        [ReadOnly(true)] public string FullAddress { get; }

        [ReadOnly(true)] public Decimal MarkerLat { get; }

        [ReadOnly(true)] public Decimal MarkerLng { get; }

        [ReadOnly(true)] public Decimal ManualMarkerLat { get; }

        [ReadOnly(true)] public Decimal ManualMarkerLng { get; }

        [ReadOnly(true)] public DateTime CreatedAt { get; }

        [ReadOnly(true)] public int CreatedBy { get; }

        public Address(
            int? id,
            int? companyId,
            string fullAddress,
            decimal markerLat,
            decimal markerLng,
            decimal manualMarkerLat,
            decimal manualMarkerLng,
            DateTime createdAt,
            int createdBy
        )
        {
            Id = id;
            CompanyId = companyId;
            FullAddress = fullAddress;
            MarkerLat = markerLat;
            MarkerLng = markerLng;
            ManualMarkerLat = manualMarkerLat;
            ManualMarkerLng = manualMarkerLng;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
        }
    }
}