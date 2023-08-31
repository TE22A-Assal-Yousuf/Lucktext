// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, what's your name");

string name = Console.ReadLine();

Console.WriteLine($"{name} huh. Thats a nice name, what's your favourite game");

string game = Console.ReadLine();

Console.WriteLine($"Really? {game} I have that too! How many hours you got?");

string hours = Console.ReadLine();

Console.WriteLine($"ok {hours}, that's not bad. You got any other games? (yes or no)");

string answer = Console.ReadLine().ToLower();

if(answer == "yes"){
    Console.WriteLine("ok? what games?");
}
else{
    Console.WriteLine("thats not what you where supposed to say");
}

if (answer == "no"){
    Console.WriteLine("so you dont have any games?");
    
    Console.WriteLine("ok i guess thats cool");
}
else{
    Console.WriteLine("thats not what you where supposed to say");
}


string othergames = Console.ReadLine();

Console.WriteLine($"{othergames} oh nice i have that too! For curiosities sake how many games you got total?");

string amountofgames = Console.ReadLine();

Console.WriteLine($"wait did i just hear {amountofgames}, damn.");

Console.WriteLine($"{name} Damn bro so we both play {game} and you have {hours} hours on the game, you also have other games like {othergames} not to mention that you own {amountofgames} games, can we be homies?");

Console.ReadLine();
 