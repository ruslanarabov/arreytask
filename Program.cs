#region task1
// int[] numbers = { 54, 23, 78, 12, 32, 90 };
// int big = numbers[0];

// for (int i = 1; i < numbers.Length; i++)
// {
//    if (numbers[i] > big)
//    {
//        big = numbers[i];
//    }
// }
// Console.WriteLine($"En boyuk eded {big}");
#endregion




#region task2
string[] items = new { Id = 1, Product = "Apple", Price = 2000 };
string[] items = new { Id = 2, Product = "Samsung", Price = 1500 };
string[] items = new { Id = 3, Product = "Xiomi", Price = 700 };
string[] items = new { Id = 4, Product = "Honor", Price = 500 };
string[] items = new { Id = 5, Product = "Oppo", Price = 350 };

int sum = 0;
int count = 0;

for (int i = 0; i < items.Length; i++ )
{
    if (items[i].Id % 2 != 0)
    {
        sum += items[i].Price;
        count++;
    }

}
if (count > 0)
{
    int avg = sum / count;
    Console.WriteLine("Id leri tek olanlarin ededi ortsi" + avg);
}
else
{
    Console.WriteLine("Tek Id product yoxdur");
}










#endregion