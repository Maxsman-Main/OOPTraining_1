using System.Collections.Generic;

namespace InteractrionOfClasses
{
    class SalaryTable
    {
        private Dictionary<string, int> employeesTable;

        public SalaryTable()
        {
            employeesTable = new Dictionary<string, int>();
        }

        public void addEmployer(string name, int income)
        {
            employeesTable.Add(name, income);
        }

        public int getEmployerIncome(string name)
        {
            return employeesTable[name];
        }
    }
}
