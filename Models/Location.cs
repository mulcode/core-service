namespace CoreService.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        // public int CompanyId { get; set; }
        public short SortOrder { get; set; }

        // Relation with Parent
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;

        //Relation with Depertment
        public ICollection<Department> Departments {get;} = [];
         public ICollection<CostCenter> CostCenters {get;} = []; 
    }
}