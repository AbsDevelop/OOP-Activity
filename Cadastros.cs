namespace Cadastros
{
    class Cadastros
    {
        private Carros[] carros = new Carros[2];
        private int contadorCarro = 0;
        private Caminhoes[] caminhoes = new Caminhoes[2];
        private int contadorCaminhao = 0;

        public void CadastrarCarro(Carros carroRecebido)
        {
            carros[contadorCarro] = carroRecebido;
            contadorCarro++;
        }

        public void CadastrarCaminhao(Caminhoes caminhaoRecebido)
        {
            caminhoes[contadorCaminhao] = caminhaoRecebido;
            contadorCaminhao++;
        }

        public Veiculos ConsultaPlacaCarro(string placa)
        {
            for (int c = 0; c < 2; c++)
            {
                if (carros[c] != null) 
                {
                    if(placa == carros[c].Placa)
                    {
                        return carros[c];
                    }
                }
            }
            return null;
        }

        public Veiculos ConsultaPlacaCaminhao(string placa)
        {
            for (int c = 0; c < 2; c++)
            {
                if (caminhoes[c] != null) 
                {
                    if(placa == caminhoes[c].Placa)
                    {
                        return caminhoes[c];
                    }
                }
            }
            return null;
        }

        public Caminhoes ModeloCaminhao(string modelo)
        {
            for (int c = 0; c < 2; c++)
            {
                if (caminhoes[c] != null) 
                {
                    if(modelo == caminhoes[c].Modelo)
                    {
                        return caminhoes[c];
                    }
                }
            }
            return null;
        }

        public Carros CorCarro(string cor)
        {
            for (int c = 0; c < 2; c++)
            {
                if (carros[c] != null) 
                {
                    if(cor == carros[c].Cor)
                    {
                        return carros[c];
                    }
                }
            }
            return null;
        }

        public Carros[] exibirCarros() 
        {
            return carros;
        }

        public Caminhoes[] exibirCaminhoes() 
        {
            return caminhoes;
        }
    }
}