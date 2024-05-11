namespace CoreService.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public short SortOrder { get; set; }


        //Relation with Parent
        public int GroupId { get; set; }
        public Group Group { get; set; } = null;

        //Relation with child
        public List<Location> Locations {get;} = [];

        public ICollection<CostCenter> CostCenters {get;} = []; 
    }
}