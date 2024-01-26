using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using ReadCvs.Entity;

StartReadCsv();

static void StartReadCsv()
{
    DateTime dateStart = DateTime.Now;
    Console.WriteLine("Start read");
    
    ReadCsv();

    DateTime dateEnd = DateTime.Now;
    Console.WriteLine("Finish in: " + (dateEnd - dateStart));
}

static void ReadCsv()
{
    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        HasHeaderRecord = true,
        Delimiter = ";"
    };

    using (var reader = new StreamReader("C:/Users/Romário/source/repos/readcsv/src/ReadCvs.WebConsole/CvsFiles/Results.csv"))
    using (var cvs = new CsvReader(reader, config))
    {
        var employeeStatus = cvs.GetRecords<EmployeeStatus>().ToList();
        PrintCvsResult(employeeStatus);
    }
}


static void PrintCvsResult(List<EmployeeStatus> employeeStatus)
{
    int print = 0;
    foreach (var record in employeeStatus)
    {
        Console.WriteLine($"{print} Employee: {record.EmployeeRegisterId}, BranchCompany: {record.BranchCompanyId}, ContractId: {record.ContractId}");
        print++;
    }
}


