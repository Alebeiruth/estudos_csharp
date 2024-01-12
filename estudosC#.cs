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

