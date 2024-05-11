using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class CostToComDataAccess
    {
        // create method
        public int Create(CostToCom costToCom)
        {
            AppDbContext context = new AppDbContext();
            context.CostToComs.Add(costToCom);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<CostToCom> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.CostToComs.ToList();
        }
        //Get(int id) -> {}
        public CostToCom Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.CostToComs.Where(c => c.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(CostToCom costToCom)
        {
            AppDbContext context = new AppDbContext();
            CostToCom foundCostToCom = context.CostToComs.Where(c => c.Id == costToCom.Id).FirstOrDefault();
            if (foundCostToCom != null)
            {
                foundCostToCom.Name = costToCom.Name;
                foundCostToCom.Code = costToCom.Code;
                foundCostToCom.Description = costToCom.Description;
                foundCostToCom.IsActive = costToCom.IsActive;
                foundCostToCom.IsDeleted = costToCom.IsDeleted;
                foundCostToCom.SortOrder = costToCom.SortOrder;

                context.CostToComs.Update(foundCostToCom);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            CostToCom foundCostToCom = context.CostToComs.Where(c => c.Id == id).FirstOrDefault();
            context.CostToComs.Remove(foundCostToCom);
            context.SaveChanges();
            return true;
        }
    }
}