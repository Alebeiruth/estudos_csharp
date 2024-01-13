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






