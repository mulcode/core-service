namespace CoreService.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        // public int LocationId { get; set; }
        public short SortOrder { get; set; }

        //Relation with parent(Location)
        public int LocationId { get; set; }
        public Location Location { get; set; } = null;

        //Relation with Devision
        public ICollection<Devision> Devisions { get;} = []; 
    }
}