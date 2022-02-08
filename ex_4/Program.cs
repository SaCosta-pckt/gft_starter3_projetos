//Inverter um inteiro
using static System.Console;
namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long [] nums = {15485448, 2195498, 12, 98716549, 9999998999, 1654891};
            foreach (var item in nums)
            {
                string nIntertido = new string (item.ToString().Reverse().ToArray());
                WriteLine($"{item} {nIntertido}");
                
            }
        }
    }
}
