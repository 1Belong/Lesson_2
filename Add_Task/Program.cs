using Add_Task;

Console.WriteLine("--User creation--\n");
Console.WriteLine("Enter your login: ");
string? login = Console.ReadLine();
Console.WriteLine("Enter your name: ");
string? firstName = Console.ReadLine();
Console.WriteLine("Enter your surname: ");
string? lastName = Console.ReadLine();
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

User user = new(login, firstName, lastName, age);
user.Show();