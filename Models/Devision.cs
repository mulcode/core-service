namespace CoreService.Models
{
    public class Devision
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        // public int DepertmentId { get; set; }
        public short SortOrder { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; } = null;
    }
}