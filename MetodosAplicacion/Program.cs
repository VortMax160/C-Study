﻿/*
SayHello();

void SayHello()
{
    Console.WriteLine("Hello World!");
}

int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1,100)} ");
    }
    Console.WriteLine("");
}

using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

DisplayTimes(times);

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    AdjustTimes(times);
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    AdjustTimes(times);
}

Console.WriteLine("New Medicine Schedule:");

DisplayTimes(times);

Console.WriteLine();

void DisplayTimes(int [] times)
{
    //Format and display medicine times
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

void AdjustTimes(int [] times) 
{
    // Adjust the times by adding the difference, keeping the value within 24 hours
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}



    if ipAddress consists of 4 numbers
    and
    if each ipAddress number has no leading zeroes
    and
    if each ipAddress number is in range 0 - 255

    then ipAddress is valid

    else ipAddress is invalid

MainAddress ();

void MainAddress(){
    string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
    string[] address;

    foreach (string ip in ipv4Input) 
    {
        address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

        if (ValidateLength(address) && ValidateZeroes(address) && ValidateRange(address)) 
        {
            Console.WriteLine($"{ip} is a valid IPv4 address");
        } 
        else 
        {
            Console.WriteLine($"{ip} is an invalid IPv4 address");
        }
    }
}

bool ValidateLength(string [] address) 
{
    return address.Length == 4;
}

bool ValidateZeroes(string [] address) 
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            return false;
        }   
    }

    return true;
}

bool ValidateRange(string [] address) 
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            return false;
        } 
    }

    return true;
}


Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};


TellFortune();

void TellFortune ()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
	string email = first.Substring(0, 2) + last;
	email = email.ToLower();
	Console.WriteLine($"{email}@{domain}");
}


void Update();

int[] GetEnemyCoordinates(string enemyId);
int[] GetDistanceFromHero(string enemyId);
int[] GetHeroCoordinates();

bool EnemyCanHitHero(string enemyId);
int GetEnemyDamageOutput(string enemyId);
void UpdateHeroHP(int damage);

double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}

int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? resultRead;
    bool validEntry = false;
    do {
        resultRead = Console.ReadLine().Trim().ToUpper();
        if(resultRead != null){
            if(resultRead == "Y")
            {
                return true;
            }
            else if (resultRead == "N")
            {
                return false;
            }
        }
    }
    while (validEntry == false);

    return false;
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int target, int roll)
{  
    string result;
    if(target < roll)
        result = "win";
    else
        result = "lose";
    return ($"You {result}!");
}

//"Proyecto guiado"
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", groups : 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals(pettingZoo);
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals(string [] pettingZoo)
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
    
}

string [,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups,pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[start++];
        }
    }
    
    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/
using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    if(TerminalResized()){
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        shouldExit = true;
    }
    else
    {
        if(PlayerIsSick())
        {
            FreezePlayer();
        }
        else if(PlayerIsFaster()){
            Move(3,false);
        }
        else{
            Move(otherKeysExit : false);
        }
        if(CheckFood()){
            ShowFood();
            ChangePlayer();
        }
        
    }
    if (shouldExit){
        Console.Clear();
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

bool CheckFood(){
    return playerX == foodX && playerY == foodY;

}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

bool PlayerIsSick()
{
    return player.Equals(states[2]);
}

bool PlayerIsFaster()
{
    return player.Equals(states[1]);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= speed; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += speed; 
            break;
		case ConsoleKey.Escape:    
            shouldExit = true; 
            break;
        default:
            shouldExit = otherKeysExit;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

