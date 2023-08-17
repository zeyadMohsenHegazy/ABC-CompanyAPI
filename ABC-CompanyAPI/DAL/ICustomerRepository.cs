using ABC_CompanyAPI.BLL;

namespace ABC_CompanyAPI.DAL
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        public Customer GetCustomer(string name);
    }
}
