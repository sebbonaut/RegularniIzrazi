using System.Text.RegularExpressions;

Regex reg = new("dan");
Console.WriteLine(reg.IsMatch("Dobar dan"));
Console.WriteLine(reg.IsMatch("Dobar dn"));
Console.WriteLine(reg.IsMatch("Dobar dan", 7));
Console.WriteLine(reg.IsMatch("Dobar dan", 4));
Console.WriteLine(Regex.IsMatch("Hello world", "llo"));

string novi = reg.Replace("Dobar dan danas", "cappuccino", 1);
Console.WriteLine(novi);

string[] dijelovi = Regex.Split("ovo je; neki; tekst", "; ");
Console.WriteLine("Ispis dobivenih dijelova:");
foreach (string dio in dijelovi)
    Console.WriteLine('\t' + dio);

string obrazac1 = @"^[a-zA-Z]{6}$"; //username od tocno 6 slova
string obrazac2 = @"^Bok\s"; //tekst koja pocinje rjecju Bok (pa razmak)
string obrazac3 = @"(\w+)\.(jpg|png|jpeg|gif)$"; //naziv dat sa slikom (.jpg, .png, .jpeg, .gif)
string obrazac4 = @"^www\.[a-zA-Z0-9]{3,20}\.(com|in|org|net)$"; //web-adresa
string obrazac5 = @"^[a-zA-Z0-9\._-]{5,25}@[a-z]{2,12}\.(com|org|co\.in|net)$";
Regex r = new(obrazac5);
while(true)
{
    Console.Write("Unesite e-mail adresu: ");
    if (r.IsMatch(Console.ReadLine()!))
        break;
    else
        Console.WriteLine("Nije ok - pokusajte ponovo!");
}