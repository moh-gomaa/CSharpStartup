using CSharpStartup.Project1;

Console.WriteLine("Hello, World!");

//Literal Suffix
//var intX = 1_000_000;
//var f = 1_000_000f;
//var d = 0d;
//var m = 0m;
//var u = 0u;
//var l = 0l;
//var ul = 0ul;

//1.Variables practical example:
//var id = 1000;
//var fName = "Mohamed";
//var lName = "Gomaa";
//var salary = 1000d;
//var gender = 'M';
//var address = "Giza, 6 Of October";

//Console.WriteLine("My Info");
//Console.WriteLine($"Id: {id}");
//Console.WriteLine($"Name: {fName} {lName}");
//Console.WriteLine($"salary: {salary}");
//Console.WriteLine($"gender: {gender}");
//Console.WriteLine($"address: {address}");


//2.Boolean types & operators example:
ConsoleHelper.WriteColorLine("Boolean types & operators example");
Console.WriteLine();

//#1 Assign operator (=)
ConsoleHelper.WriteColorLine("#1 Assign operator (=)");

var x = 10;
var y = 10;

//#2 Equality operator (==)
ConsoleHelper.WriteColorLine("#2 Equality operator (==)");

var z = (x == y);
Console.WriteLine($"x == y => {z}"); //True
Console.WriteLine();

//#3 Comparison operator (> >= < <=)
ConsoleHelper.WriteColorLine("#3 Comparison operator (> >= < <=)");

var total = 1000;
var vipThershold = 1000;

Console.WriteLine($"total > vipThershold => {total > vipThershold}"); //False
Console.WriteLine($"total >= vipThershold => {total >= vipThershold}"); //True
Console.WriteLine($"total < vipThershold => {total < vipThershold}"); //False
Console.WriteLine($"total <= vipThershold => {total <= vipThershold}"); //True
Console.WriteLine();

//#4 Negation operator
ConsoleHelper.WriteColorLine("#4 Negation operator");

Console.WriteLine($"!false => {!false}"); //True
Console.WriteLine();

//#5 Conditional operator(&& || ^)
ConsoleHelper.WriteColorLine("#5 Conditional operator(&& || ^)");

//#5.1 AND operator (&&)
ConsoleHelper.WriteColorLine("#5.1 AND operator (&&)");

Console.WriteLine($"true && true => {true && true}"); //True
Console.WriteLine($"true && false => {true && false}"); //False
Console.WriteLine($"false && true => {false && true}"); //False
Console.WriteLine($"false && false => {false && false}"); //False
Console.WriteLine();

//#5.2 OR operator (||)
ConsoleHelper.WriteColorLine("#5.2 OR operator (||)");

Console.WriteLine($"true || true => {true || true}"); //True
Console.WriteLine($"true || false => {true || false}"); //True
Console.WriteLine($"false || true => {false || true}"); //True
Console.WriteLine($"false || false => {false || false}"); //False
Console.WriteLine();

//#5.3 XOR operator (^)
ConsoleHelper.WriteColorLine("#5.3 XOR operator (^)");

Console.WriteLine($"true ^ true => {true ^ true}"); //False
Console.WriteLine($"false ^ false => {false ^ false}"); //False
Console.WriteLine($"true ^ false => {true ^ false}"); //True
Console.WriteLine($"false ^ true => {false ^ true}"); //True
Console.WriteLine();

//#6 Ternary operator (? !)
ConsoleHelper.WriteColorLine("#6 Ternary operator (? !)");

var amount = 800;
var discountThreshold = 500;

var haveDiscount = (amount > discountThreshold) ? true : false;
Console.WriteLine($"haveDiscount => {haveDiscount}"); //True
Console.WriteLine();

Console.ReadKey();