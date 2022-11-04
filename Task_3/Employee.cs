namespace Task_3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly double PDFOCoef = 0.18;
        public enum Post
        {
            Engineer = 10000,
            Janitor = 5000,
            QA = 7500,
            Manager = 9000
        }

        public double salaryCalculations(int workExperience, Post post)
        {
            if (workExperience > 20)
            {
                switch (post)
                {
                    case Post.Engineer:
                        return (double)post * 2.5;
                    case Post.Janitor:
                        return (double)post * 2.2;
                    case Post.QA:
                        return (double)post * 2.25;
                    case Post.Manager:
                        return (double)post * 2.1;
                    default:
                        Console.WriteLine("This post doesn't exist in our company");
                        break;
                }

            }
            else if (workExperience > 10)
            {
                switch (post)
                {
                    case Post.Engineer:
                        return (double)post * 1.75;
                    case Post.Janitor:
                        return (double)post * 1.7;
                    case Post.QA:
                        return (double)post * 1.7;
                    case Post.Manager:
                        return (double)post * 1.65;
                    default:
                        Console.WriteLine("This post doesn't exist in our company");
                        break;
                }
            }
            else
                Console.WriteLine("Your work experience is too short");
            return (double)post;
        }
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }


}   
