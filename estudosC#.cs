// desafio declaração das variaveis

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");


//EXERCICIOS

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//DESAFIO C# utilizadno strings, @, $, \n, \t

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

//OPERAÇÕES MATEMATICAS EM C#
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//AQUI ELE CONCATENA
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 +" widgets.");

//AQUI ELE SOMA DENTRO DO PARENTESE
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) +" widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);*/

//VARIAS FORMAS DE FAZER A MSM COUSA 
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuotient = 7 / 5.0m; //funcina da mesma forma
decimal decimalQuotient = 7.0m / 5.0m; //funcina da mesma forma

Console.WriteLine($"Decimal quotient: {decimalQuotient}");

//CONVERTE INT P/ DECIMAL
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);*/

//modulo
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Acronico PEMDAS (1.Parentese 2.Expoente 3.Multiplicação e Divisão 4.Adição e Subtração)
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) *5;
Console.WriteLine(value1);
Console.WriteLine(value2);*/

int value = 0;
//value = value + 5; > 5
//value += 5; > 10
//value++; > 6
Console.WriteLine(value);


int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);



int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

Console.WriteLine($"Second: {value++}");

//DESAFIO DE FAHREINT PARA CELSIUS

//O QUE EU FIZ
int fahrenheit = 94;
Console.WriteLine($"The temperature is {((decimal)fahrenheit - 32) * 5/9} Celsius.");

//O QUE ELE SUGERE
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

//PROJETO 01
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

string student1 = "Sophia";
string student2 = "Nicolas";
string student3 = "Zahirah";
string student4 = "Jeong";

float sophia = (float)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
float nicolas = (float)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
float zahirah = (float)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
float jeong = (float)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;

Console.WriteLine($"Student \tGrade\n{student1}\t\t{sophia} " + " A" + $"\n{student2}\t\t{nicolas} " + " B" + $"\n{student3}\t\t{zahirah} " + " C" + $"\n{student4}\t\t{jeong} " + " D");

//SOLUÇÃO DADA PELA PLATAFORMA

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

//PROJETO 02

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int totaalGradePoints = 0;
totaalGradePoints += course1Credit * course1Grade;
totaalGradePoints += course2Credit * course2Grade;
totaalGradePoints += course3Credit * course3Grade;
totaalGradePoints += course4Credit * course4Grade;
totaalGradePoints += course5Credit * course5Grade;

//Console.WriteLine($"{totaalGradePoints} {totalCreditHours}");

decimal gradePointAverage = (decimal)totaalGradePoints / totalCreditHours;

int leadDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}\n");

Console.WriteLine($"Final GPA:\t\t\t{leadDigit}.{firstDigit}{secondDigit}");

//EXERCICIO DE BIBLIOTECAS

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

//IF, ELSE IF, ELSE, ||, &&
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

roll1 = 6;
roll2 = 6;
roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
    else
    {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    }

    Console.WriteLine($"You total including the bonus: {total}");
}

if (total >= 16){
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7) 
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Your subscription expires in {discountPercentage} days.");
    discountPercentage = 10;
}            
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

//MATRIZ

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//FOREACH == FOR

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach(int i in inventory)
{
    sum += i;
    bin++;
    Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
//UTILIZANDO SWITCH
int empregadoNivel = 100;
string empregadoNome = "Jonh Smith";

string titulo = "";

switch (empregadoNivel)
{
    case 100:
    case 200:
        titulo = "Associado Senior";
        break;
    case 300:
        titulo = "Gerente";
        break;
    case 400:
        titulo = "Gerente senior";
        break;
    default:
        titulo = "Associado";
        break;
}
Console.WriteLine($"{empregadoNome}, {titulo}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "Sweat shirt";
string color = "Maroon";
string size = "Large";


switch (type)
{
    case "Sweat shirt":
        product[0] = "01";
        break;
    case "T-Shirt":
        product[0] = "02";
        break;
    case "Sweat pants":
        product[0] = "03";
        break;
    default:
        product[0] = "Other";
        break;
}

switch(color)
{
    case "BL":
        product[1] = "Black";
        break;
    case "MN":
        product[1] = "Maroon";
        break;
    default:
        product[1] = "White";
        break;
}

switch(size)
{
    case "S":
        product[2] = "Small";
        break;
    case "M":
        product[2] = "Medium";
        break;
    case "L":
        product[2] = "Large";
        break;
    default:
        product[2] = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");

//int i = 0 -> inicializador
//i < 10 -> é condição para conclusão
//i++ -> iterador 

// neste for ele itera adc +1 ao i
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// neste for ele itera subtraindi -1 ao i
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

// neste for ele itera adc +3 ao i -> 0,3,6,9
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
*/

//utilizando break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break; //qnd i for 7 ele para o loop aqui
}

//precorre o elemento da matriz
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) //names.Length é 4 -> 3,2,1,0 -> Michael, David, Eddie, Alex
{
    Console.WriteLine(names[i]);
}

// aqui ele substitui o nome e segue até o tamanho max de names
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

//WHILE E DO WHILE
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3) //se o numero randomico for >= 3 ele entra no bloco
{
    Console.WriteLine(current); // aqui ele imprime o primeiro valor
    current = random.Next(1, 11);// atuliza o valor randomico aqui e volta pro while
}
Console.WriteLine($"Last number: {current}");//termina se for false <= 3 e imprime aqui qual foi o ultimo numero no current

//USANDO CONTINUE
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);//novo valor random p current

    if (current >= 8) continue; // se maior ou  igual ele cai direto no While

    Console.WriteLine(current);
} while (current != 7); //enquanto não for 7 o loop continua
