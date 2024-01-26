using CsvHelper.Configuration.Attributes;

namespace ReadCvs.Entity
{
    public class EmployeeStatus
    {
        [Name("EmployeeRegisterId")]
        public string EmployeeRegisterId { get; set; }
        [Name("BranchCompanyId")]
        public string BranchCompanyId { get; set; }
        [Name("ContractId")]
        public string ContractId { get; set; }
    }
}