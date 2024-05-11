namespace CoreService.Models
{
    public class CostCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        // public int CompanyId { get; set; }
        // public int LocationId { get; set; }
        public short SortOrder { get; set; }

        //Relation with Company && Location
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}