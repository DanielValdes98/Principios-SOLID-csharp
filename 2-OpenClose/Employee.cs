using System.ComponentModel.DataAnnotations;

namespace OpenClose
{
    public abstract class Employee
    {
        // Atributos
        public string? Fullname { get; set; }
        public int HoursWorked { get; set; }
        
        // No tiene como tal una implementación, sino que la implementación la harán las clases que hereden de Employee
        public abstract decimal CalculateSalaryMonthly();
    }
}