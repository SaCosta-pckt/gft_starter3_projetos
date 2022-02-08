//Letra que não se repete
using static System.Console;
namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] testes = {"aaabccccdeeef", "strings", "microsoft visual studio 2022", "abcedoftz"};
            foreach (var item in testes)
            {
                WriteLine(NaoRepete(item));
            }
        }
        public static string NaoRepete(string s){
            int cont=0;
            string result="_";
            foreach (char i in s)
            {
                cont = 0;
                foreach (char j in s)
                {
                    if (j==i){
                        cont ++;
                    }
                }
                
                if (cont<=1){
                    result = i.ToString();
                    break;
                }
            }

            
            return result;
        }
    }
}