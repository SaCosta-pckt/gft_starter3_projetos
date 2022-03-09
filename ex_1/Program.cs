using static System.Console;
using ex_1.src;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo();
            v1.Desligar();
            v1.Ligar();
            v1.Pintar("vermelho");
            v1.Abastecer(60);
            v1.Acelerar();
            v1.Ligar();
            v1.Frear();
            v1.Desligar();
            v1.Abastecer(1);
            
        }
    }
}