namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 10000M;
            decimal salary = hourValue * this.HoursWorked;
            return salary;
        }
    }
}