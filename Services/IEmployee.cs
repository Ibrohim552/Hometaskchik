using io.Models;

namespace io.Services;

public interface IEmployee
{
    Task<bool> CreateEmployee(Employee employee);
    Task<bool> UpdateEmployee(Employee employee);
    Task<bool> DeleteEmployee(int id);
    Task<Employee> GetEmployeeById(int id);
    Task<IEnumerable<Employee>> GetEmployees();
    
}