using OOP02.inheretance;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region indexer
            //PhoneBook note = new PhoneBook(2);
            //note.AddPerson(0, "madonna", 0123445);
            //note["madonna"] = 109876;
            //Console.WriteLine(note["madonna"]);
            #endregion
            #region class
            //Car c1;
            //c1 = new Car(1, "kia");
            //Console.WriteLine(c1.ToString());
            #endregion
            #region inheretance 
            //Parent p = new Parent(1, 2, 3);
            //Console.WriteLine(p.ToString());
            //Child c = new Child(4, 5, 6);
            //Console.WriteLine(c.ToString());
            #endregion
            #endregion
            #region part2
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(10, "mina", SecurityPrivilege.DBA, 11000, new Date(1, 1, 2020), Gender.M);
            employees[1] = new Employee(20, "maha", SecurityPrivilege.guest, 11000, new Date(10, 10, 2023), Gender.F);
            employees[2] = new Employee(30, "omar", (SecurityPrivilege)15, 11000, new Date(1, 12, 2014), Gender.M);

            Employee temp;
            if (employees != null)
            {
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    for (int j = i + 1; j < employees.Length; j++)
                    {
                        employees[j].GetHireDate(out int day01, out int month01, out int year01);
                        employees[i].GetHireDate(out int day02, out int month02, out int year02);
                        if (year01 < year02)
                        {
                            temp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = temp;

                        }
                        else if (year01 == year02 && month01 < month02)
                        {
                            temp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = temp;

                        }
                        else if (year01 == year02 && month01 == month02 && day01 < day02)
                        {
                            temp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = temp;
                        }
                    }

                }
            }
            if (employees != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine(employees[i].ToString());
                }
            }
            //While sorting 0 times Boxing and Unboxing process has occurred

            #endregion
        }
    }
}
