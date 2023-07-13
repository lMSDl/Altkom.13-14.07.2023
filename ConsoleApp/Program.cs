using System.Globalization;

int a = 1;
int b = 2;
int c = 3;
int d = 4;
//tworzymy tablicę 6 elementową
int[] intArray = { a, b, c, d, 45, 12 };

Console.WriteLine(intArray[2]);
//wybranie ostatniego elementu tablicy
Console.WriteLine(intArray[intArray.Length - 1]);

intArray[2] = 99;
Console.WriteLine(intArray[2]);

//utworzylismy pustą tablicę o rozmiarze 2
//pusta tablica - wypełniona wartościami domyślnymi
intArray = new int[2];

//string to tablica char[]
Console.WriteLine("ala ma kota"[2]);

//zmiana rozmiaru rablicy - powoduje utworzenie nowej na podstawie wskazanej i przepięcie referencji
Array.Resize(ref intArray, 4);
Console.WriteLine(intArray[3]);


//utworzenie nowej pustej listy
List<float> floatList = new List<float>();

floatList.Add(3.14f);
floatList.Add(5f);
floatList.Add(1f);
floatList.Add(7.23f);
floatList.Add(3.2f);

Console.WriteLine(floatList[2]);

//usuwanie wartości 5
floatList.Remove(5);

//usuwanie elementu o index 2
floatList.RemoveAt(2);


floatList = new List<float>() { intArray[0], 13, floatList[2] };
Console.WriteLine(floatList[0]);
Console.WriteLine(floatList[1]);
Console.WriteLine(floatList[2]);

floatList.Clear();

void Numbers()
{
    int a = 11;
    int b = 3;

    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    //przy dzieleniu intów część dzisiętna jest ucinana
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
    c = a % b;
    Console.WriteLine($"{a} % {b} = {c}");

    //c# zachowuje kolejność działań
    c = a + a * a;
    Console.WriteLine($"{a} + {a} * {a} = {c}");
    c = (a + a) * a;
    Console.WriteLine($"({a} + {a}) * {a} = {c}");


    float aa = 11.0f;
    float bb = 3f;
    float cc = aa + bb;
    Console.WriteLine($"{aa} + {bb} = {cc}");
    cc = aa - bb;
    Console.WriteLine($"{aa} - {bb} = {cc}");
    cc = aa * bb;
    Console.WriteLine($"{aa} * {bb} = {cc}");
    cc = aa / bb;
    Console.WriteLine($"{aa} / {bb} = {cc}");

    Console.WriteLine($"int min: {int.MinValue} max: {int.MaxValue}");
    Console.WriteLine($"long min: {long.MinValue} max: {long.MaxValue}");


    Console.WriteLine($"float min: {float.MinValue} max: {float.MaxValue}");
    Console.WriteLine($"double min: {double.MinValue} max: {double.MaxValue}");
    Console.WriteLine($"decimal min: {decimal.MinValue} max: {decimal.MaxValue}");

    //dzielenie int przez float/double/decimal (albo odwrotnie) daje wynik o typie z wyższą precyzją
    Console.WriteLine(11 / 3f);
    Console.WriteLine(11 / 3d);
    Console.WriteLine(11 / 3m);

    //zaokrąglanie
    Console.WriteLine(Math.Round(3f / 2f, 0, MidpointRounding.AwayFromZero));

    //przepelenienie int
    a = int.MaxValue;
    Console.WriteLine(a);
    a = a + 1;
    Console.WriteLine(a);

    long longValue;
    int intValue = int.MaxValue;

    longValue = intValue;

    //rzutowanie
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    //rzutowanie może przekłamać wynik, jęsli wartość jest spoza zakresu typu na który rzutujemy
    longValue = 2 * longValue;
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    longValue = 1000000000000L;
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    double doubleValue = 4.43543d;
    float floatValue = (float)doubleValue;


    string doubleString = doubleValue.ToString();
    Console.WriteLine(doubleString);

    //parsowanie/konwertowanie string na float
    string input = Console.ReadLine();
    floatValue = float.Parse(input);
    floatValue = floatValue + 2;
    Console.WriteLine(floatValue);

    //parsowanie/konwertowanie string na int
    input = Console.ReadLine();
    intValue = int.Parse(input);
    intValue = intValue + 2;
    Console.WriteLine(intValue);
}


void StringDemo()
{
    // C# wspiera przeciążanie funkcji
    // jedna nazwa może być prztpisana do wielu funkcjonalności, jeśli różnią się one parametrami
    Console.WriteLine();
    Console.WriteLine("Hello, World!");
    //średnik oznacza koniec instrukcji


    //deklaracja zmienne lokalnej o typie string i nazwie helloVariabe
    string helloVariable;
    //inicjalizacja zmiennej - pierwsze przypisanie wartości
    helloVariable = "Hello";

    //deklaracja z inicjalizacją
    string worldVariable = "World";
    

    Console.WriteLine(helloVariable);
    Console.WriteLine(worldVariable);


    Console.Write(helloVariable);
    Console.Write(" ");
    Console.WriteLine(worldVariable);

    //przypisanie wartości
    worldVariable = "Students!";
    Console.WriteLine(worldVariable);

    string input = Console.ReadLine();
    //najpierw wykona się część po prawej stronie i zostanie przypisana do lewej
    //intput = intput.ToUpper();
    string upperInput = input.ToUpper();
    Console.WriteLine(input);
    Console.WriteLine(upperInput);

    //łączenie stringów za pomocą operatora +
    string output = helloVariable + " " + input + "!";
    Console.WriteLine(output);

    //łączenie stringów za pomocą string.Format (w nawiasach klamrowych index parametru)
    output = string.Format("{0} {1}!", helloVariable, input);
    Console.WriteLine(output);

    string myFormat = "{1} {0}!";
    output = string.Format(myFormat, helloVariable, input);
    Console.WriteLine(output);

    //string interpolowany
    output = $"{helloVariable} {input}!";
    Console.WriteLine(output);
    output = "{helloVariable} {input}!";
    Console.WriteLine(output);

    output = $"Your input string \"{input}\"\n has \t{input.Length} letters. \\";
    Console.WriteLine(output);

    string filePath = @"\\192.168.10.10\c#\zdania - podstawy programowania.pdf";
    Console.WriteLine(filePath);

    //zasąpienie czięci ciągu znaków - czułe na wielkość liter
    filePath = filePath.Replace("192.168.10.10", "10.0.0.10");
    Console.WriteLine(filePath);

    //zasąpienie czięci ciągu znaków - niezależnie od wielkości liter
    filePath = filePath.Replace("C#", "Java", true, CultureInfo.InvariantCulture);
    Console.WriteLine(filePath);

    //pobieranie fragmentu tekstu od piątego znaku
    filePath = filePath.Substring(5);
    Console.WriteLine(filePath);


    //pobieranie 4 znaków tekstu od piątego znaku
    filePath = filePath.Substring(5, 4);
    Console.WriteLine(filePath);

    string sentence = "ala ma kota";
    sentence = sentence.Substring(0, sentence.Length - 1);
    Console.WriteLine(sentence);
    
    //porównanie stringów
    Console.WriteLine("a" == "A");
    //porównanie z ignorowaniem wielkości liter
    Console.WriteLine(string.Compare("a", "A", true) == 0);
}