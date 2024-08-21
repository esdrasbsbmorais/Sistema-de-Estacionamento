using System.Text.RegularExpressions;

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
            string placa = "";

            // Define uma variável que verifica se o loop vai aparecer.
            bool placaValida = false;

            // Inicia o loop que impede o usuário de registrar uma placa inválida.
            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");

                // Recebe a placa do usuário
                placa = Console.ReadLine();

                // Formatação da placa antiga
                string regexPlacaAntiga = @"^[a-zA-Z]{3}-[0-9]{4}$";

                // Formatação da placa nova
                string regexPlacaNova = @"^[a-zA-Z]{3}[0-9][a-zA-Z][0-9]{2}$";
                
                Regex regexAntiga = new Regex(regexPlacaAntiga);
                Regex regexNova = new Regex(regexPlacaNova);

                // Usa a biblioteca "System.Text.RegularExpressions" para fazer a comparação do regex com oque foi informado na placa
                if (regexAntiga.IsMatch(placa) || regexNova.IsMatch(placa))
                {
                    // Verifica se a placa existe na lista, retorna erro caso existir e finaliza o loop
                    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                    {
                        Console.WriteLine("A placa informada, já foi cadastrada!");
                        break;
                    }

                    // Se a placa não existir, a placa é adicionada na lista e define o loop como true para finalizar o loop
                    else
                    {
                        placaValida = true;
                        veiculos.Add(placa.ToUpper());
                        Console.WriteLine("Veículo cadastrado com sucesso!");
                    }
                }

                // Retorna erro caso a placa esteja fora do formato definido no regex
                else
                {
                    Console.WriteLine("Placa inválida, por favor adicione a placa nos seguintes formatos 'LLL-NNNN' ou 'LLLNLNN' (L = Letra e N = Número).");
                }
                Console.WriteLine(placaValida);
            } while (placaValida == false);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = 0;
                decimal valorTotal = 0;

                // Recebe a placa em String e converte para inteiro e adiciona a variável horas
                horas = Convert.ToInt32(Console.ReadLine());

                // Realiza o calculo do valor total e adiciona a variável valorTotal
                valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
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
                
                // Inicia um loop para mostrar todos os veículos dentro da lista
                for(int contador = 0;contador < veiculos.Count; contador++)
                {
                    Console.WriteLine(veiculos[contador]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
