using Microsoft.AspNetCore.Http;
using ReadCsv.Aplication.Dto;

namespace ReadCsv.Aplication.InterfaceApplications
{
    public interface IEmployeeServiceApplication
    {
        List<EmployeeDto> ReadCsv(IFormFile file);
    }
}
