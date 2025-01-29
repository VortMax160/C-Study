/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

string pangram = "The quick brown fox jumps over the lazy dog.";
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

int saleAmount = 1001;
//  int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

for (int i = 0; i < 5; i++)
{
    Random moneda = new Random();
    Console.WriteLine((moneda.Next(0,2) == 1) ? "Heads" : "Tails");
}
*/
/*
string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin")){
    if(level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
    else 
    Console.WriteLine("Welcome, Admin user.");
}
else 
    if(permission.Contains("Manager") && level > 20)
        Console.WriteLine("Contact an Admin for access.");
    else
        Console.WriteLine("You do not have sufficient privileges.");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]){
case "01":
    type = "Sweat shirt";
    break;
case "02":
    type = "T-Shirt";
    break;
case "03":
    type = "Sweat pants";
    break;
default:
    type = "Other";
    break;
}

switch (product[1]){
case "BL":
    color = "Black";
    break;
case "MN":
    color = "Maroon";
    break;
default:
    color = "White";
    break;
}

switch (product[2]){
case "S":
    size = "Small";
    break;
case "M":
    size = "Medium";
    break;
case "L":
    size = "Large";
    break;
default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

for (int i = 1; i < 101; i++)
{
    string termino = "";
    if(i%3 == 0) termino = "- Fizz";
    if(i%5 == 0) termino = termino == "" ? "- Buzz" : termino + "Buzz";

    Console.WriteLine($"{i} {termino}");
}

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);


// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);


string? resultadoLectura;
int valorNumerico = 0;
bool entradaValida = false;
Console.WriteLine("Ingrese un valor entre 5 y 10 de entero: ");

do
{ 
    resultadoLectura = Console.ReadLine();
    entradaValida = int.TryParse(resultadoLectura, out valorNumerico);
    if (entradaValida == false) {
        Console.WriteLine("Lo siento, usted ingreso un numero invalido, intentelo de nuevo.");
        continue;
    }

    if(valorNumerico > 5 && valorNumerico < 10) entradaValida = true;
    else 
    {
        Console.WriteLine($"Usted ingreso {valorNumerico}. Por favor ingrese un numero entre 5 y 10.");
        entradaValida = false;
    }
    
} while (entradaValida == false);
Console.WriteLine($"Su valor ingresado ({valorNumerico}) ha sido aceptado");

string? readResult;
bool validEntry = false;
Console.WriteLine("Ingrese el nombre de su Rol (Administrador, Director o Usuario)");
do
{
    readResult = Console.ReadLine();
    if (readResult.Trim().ToLower() == "administrador" 
        || readResult.Trim().ToLower() == "director" 
        || readResult.Trim().ToLower() == "usuario")
        validEntry = true;
    else
        Console.WriteLine($"El nombre de rol ingresado, \"{readResult}\" no es valido. \n\tIngrese el nombre de su Rol (Administrador, Director o Usuario)");
} while (validEntry == false);
Console.WriteLine($"El nombre de rol ({readResult}) ha sido aceptado");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;


for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;
   
    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}*/

