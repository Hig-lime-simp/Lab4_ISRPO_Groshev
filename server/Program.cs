
using System.Data;

Console.WriteLine("Привет!");

string? bio = "Грошев Никита Андреевич";
string? group = "ИСП-232";
string? data = "22.01.2026 00:20:56";

string? input = Console.ReadLine();

Console.WriteLine("Меню:");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
switch (input)
{
    case 1:
        Console.WriteLine(bio);
    case 2:
        Console.WriteLine(group);
    case 3:
        Console.WriteLine(data);
    case 4:
        Console.WriteLine("Выход...");
        break;
}