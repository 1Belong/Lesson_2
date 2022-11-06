using Task_4;

Console.WriteLine("--Default initialization of order--\n");
string customer = "Customer";
string provider = "Abibas";
string article = "Meneziz (shoes)";
int price = 1000;
Console.Write("Enter amount of clothes that you buy: \n");
bool operationCheck = int.TryParse(Console.ReadLine(), out int quantity);
if (operationCheck)
{
    Invoice invoice = new Invoice(account: price * quantity, customer, provider, article, quantity);
    Console.WriteLine("--Order succeed--\n");
    Console.WriteLine("Add NDS to your final account? print: y");
    string choice = Console.ReadLine();
    int result = invoice.CalculateAccount(choice);
    invoice.Show(choice, result);
}
else
    Console.WriteLine("--Order creating denied--\n");



