namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado
            var placa = ObterPlaca();
            veiculos.Add(placa);

            Console.WriteLine($"Placa: {placa} adicionada com sucesso!");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Implementado
            string placa = ObterPlaca();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                

                // Implementado
                int horas = ObterQuantidadeHoras();
                decimal valorTotal = precoInicial+precoPorHora*horas; 
                       

                // Implementado
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementado
                foreach(var item in veiculos){
                    Console.WriteLine($"Placa: {item}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private string ObterPlaca(){
            string placa = string.Empty;
            do{
                Console.Clear();
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            }while(string.IsNullOrEmpty(placa.Trim()));
            return placa;
        }
        private int ObterQuantidadeHoras(){
            string quantidadeHorasString = string.Empty;
            int quantidadeHora;
            do{
                Console.Clear();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                quantidadeHorasString = Console.ReadLine();
            }while(!int.TryParse(quantidadeHorasString, out quantidadeHora));
            return quantidadeHora;
        }
    }
}
