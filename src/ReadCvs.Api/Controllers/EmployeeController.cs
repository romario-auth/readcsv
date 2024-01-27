using Microsoft.AspNetCore.Mvc;
using ReadCsv.Aplication.Dto;
using ReadCsv.Aplication.InterfaceApplications;

namespace ReadCsv.Api.Controllers
{
    [Route("v1/api/[Controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public readonly IEmployeeServiceApplication _employeeServiceApplication;
        public EmployeeController(IEmployeeServiceApplication employeeServiceApplication)
        {
            _employeeServiceApplication = employeeServiceApplication;
        }

        [HttpPost]
        [Route("UploadFile")]
        public List<EmployeeDto> UploadFileCsv(IFormFile file, CancellationToken cancellationToken)
        {
            List<EmployeeDto> listEmployee = _employeeServiceApplication.ReadCsv(file);
            return listEmployee;
        }

        [HttpGet]
        [Route("ping")]
        public IActionResult TestEndPoint()
        {
            return Ok (new { message = "Ok" });
        }
    }
}
