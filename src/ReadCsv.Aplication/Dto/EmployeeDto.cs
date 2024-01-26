using CsvHelper.Configuration.Attributes;

namespace ReadCsv.Aplication.Dto
{
    public class EmployeeDto
    {
        [Name("EmployeeRegisterId")]
        public string EmployeeRegisterId { get; set; }
        [Name("BranchCompanyId")]
        public string BranchCompanyId { get; set; }
        [Name("ContractId")]
        public string ContractId { get; set; }
    }
}
