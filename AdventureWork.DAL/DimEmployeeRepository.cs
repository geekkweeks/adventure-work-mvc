using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWork.DAL
{
    public class DimEmployeeRepository : IDimEmployeeRepository, IDisposable
    {
        private AdventureWorksContext _dbContext;
        public DimEmployeeRepository(AdventureWorksContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DimEmployee>> GetEmployeesAsync()
            => await _dbContext.DimEmployees.ToListAsync();


        /// <summary>
        /// Get employee by Id
        /// </summary>
        /// <param name="EmployeeKey"></param>
        /// <returns></returns>
        public async Task<DimEmployee> GetEmployeeByIdAsync(int EmployeeKey)
            => await _dbContext.DimEmployees.FindAsync(EmployeeKey);


        /// <summary>
        /// Delete an employee by id
        /// </summary>
        /// <param name="EmployeeKey"></param>
        public void DeleteEmployeeAsync(int EmployeeKey)
        {
            var employee = _dbContext.DimEmployees.Find(EmployeeKey);
            _dbContext.DimEmployees.Remove(employee);
        }           

        /// <summary>
        /// Add new employee
        /// </summary>
        /// <param name="employee"></param>
        public void InsertEmployeeAsync(DimEmployee employee)
            => _dbContext.DimEmployees.Add(employee);

        /// <summary>
        /// Update an employee
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployeeAsync(DimEmployee employee)
            => _dbContext.Entry(employee).State = EntityState.Modified;

        /// <summary>
        /// Save entity
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
