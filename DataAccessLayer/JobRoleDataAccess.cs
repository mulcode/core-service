using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class JobRoleDataAccess
    {
        // create method
        public int Create(JobRoles jobRole)
        {
            AppDbContext context = new AppDbContext();
            context.JobRoles.Add(jobRole);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<JobRoles> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.JobRoles.ToList();
        }
        //Get(int id) -> {}
        public JobRoles Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.JobRoles.Where(j => j.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(JobRoles jobRole)
        {
            AppDbContext context = new AppDbContext();
            JobRoles foundJobRole = context.JobRoles.Where(j => j.Id == jobRole.Id).FirstOrDefault();
            if (foundJobRole != null)
            {
                foundJobRole.Name = jobRole.Name;
                foundJobRole.Code = jobRole.Code;
                foundJobRole.Description = jobRole.Description;
                foundJobRole.IsActive = jobRole.IsActive;
                foundJobRole.IsDeleted = jobRole.IsDeleted;
                foundJobRole.SortOrder = jobRole.SortOrder;

                context.JobRoles.Update(foundJobRole);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            JobRoles foundJobRole = context.JobRoles.Where(j => j.Id == id).FirstOrDefault();
            context.JobRoles.Remove(foundJobRole);
            context.SaveChanges();
            return true;
        }
    }
}