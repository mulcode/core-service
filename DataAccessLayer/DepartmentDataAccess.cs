using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class DepartmentDataAccess
    {
        // create method
        public int Create(Department department)
        {
            AppDbContext context = new AppDbContext();
            context.Departments.Add(department);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<Department> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Departments.ToList();
        }
        //Get(int id) -> {}
        public Department Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Departments.Where(d => d.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(Department department)
        {
            AppDbContext context = new AppDbContext();
            Department foundDepartment = context.Departments.Where(d => d.Id == department.Id).FirstOrDefault();
            if (foundDepartment != null)
            {
                foundDepartment.Name = department.Name;
                foundDepartment.Code = department.Code;
                foundDepartment.Description = department.Description;
                foundDepartment.IsActive = department.IsActive;
                foundDepartment.IsDeleted = department.IsDeleted;
                foundDepartment.SortOrder = department.SortOrder;

                context.Departments.Update(foundDepartment);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            Department foundDepartment = context.Departments.Where(d => d.Id == id).FirstOrDefault();
            context.Departments.Remove(foundDepartment);
            context.SaveChanges();
            return true;
        }
    }
}