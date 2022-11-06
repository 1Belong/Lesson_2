namespace Add_Task
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly DateTime Created;


        public void Show()
        {
            Console.WriteLine("--User info--\n");
            Console.WriteLine($"Login - {Login}");
            Console.WriteLine($"Name - {FirstName}");
            Console.WriteLine($"Surname - {LastName}");
            Console.WriteLine($"Age - {Age}");
            Console.WriteLine($"Registration date - {Created}");
        }
        
        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;  
            LastName = lastName;
            Age = age;
            Created = DateTime.Today;
        }
    }
}
