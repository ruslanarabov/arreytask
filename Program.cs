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

var item1 = new { Id = 1, Product = "Apple", Price = 2000 };
var item2 = new { Id = 2, Product = "Samsung", Price = 1500 };
var item3 = new { Id = 3, Product = "Xiomi", Price = 700 };
var item4 = new { Id = 4, Product = "Honor", Price = 500 };
var item5 = new { Id = 5, Product = "Oppo", Price = 350 };
var items = new[] { item1, item2, item3, item4, item5 };

int sum = 0;
int count = 0;

for (int i = 0; i < items.Length; i++)
{
    if (items[i].Id % 2 == 1)
    {
        sum += items[i].Price;
        count++;
    }

}
int avarage = sum / count;
Console.WriteLine(avarage);

#endregion 
