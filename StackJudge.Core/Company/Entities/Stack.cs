using System;
using System.ComponentModel;

namespace StackJudgeCore.Company.Entities
{
    public class Stack
    {
        [ReadOnly(true)]
        public int? Id { get; }

        [ReadOnly(true)]
        public int CompanyId { get; }

        [ReadOnly(true)]
        public int? ParentId { get; }

        [ReadOnly(true)]
        public int TypeId { get; }

        [ReadOnly(true)]
        public string Name { get; }

        [ReadOnly(true)]
        public int MembersOnStackId { get; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; }

        [ReadOnly(true)]
        public int CreatedBy { get; }

        public Stack(
            int? id,
            int companyId,
            int? parentId,
            int typeId,
            string name,
            int membersOnStackId,
            DateTime createdAt,
            int createdBy
        )
        {
            Id = id;
            CompanyId = companyId;
            ParentId = parentId;
            TypeId = typeId;
            Name = name;
            MembersOnStackId = membersOnStackId;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
        }
    }
}
