using System.Text.RegularExpressions;

string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&\D])[a-zA-Z\d!@#$%^&*()_\/]{8,}$";

bool isValid = false;

while (!isValid)
{
    Console.Write("Parolu daxil edin: ");
    string password = Console.ReadLine();

    isValid = Regex.IsMatch(password, pattern);

    if (isValid)
    {
        Console.WriteLine("Parol duzgundur.");
    }
    else
    {
        Console.WriteLine("Parol sehvdi. Yeniden daxil edin.");
    }
}