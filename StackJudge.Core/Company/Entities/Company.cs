using System;
using System.ComponentModel;

namespace StackJudgeCore.Company.Entities
{
    public class Company
    {
        [ReadOnly(true)]
        public int? Id { get; }

        [ReadOnly(true)]
        public string Name { get; }

        [ReadOnly(true)]
        public int AddressId { get; }

        [ReadOnly(true)]
        public int CompanySize { get; }

        [ReadOnly(true)]
        public int ItSize { get; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; }

        [ReadOnly(true)]
        public int CreatedBy { get; }

        public Company(
            int? id,
            string name,
            int addressId,
            int companySize,
            int itSize,
            DateTime createdAt,
            int createdBy
        )
        {
            Id = id;
            Name = name;
            AddressId = addressId;
            CompanySize = companySize;
            ItSize = itSize;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
        }
    }
}
