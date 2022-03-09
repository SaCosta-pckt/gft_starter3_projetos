using static System.Console;
namespace ex_1.src
{
    public class Veiculo
    {
        private string marca ="";
        private string modelo ="";
        private string placa ="";
        private string cor ="";
        private float km;
        private bool isLigado;
        private int litrosCombustivel;
        private int velocidade;
        private double preco;

        public Veiculo(){

        }
        //Getters
        public string getMarca(){
            return this.marca;
        }
        public string getModelo(){
            return this.modelo;
        }
        public string getCor(){
            return this.cor;
        }
        public string getPlaca(){
            return this.placa;
        }
        public float getKm(){
            return this.km;
        }
        public bool getIsLigado(){
            return this.isLigado;
        }
        public int getLitrosCombustivel(){
            return this.litrosCombustivel;
        }
        public int getVelocidade(){
            return this.velocidade;
        }
        public double getPreco(){
            return this.preco;
        }

        //Setters
        public void setMarca(string marca){
            this.marca=marca;
        }
        public void setModelo(string modelo){
            this.modelo=modelo;
        }
        public void setPlaca(string placa){
            this.placa=placa;
        }
        public void setCor(string cor){
            this.cor=cor;
        }
        public void setKm(float km){
            this.km=km;
        }
        public void setIsLigado(bool isLigado){
            this.isLigado=isLigado;
        }
        public void setLitrosCombustivel(int litrosCombustivel){
            this.litrosCombustivel=litrosCombustivel;
        }
        public void setVelocidade(int velocidade){
            this.velocidade=velocidade;
        }
        public void setPreco(double preco){
            this.preco=preco;
        }

        //Métodos
        public void Acelerar(){
            if (getIsLigado() == true && getLitrosCombustivel() > 0){
                this.velocidade+=20;
                WriteLine("Você acelerou. Velocidade = " + getVelocidade());
            }
            else {
                throw new System.Exception(message: "Não é possível acelerar com o carro desligado ou sem gasolina!");
            }
        }

        public void Abastecer(int litros){
            // adiocionar exception do limite 
            if(getLitrosCombustivel()+litros <= 60){
                setLitrosCombustivel(getLitrosCombustivel()+litros);
                WriteLine("Você abasteceu. Combustível atual = " + getLitrosCombustivel());
            }
            else {
                throw new System.Exception(message: $"Não é possível abastecer. O tanque transbordará. Combustível atual = {getLitrosCombustivel()}");
            }
        }

        public void Frear(){
            if (velocidade!=0){
                setVelocidade(getVelocidade() - 20);
                WriteLine("Você freiou. Velocidade atual = " + getVelocidade());
            }
            else {
                WriteLine("Não é possível freiar. O veículo já está parado.");
            }
        }

        public void Pintar(string cor){
            setCor(cor);
            WriteLine("O veículo foi pintado de " + getCor());
        }

        public void Ligar(){
            if (isLigado == false){
                setIsLigado(true);
                WriteLine("O veículo ligou");
            }
            else {
                WriteLine("O veículo já está ligado.");
            }
        }

        public void Desligar(){
            if (velocidade == 0){
                if (isLigado == true){
                    setIsLigado(false);
                    WriteLine("O veículo desligou");
                }
            }
            else {
                WriteLine("Não é possível desligar. O veículo já está desligado ou em movimento.");
            }
        }
    }
}