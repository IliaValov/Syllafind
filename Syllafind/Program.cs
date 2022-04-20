
//using Syllafind.Service;
//using Syllafind.Service.Models;
//var filter = new WordFilter();
//Console.Write("Enter word length: ");
//filter.Length = int.Parse(Console.ReadLine());
//Console.Write("Word starts with: ");
//filter.StartsWith = char.Parse(Console.ReadLine());
//Console.Write("Word ends with: ");
//filter.EndsWith = char.Parse(Console.ReadLine());
//Console.Write("Enter characters which the words may contain: ");
//var conatainsCharacters = Console.ReadLine();
//if (!string.IsNullOrEmpty(conatainsCharacters))
//{
//    filter.ContainsCharacters = conatainsCharacters.Split(' ').Select(char.Parse).ToList();
//}
//Console.Write("Enter characters which the words does not contain: ");
//var doesNotContainCharacters = Console.ReadLine();
//if (!string.IsNullOrEmpty(doesNotContainCharacters))
//{
//    filter.DoesNotContainCharacters = doesNotContainCharacters.Split(' ').Select(char.Parse).ToList();
//}
//while (true)
//{
//    Console.WriteLine("Enter symbol which the word contains");
//    Console.WriteLine("Type END to stop this ...");
//    Console.Write("Enter symbol: ");
//    string command = Console.ReadLine();
//    if (command == "END")
//    {
//        break;
//    }
//    var symbol = new Symbol();
 
//    symbol.Character = char.Parse(command);
//    Console.Write("Enter symbol position: ");
//    symbol.Position = int.Parse(Console.ReadLine());

//    filter.Symbols.Add(symbol);
//}

//var wordFinderAlgorithm = new WordFinderAlgorithm();
//var result = wordFinderAlgorithm.FindWords(filter);

//Console.WriteLine();
//Console.WriteLine(String.Join("\r\n", result));