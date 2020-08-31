using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._2
{
    class Abonent
    {
        internal int idNumber;
        public string lastName;
        public string firstName;
        public string middleName;
        public string adress;
        public string creditCard;
        internal DateTime intTime;
        internal DateTime locTime;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abonent abonent = new Abonent();
            Console.WriteLine("Введите идентификационный номер:");
            abonent.idNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  фамилия:");
            abonent.lastName = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            abonent.firstName = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            abonent.middleName = Console.ReadLine();
            Console.WriteLine("Введите адрес: ");
            abonent.adress = Console.ReadLine();
            Console.WriteLine("Введите номер кредитной карточки: ");
            abonent.creditCard = Console.ReadLine();
            Console.WriteLine("Введите время междугородных переговоров:");
            abonent.intTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите время городских переговоров:");
            abonent.locTime = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(abonent.idNumber);
            Console.WriteLine(abonent.lastName);
            Console.WriteLine(abonent.firstName);
            Console.WriteLine(abonent.middleName);
            Console.WriteLine(abonent.adress);
            Console.WriteLine(abonent.creditCard);
            Console.WriteLine(abonent.intTime);
            Console.WriteLine(abonent.locTime);
            Console.ReadKey();
        }
    }
}
