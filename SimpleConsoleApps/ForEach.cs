int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin Number {bin} = {items} items in this bin. \n\t The running total of items in inventory is {sum}");
}
Console.WriteLine($"We have {sum} number of items in inventory.");