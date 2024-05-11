using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class GroupDataAccess
    {
        // create method
        public int Create(Group group)
        {
            AppDbContext context = new AppDbContext();
            context.Groups.Add(group);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<Group> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Groups.ToList();
        }
        //Get(int id) -> {}
        public Group Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Groups.Where(g => g.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(Group group)
        {
            AppDbContext context = new AppDbContext();
            Group foundGroup = context.Groups.Where(g => g.Id == group.Id).FirstOrDefault();
            if (foundGroup != null)
            {
                foundGroup.Name = group.Name;
                foundGroup.Code = group.Code;
                foundGroup.Description = group.Description;
                foundGroup.IsActive = group.IsActive;
                foundGroup.IsDeleted = group.IsDeleted;
                foundGroup.SortOrder = group.SortOrder;

                context.Groups.Update(foundGroup);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            Group foundGroup = context.Groups.Where(g => g.Id == id).FirstOrDefault();
            context.Groups.Remove(foundGroup);
            context.SaveChanges();
            return true;
        }
    }
}