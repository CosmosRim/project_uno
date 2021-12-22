// See https://aka.ms/new-console-template for more information
//using Humanizer;


Console.WriteLine("Hola, WSL2😆");

//Console.WriteLine("Quantities:");
//HumanizeQuantities();
//
//Console.WriteLine("\nDate-Time Maniplation:");
//HumanizeDates();
//
//
//static void HumanizeQuantities() {
//    Console.WriteLine("case".ToQuantity(0));
//    Console.WriteLine("case".ToQuantity(1));
//    Console.WriteLine("case".ToQuantity(5));
//}
//static void HumanizeDates() {
//    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
//    Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
//    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
//    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
//}

int result = fibonacci(5);
Console.WriteLine(result);
Console.ReadKey(true);

static int fibonacci(int n) {
    int n1 = 0;
    int n2 = 1;
    int sum = 0;

    for (int i = 2; i <= n; i++) {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }
    return n == 0 ? n1 : n2;
}