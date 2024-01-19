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



//CONVERSAÇÃO DE DADOS 01
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


//CONVERSAÇÃO DE DADOS 02
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


//conversão de estreitamento -> significa que você está tentando converter um valor
//de um tipo de dados que pode conter mais informações para um tipo de dados que
//pode conter menos informações
//Neste caso, pode perder informação como precisão (ou seja, o número de valores+
//após o ponto decimal.


decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");


//CONVERSAÇÃO DE DADOS 3.1 -> int p string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//CONVERSAÇÃO DE DADOS 3.2 -> string p int
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//CONVERSAÇÃO DE DADOS 4.0 -> string para int
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//CONVERSAÇÃO DE DADOS 5.0 -> decimal para int
int value = (int)1.5m; // casting truncates -> arrendonda pra baixo
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

//Atividade 01
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//Atividade 02
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32((decimal)value1 / value2); 
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3; 
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

//MATRIZES -> Utilizando Array.Sort() e Array.Reverse()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);//coloca o array em ordem alfabetica
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);// reverte a posição da saida
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//MATRIZES -> Utilizando Array.Clear() e  Array.Resize()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);// aqui limpar do indice 0 a 2 (2 é exclusivo)
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);//aqui ele redimensiona a partir dos elementos restantes
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);//aqui ele exclui e so mantem indice 3
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//MATRIZES -> Utilizando ToCharArray() -> cria uma matriz
//Utilizando Join() e .Split() que divide a cadeia como solicitada no codigo

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

//FORMATAÇÃO COMPOSTA
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// FORMATAÇÃO INTERPOLAÇÃO
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//FORMATAÇÃO MOEDA CORRENTE
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//FORMATAR NUMEROS
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

//FORMATA PORCETAGEM
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//FORMATAÇÃO COMBINADA
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

//EXERCICIO 01
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

//FORMATA COM ESPAÇO EM BRANCO A ESQUERDA
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));


 //FORMATA COM ESPAÇO EM BRANCO A DIREITA
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);


//UTILIZANDO IndexOf() e Substring()
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition); // posição do indice 13
//Console.WriteLine(closingPosition); // posição do indice 36

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));//calcula o tamanho da variavel
//ele precisa da posição inicial e número de carateres (ou comprimento) para obter resultado

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//UTILIZANDO IndexOfAny() e LastIndexOf()
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");



string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


//UTILIZANDO Remove() e Replace()

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

//EXERCICIO 01 
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);


