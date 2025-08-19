// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
// float val: variable 0, negative = left aligned, 15 = width
// int val: variable 1, positve = right aligned, 10 = width
Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

// TODO: Spacing and Alignment: Interpolation
Console.WriteLine($"{"Float Val", -15} {"Int Val", 10}");
Console.WriteLine($"{f1, -15} {i1, 10}");
