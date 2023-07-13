using System.Globalization;
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
}