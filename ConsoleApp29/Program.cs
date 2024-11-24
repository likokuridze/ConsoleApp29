using ConsoleApp29;

var box1 = new Box<int>();
var box2 = new Box<string>();
var box3 = new Box<bool>();

box1.SetValue(5);
box2.SetValue("string");
box3.SetValue(true);

Console.WriteLine(box1.GetValue());
Console.WriteLine(box2.GetValue());
Console.WriteLine(box3.GetValue());

var values1 = new List<int>() { 1, 2, 3, 4, 5 };
var values2 = new List<string>() { "hello", "goodbye" };
var values3 = new List<bool>() { true, true, false, true, false, false };

Console.WriteLine($"List 1 count: {Utility.j(values1)}");
Console.WriteLine($"List 2 count: {Utility.j(values2)}");
Console.WriteLine($"List 3 count: {Utility.j(values3)}");