using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    enum CreditStatus { High, Middle, Low }
    internal class Client
    {
        string _name;
        string _surname;
        string _patronymic;

        uint _creditSum;
        int _percent;
        public static int countOfClients = 0;
        public static uint allCredits = 50_000_000;
        public CreditStatus Type = CreditStatus.Low;
        public static uint sumAllCred = 0;
        public static int countCredits = 0;
        public static uint ostatok = allCredits;
        public int Percent
        {
            get => _percent;
            set => _percent = value;
        }



        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    Console.WriteLine("имя не может быть пустым. введите имя ");
                    _name = Console.ReadLine();
                }
                else { _name = value; }
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (value == "")
                {
                    Console.WriteLine("имя компании не может быть пустым. введите имя ");
                    _surname = Console.ReadLine();
                }
                else { _surname = value; }

            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (value == "")
                {
                    Console.WriteLine("имя компании не может быть пустым. введите имя ");
                    _patronymic = Console.ReadLine();
                }
                else { _patronymic = value; }
            }
        }
        public uint CreditSum
        {
            get => _creditSum;
            set
            {
                if (value > 99999 && value < 5000001)
                    _creditSum = value;
                else
                {
                    Console.WriteLine("кредитная сумма должна быть больше 100к рублей и меньше 5 млн рублей");
                    _creditSum = Convert.ToUInt32(Console.ReadLine());
                }

                if (CreditSum > allCredits)
                {
                    Console.WriteLine("В банке нет достаточного количества средств, кредит не может быть одобрен");
                }
                else
                {
                    allCredits = allCredits - _creditSum;
                    sumAllCred = sumAllCred + _creditSum;
                    ostatok = ostatok - _creditSum;
                }

            }
        }

        public void TakeCredit(CreditStatus type)
        {
            if (Type != CreditStatus.Low)
            {
                countCredits++;
                Console.WriteLine("кредит одобрен");
            }
            else
            {
                Console.WriteLine("Вам отказано в кредите.");
            }
        }

        public Client(string name, string surname, string patronymic, uint creditSum, CreditStatus type)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            CreditSum = creditSum;
            Type = type;
            if (Type == CreditStatus.High)
            {
                _percent = 10;
            }
            else if (Type == CreditStatus.Middle)
            {
                _percent = 12;
            }
            else
            {
                Console.WriteLine("слишком низкий кредитный статус.");
            }
            Percent = _percent;
            countOfClients++;
        }



        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} \n" +
                $"сумма кредита: {CreditSum}руб \n" +
                $"кредитный процент: {Percent}% \n" +
                $"кредитный статус: {Type}\n" +
                $"-----------------------------------";
        }
    }
}
