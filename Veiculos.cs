namespace Cadastros
{
    class Veiculos
    {
       protected string modelo;
       protected string marca;
       protected string cor;
       protected int ano;
       protected int portas;
        
        public Veiculos(string modelo, string marca, string cor, int ano, int portas, string placa)    
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
            this.ano = ano;
            this.portas = portas;
            this.placa = placa;
        }

        public string modelo
        {
            get{return this.modelo;}
            set{modelo = value;}
            //O get usa um construtor com paramêtros, e o set sem paramêtros.
            //get->retornar o valor armazenado em um campo. set->armazena o valor do campo.
        }

        public string marca
        {
            get{return this.marca;}
            set{marca = value;}
        }

        public string cor
        {
            get{return this.cor;}
            set{cor = value;}
        }

        public int ano
        {
            get{return this.ano;}
            set{ano = value;}
        }

        public int portas
        {
            get{return this.portas;}
            set{portas = value;}
        }

        public int placa
        {
            get{return this.placa;}
            set{placa = value;}
        }

        public override string ToString()
        {
		    return string.Format("Modelo: {0}\nMarca: {1}\nCor: {2}\nAno: {3}\nNúmero de Portas: {4}\n", modelo, marca, cor, ano, portas);
	    }
    }    
}