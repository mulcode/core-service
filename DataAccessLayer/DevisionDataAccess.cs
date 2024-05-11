using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class DevisionDataAccess
    {
        // create method
        public int Create(Devision devision)
        {
            AppDbContext context = new AppDbContext();
            context.Devisions.Add(devision);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<Devision> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Devisions.ToList();
        }
        //Get(int id) -> {}
        public Devision Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Devisions.Where(d => d.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(Devision devision)
        {
            AppDbContext context = new AppDbContext();
            Devision foundDevision = context.Devisions.Where(d => d.Id == devision.Id).FirstOrDefault();
            if (foundDevision != null)
            {
                foundDevision.Name = devision.Name;
                foundDevision.Code = devision.Code;
                foundDevision.Description = devision.Description;
                foundDevision.IsActive = devision.IsActive;
                foundDevision.IsDeleted = devision.IsDeleted;
                foundDevision.SortOrder = devision.SortOrder;

                context.Devisions.Update(foundDevision);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();
            Devision foundDevision = context.Devisions.Where(d => d.Id == id).FirstOrDefault();
            context.Devisions.Remove(foundDevision);
            context.SaveChanges();
            return true;
        }
    }
}