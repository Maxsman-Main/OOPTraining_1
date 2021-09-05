using System;

namespace InteractrionOfClasses
{
    class Program
    {
        public static void Main()
        {
            SalaryTable table = new SalaryTable();
            Chief chief = new Chief(table);
            Driver driver = new Driver("Victor", chief);
            table.addEmployer(driver.getName(), 200);
            for (int i = 0; i < 6; ++i)
            {
                driver.startWork();
            }
            Console.WriteLine(driver.getCash());
        }
    }
}