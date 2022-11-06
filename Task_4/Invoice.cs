namespace Task_4
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        private string _article { get; set; }
        private int _quantity { get; set; }

        public int CalculateAccount(string choice)
        {
            if (choice == "y")
            {
                Console.WriteLine("20% NDS was added to your account");
                return account + (account / 5);
            }
            else
                Console.WriteLine("Wrong choice! Default value's return without NDS");

            return account;
        }

        public void Show(string choice, int result)
        {
            if (choice == "y")
                Console.WriteLine($"Your final account with 20% NDS - {result}");
            else
                Console.WriteLine($"Your final account - {result}");

        }

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            _article = article;
            _quantity = quantity;
        }
    }
}
