using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWork.DAL
{
    public interface IDimEmployeeRepository : IDisposable
    {
        /// <summary>
        /// Get All employee
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DimEmployee>> GetEmployeesAsync();

        /// <summary>
        /// Get an employee by id
        /// </summary>
        /// <param name="EmployeeKey"></param>
        /// <returns></returns>
        Task<DimEmployee> GetEmployeeByIdAsync(int EmployeeKey);

        /// <summary>
        /// Add new employee record
        /// </summary>
        /// <param name="employee"></param>
        void InsertEmployeeAsync(DimEmployee employee);

        /// <summary>
        /// Delete an employee
        /// </summary>
        /// <param name="EmployeeKey"></param>
        void DeleteEmployeeAsync(int EmployeeKey);

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="employee"></param>
        void UpdateEmployeeAsync(DimEmployee employee);

        /// <summary>
        /// Save entity
        /// </summary>
        Task SaveAsync();
    }
}
