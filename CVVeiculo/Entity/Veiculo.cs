namespace CVVeiculo.Entity
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal Preco { get; set; }

        public Veiculo(string marca, string modelo, string cor, int anoFabricacao, decimal preco)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Veículo: {Marca}, {Modelo} - Cor: {Cor}, Ano: {AnoFabricacao}, Preço: {Preco:C}";
        }
    }
}
