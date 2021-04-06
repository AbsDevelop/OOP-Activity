namespace Cadastros
{
    class Caminhoes : Veiculos
    {
       private int numeroEixos;
       private double pesoMaxCarga;
       private int tamanhoMetros;

        public Caminhoes(string modelo, string marca, string cor, int ano, int portas, string placa, int numeroEixos, double pesoMaxCarga, int tamanhoMetros) : base(modelo, fabricante, cor, ano, portas, placa)   
        {
            this.numeroEixos = numeroEixos;
            this.pesoMaxCarga = pesoMaxCarga;
            this.tamanhoMetros = tamanhoMetros;
        }

        public int numeroEixos
        {
            get{return this.numeroEixos;}
            set{numeroEixos = value;}
        }

        public string pesoMaxCarga
        {
            get{return this.pesoMaxCarga;}
            set{pesoMaxCarga = value;}
        }

        public int tamanhoMetros
        {
            get{return this.tamanhoMetros;}
            set{tamanhoMetros = value;}
        }

        public override string ToString()
        {
            return string.Format("\nCaminhão\nModelo: {0}\nMarca: {1}\nCor: {2}\nAno: {3}\nNúmero de portas: {4}\nPlaca: {5}\nNúmero de eixos: {6}\nPeso máximo de carga: {7}\nTamanho em Metros: {8}\n", modelo, marca, cor, ano, portas, placa, numeroEixos, pesoMaxCarga, tamanhoMetros);
	    }
    }    
}