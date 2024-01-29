namespace PZ_18_2
{
    internal class Program
    {
        //ФИО студента: Кабанов Илья, Арзамасцев Даниил
      //номер варианта: 5 вариант.
        static void Main(string[] args)
        {
            Client cl1 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client.BankInfo();
            cl1.ClientInfo();
            Client cl2 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl3 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl4 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl5 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl6 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl7 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl8 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl9 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);
            Client cl10 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);

            Client cl11 = new Client("kfjks ksmkvj ksjk", 5000000, CreditStatus.Middle);


            cl11.TakeCredit();
        }
    }
}
