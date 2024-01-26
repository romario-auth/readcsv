using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using ReadCsv.Aplication.Dto;
using ReadCsv.Aplication.InterfaceApplications;
using System.Globalization;

namespace ReadCsv.Aplication.ServiceApplications
{
    public class EmployeeServiceApplication : IEmployeeServiceApplication
    {
        public EmployeeServiceApplication() { }

        public List<EmployeeDto> ReadCsv(IFormFile file)
        {
            var listEmployee = ConvertToCsv(file);
            return listEmployee;
        }

        private List<EmployeeDto> ConvertToCsv(IFormFile file)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ";"
            };

            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var cvs = new CsvReader(reader, config))
            {
                var listEmployee = cvs.GetRecords<EmployeeDto>().ToList();
                return listEmployee;
            }
        }
    }
}