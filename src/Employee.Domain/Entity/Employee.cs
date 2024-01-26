namespace Employee.Domain.Entity
{
    public class Employee
    {
        public Guid EmployeeRegisterId { get; set; }
        public Guid BranchCompanyId { get; set; }
        public Guid ContractId { get; set; }
    }
}