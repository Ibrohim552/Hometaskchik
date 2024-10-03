using io.Models;
using Microsoft.EntityFrameworkCore;

namespace io.Services;

public class EmploeeServices(ApplicationContext dbContext):IEmployee
{
    public async Task<bool> CreateEmployee(Employee employee)
    {
        
        dbContext.Employees.Add(employee);
            return  await dbContext.SaveChangesAsync()>0;
    }

    public async Task<bool> UpdateEmployee(Employee employee)
    {
        Employee? existEmployee = await dbContext.Employees.FindAsync(employee.Id);
        if(existEmployee==null) return false;
        existEmployee.FullName = employee.FullName;
        existEmployee.Salary = employee.Salary;
        existEmployee.Department = employee.Department;
       return await dbContext.SaveChangesAsync()>0;


    }

    public async Task<bool> DeleteEmployee(int id)
    {
        Employee employee = dbContext.Employees.Find(id);
        if(employee==null) return false;
        dbContext.Employees.Remove(employee);
        return await dbContext.SaveChangesAsync()>0;
    }

    public async Task<Employee> GetEmployeeById(int id)
    {
        return await dbContext.Employees.FindAsync(id);
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await dbContext.Employees.ToListAsync();
    }
}