using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18_2
{
    enum CreditStatus { High, Middle, Low }
    internal class Client
    {
        string _fio;

        uint _creditSum;
        int _procent = 0;
        public static int countOfClients = 0;

        CreditStatus status;
        public static uint sumAllCred = 0;
        public static int countCredits = 0;
        bool isCredit = true;

        public string Fio
        {
            get => _fio;
            set
            {
                if (value == "")
                {
                    Console.Write("ФИО не может быть пустым. Введите корректные инициалы: ");
                    _fio = Console.ReadLine();
                }
                else
                {
                    _fio = value;
                }
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
            }
        }

        public void TakeCredit()
        {
            if (status == CreditStatus.Low)
            {
                Console.WriteLine("В кредите отказано");
            }
            else if (isCredit == true)
            {
                int percent = 0;
                switch (status)
                {
                    case CreditStatus.High:
                        {
                            percent = 10;
                            break;
                        }
                    case CreditStatus.Middle:
                        {
                            percent = 12;
                            break;
                        }
                }
                _procent = percent;
                Console.WriteLine($"Кредит выдан под {percent}%");
                countCredits++;
            }


        }

        public Client(string fio, uint creditSum, CreditStatus type)
        {
            Fio = fio;
            CreditSum = creditSum;
            status = type;

            countOfClients++;
            if (sumAllCred + _creditSum > 50000000)
            {
                Console.WriteLine("В банке недостаточно средств для выдачи кредита. Отказ в кредите");
                isCredit = false;
            }
            else
            {
                sumAllCred += _creditSum;
            }
        }

        public static void BankInfo()
        {
            Console.WriteLine($"Сумма выданная клиентам:{sumAllCred}\nКол-во выданных кредитов:{countCredits}\nОстаток суммы на кредиты: {50_000_000 - sumAllCred}");
        }

        public void ClientInfo()
        {
            Console.WriteLine($"{Fio} \n" +
                $"сумма кредита: {CreditSum}руб \n" +
                $"кредитный статус: {status}\n" +
                $"-----------------------------------");
        }
    }
}
