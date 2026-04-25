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

int secondvalue = 1;
secondvalue++;
Console.WriteLine("First: " + secondvalue);
Console.WriteLine($"Second: {secondvalue++}");
Console.WriteLine("Third: " + secondvalue);
Console.WriteLine("Fourth: " + (++secondvalue));