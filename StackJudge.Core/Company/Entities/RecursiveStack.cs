using System.ComponentModel;

namespace StackJudgeCore.Company.Entities
{
    public class RecursiveStack
    {
        [ReadOnly(true)]
        public int Id { get; }

        [ReadOnly(true)]
        public string Name { get; }

        [ReadOnly(true)]
        public int? ParentId { get; }

        [ReadOnly(true)]
        public int Depth { get; }

        [ReadOnly(true)]
        public string Path { get; }

        public RecursiveStack(int id, string name, int? parentId, int depth, string path)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
            Depth = depth;
            Path = path;
        }
    }
}
