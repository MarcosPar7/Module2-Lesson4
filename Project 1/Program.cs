// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Xml.Linq;

Console.WriteLine("Module2Lesson4");

//1.Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
//a.Imię,
//b.Nazwisko
//c.Wiek
//d.Płeć(‘m’ albo ‘k’)
//e.PESEL
//f.Numer pracownika(np. 2509324094)
//Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

string name = "Jan";
string surname = "Nowak";
int age = 25;
string gender = "Male";
string PESEL = "98040499900";
string number = "77";

Console.WriteLine(name);
Console.WriteLine(surname);
Console.WriteLine(age);
Console.WriteLine(gender);
Console.WriteLine(PESEL);
Console.WriteLine(number);

//2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.

string a = "A";
string b = "B";
string c = "C";

Console.WriteLine($"{c} {b} {a}");

//3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

Console.WriteLine("Podaj dlugosc boku A: ");
double rectangleLenght = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj dlugosc boku B: ");
double rectangleHigh = double.Parse(Console.ReadLine());

double diagonal = Math.Sqrt(Math.Pow(rectangleLenght, 2) + Math.Pow(rectangleHigh, 2));
Console.WriteLine($"Dlugosc przekatnej wynosi: {diagonal}");

//4.Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
//a. 10
//b.Szkoła Dotneta
//c. 12,5
//Pamiętaj o użyciu poprawnych typów danych.

int g = 10;

string h = "Szkoła Dotneta";

string i = "12,5";

Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);

//5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85, 7), itp (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).

Console.WriteLine("Prosze podac Twoje dane personalne"); 
Console.WriteLine("Imie: ");
string nameUser = Console.ReadLine();

Console.WriteLine("Nazwisko: ");
string surnameUser = Console.ReadLine();

Console.WriteLine("Nr. telefonu: ");
string phone = Console.ReadLine();

Console.WriteLine("Adres email: ");
string email = Console.ReadLine();

Console.WriteLine("Wzrost: (cm) ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("Waga: (kg) ");
double weight = double.Parse(Console.ReadLine());



