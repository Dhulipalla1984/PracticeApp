using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.SolidPrinciples
{
    public class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public decimal Pay { get; set; }
    }
    public class EmployeeReport
    {
        private Employee _employee;
        public EmployeeReport(Employee employee)
        {
            _employee = employee;
        }
        public string GenerateReportContent()
        {
            return $"Employee: {_employee.Name}, Hours: {_employee.HoursWorked}, Pay: {_employee.Pay}";
        }
    }
    public class ReportPrinter
    {
        public void Print(string content)
        {
            // Print logic here
            Console.WriteLine($"Report Printed: {content}");
        }
    }
    public class ReportPDFSaver
    {
        public void SaveAsPDF(string content, string filePath)
        {
            // PDF saving logic here
            Console.WriteLine($"Report Saved as PDF, content: {content} and Path: {filePath}");
        }
    }


}
