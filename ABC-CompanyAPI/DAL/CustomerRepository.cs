﻿using ABC_CompanyAPI.BLL;

namespace ABC_CompanyAPI.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //To Add A new Customer to the DataBase
        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }
    }
}
