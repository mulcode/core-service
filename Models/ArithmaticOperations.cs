namespace CoreService.Models
{
    public class ArithmaticOperations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string OperationType { get; set; }

        //Relation with CostToComp
        public ICollection<CostToCom> CostToComs { get; set; } = [];
    }
}