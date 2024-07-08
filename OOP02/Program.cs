using OOP02.inheretance;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region indexer
            PhoneBook note = new PhoneBook(2);
            note.AddPerson(0, "madonna", 0123445);
            note["madonna"] = 109876;
            Console.WriteLine(note["madonna"]);
            #endregion
            #region class
            Car c1;
            c1 = new Car(1, "kia");
            Console.WriteLine(c1.ToString());
            #endregion
            #region inheretance 
            Parent p = new Parent(1, 2, 3);
            Console.WriteLine(p.ToString());
            Child c = new Child(4, 5, 6);
            Console.WriteLine(c.ToString());
            #endregion
            #endregion
        }
    }
}
