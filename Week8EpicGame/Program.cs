string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Harry Potter", "Luke SkyWalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };


string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };


string hero = GetRandomValueFRomArray(heroes);
string heroWeapon = GetRandomValueFRomArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFRomArray(villains);
string villainWeapon = GetRandomValueFRomArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");




static string GetRandomValueFRomArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}