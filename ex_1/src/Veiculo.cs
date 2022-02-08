namespace ex_1.src
{
    public class Veiculo
    {
        private string marca ="";
        private string modelo ="";
        private string placa ="";
        private string cor ="";
        private string km ="";
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
        public string getKm(){
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
        public void setKm(string km){
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
            this.velocidade+=20;
        }

        public void Abastecer(int litros){
            if(litrosCombustivel+litros > 60){
                this.litrosCombustivel+=litros;
            } 
        }

        public void Frear(){
            this.velocidade-=20;
        }
    }
}