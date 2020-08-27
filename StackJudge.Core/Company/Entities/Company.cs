namespace StackJudgeCore.Company.Entities
{
    public class Company
    {
        public int?   Id          { get; set; }
        public string Name        { get; set; }
        public int    AddressId   { get; set; }
        public int    CompanySize { get; set; }
        public int    ItSize      { get; set; }
    }
}