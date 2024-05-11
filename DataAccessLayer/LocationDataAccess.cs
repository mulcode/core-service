using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class LocationDataAccess
    {
        // create method
        public int Create(Location location)
        {
            AppDbContext context = new AppDbContext();
            context.Locations.Add(location);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<Location> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Locations.ToList();
        }
        //Get(int id) -> {}
        public Location Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Locations.Where(l => l.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(Location location)
        {
            AppDbContext context = new AppDbContext();
            Location foundLocation = context.Locations.Where(l => l.Id == location.Id).FirstOrDefault();
            if (foundLocation != null)
            {
                foundLocation.Name = location.Name;
                foundLocation.Code = location.Code;
                foundLocation.Description = location.Description;
                foundLocation.IsActive = location.IsActive;
                foundLocation.IsDeleted = location.IsDeleted;
                foundLocation.SortOrder = location.SortOrder;

                context.Locations.Update(foundLocation);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            Location foundLocation = context.Locations.Where(l => l.Id == id).FirstOrDefault();
            context.Locations.Remove(foundLocation);
            context.SaveChanges();
            return true;
        }
    }
}