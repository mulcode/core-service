using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class CostCenterDataAccess
    {
        // create method
        public int Create(CostCenter costCenter)
        {
            AppDbContext context = new AppDbContext();
            context.CostCenters.Add(costCenter);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<CostCenter> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.CostCenters.ToList();
        }
        //Get(int id) -> {}
        public CostCenter Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.CostCenters.Where(c => c.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(CostCenter costCenter)
        {
            AppDbContext context = new AppDbContext();
            CostCenter foundCostCenter = context.CostCenters.Where(c => c.Id == costCenter.Id).FirstOrDefault();
            if (foundCostCenter != null)
            {
                foundCostCenter.Name = costCenter.Name;
                foundCostCenter.Code = costCenter.Code;
                foundCostCenter.Description = costCenter.Description;
                foundCostCenter.IsActive = costCenter.IsActive;
                foundCostCenter.IsDeleted = costCenter.IsDeleted;
                foundCostCenter.SortOrder = costCenter.SortOrder;

                context.CostCenters.Update(foundCostCenter);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            CostCenter foundCostCenter = context.CostCenters.Where(c => c.Id == id).FirstOrDefault();
            context.CostCenters.Remove(foundCostCenter);
            context.SaveChanges();
            return true;
        }
    }
}