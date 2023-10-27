namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // misol 1
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var kvatdarSonlar = ints.Select(y => y * y);
            Console.WriteLine(string.Join(", ", kvatdarSonlar));

            // misol 2
            var juftSonlar= ints.Where(i=>i%2 == 0);
            Console.WriteLine(string.Join(",",juftSonlar));

            // misol 3
            List<string> list = new List<string>() { "Shohboz", "Shoxrux", "Jasur", "Behzod", "Ali", "Dell", "Acer", "HP" };

            var tartiblangan = list.OrderBy(result => result);
            Console.WriteLine(string.Join(",",tartiblangan));

            foreach (var item in tartiblangan)
            {
                Console.WriteLine(item);
            }

            // misol 4 sonni uzini va kvadratini bitta lambda ga yozish

            var results = ints.Select(num =>
            {
                Console.WriteLine("son:" + num);// sonlar aloxida aloxida keladi foreach ga uxshab
                var kvadrat = num * num;// son ustida amal bajarsak unida yangi qiymat xosil buladi
                Console.WriteLine($"kvadrati: {kvadrat}");
                // bu qiymat qaytaradigan toifa 
                return kvadrat; // sooni kvadratini resultga uzlashtirishi kerak
                //.ToString() ishga tushurish
            }).ToList();

            // misol 5
            Func<int, int> kvadrat = x => x * x;
            int son = 5;
            int kv = kvadrat(son);
            Console.WriteLine($"{son } son-> {kv}-> kvadrati");

            // misol 6

        }
    }
}