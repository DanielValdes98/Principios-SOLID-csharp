namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked, extrahours)
        {
        }

        public override decimal CalculateSalary ()
        {   
            decimal hourValue = 40;
            return hourValue * (HoursWorked);
        } 
    }
}