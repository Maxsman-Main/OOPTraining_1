namespace InteractrionOfClasses
{
    class Chief
    {
        private SalaryTable employeesTable;
        
        public Chief()
        {
            employeesTable = new SalaryTable();
        }
        public Chief(SalaryTable employeesTable)
        {
            this.employeesTable = employeesTable;
        }

        public int giveMoney(string employerName)
        {
            return employeesTable.getEmployerIncome(employerName);
        }
    }
}