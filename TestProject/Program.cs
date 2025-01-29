/*int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);
Console.WriteLine(largerValue);*/

/*
//CONDICIONALES
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
}else if(daysUntilExpiration == 1){
    Console.WriteLine("Your subscription expires within a day!.");
    discountPercentage = 20;
}else if(daysUntilExpiration < 6){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;   
}else if(daysUntilExpiration < 11){
    Console.WriteLine("Your subscription will expire soon. Renew now!.");
}

if(discountPercentage > 0){
Console.WriteLine($"Renew now and save {discountPercentage}%!");  
}*/

/*
//MATRIZ
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";


string[] fraudulentOrderIDs = [ "A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//FOREACH
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/

//Desafío de código: Notificar los identificadores de pedido que necesitan una investigación más detallada
/*
B123
C234
A345
C15
B177
G3003
C235
B179


string [] pedidosIds = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
int cantFraude = 0;

foreach (string i in pedidosIds){
    if (i.StartsWith("B")){
        Console.WriteLine(i);
        cantFraude++;
    }
}
Console.WriteLine($"Cantidad de fraudes: {cantFraude}");
*/

/*
//Codigo legible

    /*
    The following code creates five random OrderIDs
    to test the fraud detection process.  OrderIDs 
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
    /*

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


//Desafío de código: aplicación de directrices de estilo para mejorar la legibilidad

    /*
    El codigo da vuelta el contenido del mensaje original mostrandolo 
    y cuenta la cantidad de letras 'o' que aparecen.
    /*

string mensajeOriginal = "The quick brown fox jumps over the lazy dog.";

char[] mensaje = mensajeOriginal.ToCharArray();
Array.Reverse(mensaje);

int contadorLetra = 0;

foreach (char letra in mensaje) 
{ 
    if (letra == 'o') 
    { 
        contadorLetra++; 
    } 
}

string mensajeNuevo = new String(mensaje);

Console.WriteLine($"Mensaje Original: {mensajeOriginal}");
Console.WriteLine($"Mensaje al reves: {mensajeNuevo}");
Console.WriteLine($"La letra 'o' aparece {contadorLetra} veces.");
*/
/*
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-

using System;

int examenesAsignados = 5;

int []sophiaNotas = new int[] {90, 86, 87, 98, 100, 94, 90};
int []andrewNotas = new int[] {92, 89, 81, 96, 90, 89};
int []emmaNotas = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int []loganNotas = new int[] {90, 95, 87, 88, 96, 96};

string []nomAlumnos = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int []notasAlumnos = new int [10]; 

string califLetra = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string nombre in nomAlumnos)
{
    int sumNotas = 0;
    
    decimal promedio = 0;
    
    if (nombre == "Sophia")
        notasAlumnos = sophiaNotas;    

    else if (nombre == "Andrew")
        notasAlumnos = andrewNotas;

    else if (nombre == "Emma")
        notasAlumnos = emmaNotas; 

    else if (nombre == "Logan")
        notasAlumnos = loganNotas; 


    
    int tareasAsignadas = 0;

    foreach (int nota in notasAlumnos)
    {
        tareasAsignadas += 1;

        if(tareasAsignadas <= examenesAsignados)
        {
            sumNotas += nota;
        }
        else
        {
            sumNotas += nota / 10;
        }
        
    }
    promedio = (decimal) (sumNotas) / examenesAsignados;
    
    if(promedio >= 97)
        califLetra = "A+";

    else if (promedio >= 93)
        califLetra = "A";

    else if (promedio >= 90)
        califLetra = "A-";

    else if (promedio >= 87)
        califLetra = "B+";

    else if(promedio >= 83)
        califLetra = "B";

    else if (promedio >= 80)
        califLetra = "B-";

    else if (promedio >= 77)
        califLetra = "C+";

    else if (promedio >=73)
        califLetra = "C";

    else if (promedio >=70)
        califLetra = "C-";

    else if (promedio >=67)
        califLetra = "D+";

    else if (promedio >= 63)
        califLetra = "D";

    else if (promedio >= 60)
        califLetra = "D-";

    else 
        califLetra = "F";

    Console.WriteLine($"{nombre}:\t\t{promedio}\t{califLetra}");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/
/*
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int extraCredit = 0;
    int examScore = 0;
    
    
    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;


    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            examScore = examScore + score;
        }
        else
        {
            gradedExtraCreditAssignments += 1;
            extraCredit += score;
        }
    }

    currentStudentExamScore = (decimal) examScore / examAssignments;
    currentStudentExtraCreditScore = (decimal) (extraCredit) / gradedExtraCreditAssignments;

    currentStudentGrade = (decimal)((decimal)examScore + ((decimal)extraCredit / 10)) / examAssignments;
  
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)extraCredit / 10) / examAssignments)} pts)");
}


Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
*/
Console.WriteLine("Hello C#");