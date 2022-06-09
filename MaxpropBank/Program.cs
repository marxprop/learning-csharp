namespace MaxpropBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matthew", 500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");

            account.MakeWithdrawal(100, DateTime.Now, "Groceries");

            Console.WriteLine("Account Transaction History...");
            Console.WriteLine(account.GetAccountHistory());

            Console.ReadLine();

        }   
    }
}