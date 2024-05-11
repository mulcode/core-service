using CoreService.DataContext;
using CoreService.Models;

namespace CoreService.DataAccessLayer
{
    public class CompanyDataAccess
    {
        public int Create(Company company)
        {
            AppDbContext context = new AppDbContext();
            context.Companies.Add(company);
            int rowAffected = context.SaveChanges();
            return rowAffected;
        }
        public List<Company> Get()
        {
            AppDbContext context = new AppDbContext();
            return context.Companies.ToList();
        }
        public Company Get(int id)
        {
            AppDbContext context = new AppDbContext();
            return context.Companies.Where(c => c.Id == id).FirstOrDefault();
        }
        public bool Put(Company company)
        {
            AppDbContext context = new AppDbContext();
            Company foundCompany = context.Companies.Where(c => c.Id == company.Id).FirstOrDefault();
            if (foundCompany != null)
            {
                foundCompany.Name = company.Name;
                foundCompany.Code = company.Code;
                foundCompany.Description = company.Description;
                foundCompany.IsActive = company.IsActive;
                foundCompany.IsDeleted = company.IsDeleted;
                foundCompany.SortOrder = company.SortOrder;

                context.Companies.Update(foundCompany);
                context.SaveChanges();
                return true;
            }
            return false;

        }

        public bool Delete(int id)
        {
            AppDbContext context = new AppDbContext();
            Company foundCompany = context.Companies.Where(c => c.Id == id).FirstOrDefault();
            context.Companies.Remove(foundCompany);
            return true;
        }
    }
}