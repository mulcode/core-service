namespace CoreService.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public short SortOrder { get; set; }

        // Relation with Dependent Child
        public ICollection<Company> Companies { get; } = new List<Company>();
    }
}