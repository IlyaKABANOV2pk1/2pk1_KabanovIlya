namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client("Bkb", "fih", "swjugfoi", 145000, CreditStatus.Middle);
            Client cl2 = new Client("asd", "fidfh", "swsdfjugfoi", 556000, CreditStatus.High);
            Client cl3 = new Client("asddf", "dfg", "jhggjhgjh", 142555, CreditStatus.Low);
            Console.WriteLine(cl1);
            Console.WriteLine(cl2);
            Console.WriteLine(cl3);
            cl1.TakeCredit(cl1.Type);
            cl2.TakeCredit(cl2.Type);
            cl3.TakeCredit(cl3.Type);

        }
    }
}