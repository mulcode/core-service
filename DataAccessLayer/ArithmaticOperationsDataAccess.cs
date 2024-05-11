using CoreService.DataContext;
using CoreService.Models;


namespace CoreService.DataAccessLayer
{
    public class ArithmaticOperationsDataAccess
    {
        // create method
        public int Create(ArithmaticOperations operations)
        {
            AppDbContext context = new AppDbContext();
            context.ArithmaticOperations.Add(operations);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        //Get = List
        public List<ArithmaticOperations> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.ArithmaticOperations.ToList();
        }
        //Get(int id) -> {}
        public ArithmaticOperations Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.ArithmaticOperations.Where(a => a.Id == id).FirstOrDefault();
        }

        //Put({}) -> 200
        public bool Put(ArithmaticOperations operations)
        {
            AppDbContext context = new AppDbContext();
            ArithmaticOperations foundArithmaticOperations = context.ArithmaticOperations.Where(a => a.Id == operations.Id).FirstOrDefault();
            if (foundArithmaticOperations != null)
            {
                foundArithmaticOperations.Name = operations.Name;
                foundArithmaticOperations.Code = operations.Code;
                foundArithmaticOperations.Description = operations.Description;
                foundArithmaticOperations.OperationType = operations.OperationType;


                context.ArithmaticOperations.Update(foundArithmaticOperations);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        // Delete(int id)
        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            ArithmaticOperations foundArithmaticOperations = context.ArithmaticOperations.Where(a => a.Id == id).FirstOrDefault();
            context.ArithmaticOperations.Remove(foundArithmaticOperations);
            context.SaveChanges();
            return true;
        }
    }
}