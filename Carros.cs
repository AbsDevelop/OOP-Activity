namespace Cadastros
{
    class Carros : Veiculos
    {
       private int portaMalas;
       private bool bagageiro;
       private int quantPassageiros;

        public Carros(string modelo, string marca, string cor, int ano, int portas, string placa, int portaMalas, bool bagageiro, int quantPassageiros) : base(modelo, fabricante, cor, ano, portas, placa)   
        {
            this.portaMalas = portaMalas;
            this.bagageiro = bagageiro;
            this.quantPassageiros = quantPassageiros;
        }

        public string portaMalas
        {
            get{return this.portaMalas;}
            set{portaMalas = value;}
        }

        public string bagageiro
        {
            get{return this.bagageiro;}
            set{bagageiro = value;}
        }

        public int quantPassageiros
        {
            get{return this.quantPassageiros;}
            set{quantPassageiros = value;}
        }

        public override string ToString()
        {
            return string.Format("\nCarro\nModelo: {0}\nMarca: {1}\nCor: {2}\nAno: {3}\nNúmero de portas: {4}\nPlaca: {5}\nCapacidade do porta malas: {6}\nPossui Bagageiro? {7}\nNúmero de pessoas: {8}\n", modelo, marca, cor, ano, portas, placa, portaMalas, bagageiro, quantPassageiros);
	    }
    }    
}