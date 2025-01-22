double area = double.Parse(Console.ReadLine());

double areaPrice = area * 7.61;
double newAreaPrice = areaPrice * 0.82;

Console.WriteLine($"The final price is: {newAreaPrice} lv.");
Console.WriteLine($"The discount is: {areaPrice - newAreaPrice} lv.");