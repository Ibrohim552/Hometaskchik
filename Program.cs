

using io;
using io.Models;
using io.Services;
using Microsoft.EntityFrameworkCore;

Employee employee=new Employee();

employee.Id=1;
employee.FullName="John Doe";
employee.Department="Yakum";
employee.Salary=50000;


EmploeeServices emploee=new EmploeeServices(new ApplicationContext());

// create
// await emploee.CreateEmployee(employee);

//GEtByID
// Employee io =await emploee.GetEmployeeById(1);
// Console.WriteLine(io.Id);
// Console.WriteLine(io.FullName);
// Console.WriteLine(io.Department);
// Console.WriteLine(io.Salary);
// Console.WriteLine(io.Position);

// Update

// Employee employee2=new Employee();
//
// employee2.Id=1;
// employee2.FullName="Komron Rahimov";
// employee2.Department="Yakum";
// employee2.Salary=50000;
// employee2.Position = "Vrach";
//
// await emploee.UpdateEmployee(employee2);

