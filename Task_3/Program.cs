using Task_3;

Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();
Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();
Employee employee = new(firstName, lastName);


Console.WriteLine("Choose your post in a company:\n" +
                  "1 - Engineer\n" +
                  "2 - Janitor\n" +
                  "3 - QA\n" +
                  "4 - Manager\n");

string choice = Console.ReadLine();
Employee.Post post = 0;
if (choice == "1")
    post = Employee.Post.Engineer;
else if (choice == "2")
    post = Employee.Post.Janitor;
else if (choice == "3")
    post = Employee.Post.QA;
else if (choice == "4")
    post = Employee.Post.Manager;
else
    Console.WriteLine("Wrong choice! This post doesn't exist in our company");


Console.WriteLine("Enter your work experience: ");
int workExperience = Convert.ToInt32(Console.ReadLine());
double salary = employee.salaryCalculations(workExperience, post);
Console.WriteLine($"Your name: {firstName} {lastName}.\nYour post: {post}.\nYour salary: {salary}.\nYour PDFO from salary: {salary * employee.PDFOCoef}");

