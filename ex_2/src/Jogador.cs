namespace ex_2.src
{
    public class Jogador
    {
        private string nome;
        private string posicao;
        private string data_nasc;

        public Jogador(string nome, string posicao, string data_nasc)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.data_nasc = data_nasc;
        }

        public int CalcularIdade(){
            string [] data = new string [3];
            int ano;
            data = this.data_nasc.Split("/");
            ano = int.Parse(data[2]);
            return 2022-ano;
        }
        public int CalcularAposentadoria(){
            int idade = CalcularIdade();
            if (this.posicao == "defesa"){
                return 40-idade;
            }

            else if(this.posicao == "meio-campo"){
                return 38-idade;
            }
            //atacante
            else {
                return 35-idade;
            }

        }
    }
}