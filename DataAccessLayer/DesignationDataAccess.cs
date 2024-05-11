using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class DesignationDataAccess
    {
        // create method
        public int Create(Designation designation)
        {
            AppDbContext context = new AppDbContext();
            context.Designations.Add(designation);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<Designation> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Designations.ToList();
        }
        //Get(int id) -> {}
        public Designation Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Designations.Where(d => d.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(Designation designation)
        {
            AppDbContext context = new AppDbContext();
            Designation foundDesignation = context.Designations.Where(d => d.Id == designation.Id).FirstOrDefault();
            if (foundDesignation != null)
            {
                foundDesignation.Name = designation.Name;
                foundDesignation.Code = designation.Code;
                foundDesignation.Description = designation.Description;
                foundDesignation.IsActive = designation.IsActive;
                foundDesignation.IsDeleted = designation.IsDeleted;
                foundDesignation.SortOrder = designation.SortOrder;

                context.Designations.Update(foundDesignation);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            Designation foundDesignation = context.Designations.Where(d => d.Id == id).FirstOrDefault();
            context.Designations.Remove(foundDesignation);
            context.SaveChanges();
            return true;
        }
    }
}