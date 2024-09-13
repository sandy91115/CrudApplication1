using CrudApplication1.Models;

namespace CrudApplication1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            Employee objEmployee1 = new Employee();

           objEmployee1.Id = 1;
           objEmployee1.Name = "Sundeep";
           objEmployee1.Salary = 50000;
           objEmployee1.City = "Noida";
            

            _employees.Add(objEmployee1);

            _employees.Add(new Employee() {Id=2, Name="Kumar", City = "Greater", Salary = 10000});
            _employees.Add(new Employee() { Id = 3, Name = "Chaudhuri", City = "Greater Noida", Salary = 20000 });

        }

        public List<Employee> GetEmployees()
        {
           return _employees;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _employees.First(emp => emp.Id == emp.Id);
            return employee;
        }

        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            var employee = _employees.First(value => value.Id == emp.Id);
            employee.Name = emp.Name;
            employee.Salary = emp.Salary;
            employee.City = emp.City;


        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.First(emp => emp.Id ==emp.Id);

            _employees.Remove(employee);

        }
    }
}
