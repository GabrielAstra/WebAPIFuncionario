using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteAPI.Model;
using TesteAPI.ViewModel;
using TesteAPI.Infraestrutura;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add(EmployViewModel employeeView)
        {
            if (employeeView == null)
            {
                return BadRequest("Dados inválidos");
            }

            if (string.IsNullOrEmpty(employeeView.Nome))
            {
                return BadRequest("O nome do funcionário é obrigatório.");
            }

            var employee = new Employee(employeeView.Nome, employeeView.Idade, null!); // Adicionando o operador 'null!' para indicar que o valor é não nulo.
            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Employees = _employeeRepository.Get();
            return Ok(Employees);
        }
    }
}
