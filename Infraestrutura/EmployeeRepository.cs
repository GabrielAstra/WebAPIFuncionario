using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Infraestrutura;
using TesteAPI.Model;

namespace TesteAPI.Infraestrutura
{

    
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context?.Employees?.Add(employee);
            _context?.SaveChanges();
        }

        public List<Employee> Get()
        {
            if (_context.Employees != null)
            {
                return _context.Employees.ToList();
            }
            else
            {
                return new List<Employee>();
            }
        }

    }
}