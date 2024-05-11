namespace CoreService.Models
{
    public class CostToCom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        // public int ArithId { get; set; }
        public short SortOrder { get; set; }

        //Relation with ArithOps
        public int ArithmaticOperationsId { get; set; }
        public ArithmaticOperations ArithmaticOperations { get; set; } = null;
    }
}