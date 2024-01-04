using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicialParaCarro = 0;
decimal precoInicialParaMoto = 0;
decimal precoPorHoraParaCarro = 0;
decimal precoPorHoraParaMoto = 0;
int quantidadeDeVagasCarro;
int quantidadeDeVagasMoto;
//ToDo solicitar quantas vagas tem para carro e para moto

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial para carro:");
precoInicialParaCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora para carro:");
precoPorHoraParaCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço inicial para moto:");
precoInicialParaMoto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora para moto:");
precoPorHoraParaMoto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite Quantas vagas temos para carros");
int.TryParse(Console.ReadLine(), out quantidadeDeVagasCarro);

Console.WriteLine("Digite Quantas vagas temos para motos");
int.TryParse(Console.ReadLine(), out quantidadeDeVagasMoto);



// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Carro carros = new Carro(precoInicialParaCarro, precoPorHoraParaCarro);
Moto motos = new Moto(precoInicialParaMoto, precoPorHoraParaMoto);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    //ToDo Informar quantas vagas tem para carro e para moto
    //Se for 0 vagas para carro e zero para moto, cadastrar o adicionar veliculo
    if(quantidadeDeVagasCarro>0 && quantidadeDeVagasMoto>0){
        Console.Clear();
        Console.WriteLine($"Temos {quantidadeDeVagasCarro} vagas para Carros.");
        Console.WriteLine($"Temos {quantidadeDeVagasMoto} vagas para Motos.");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar Carro");
        Console.WriteLine("2 - Cadastrar Moto");
        Console.WriteLine("3 - Remover veículo");
        Console.WriteLine("4 - Listar veículos");
        Console.WriteLine("5 - Encerrar");
    }
    else if(quantidadeDeVagasCarro == 0  && quantidadeDeVagasMoto == 0){
        Console.Clear();
        Console.WriteLine($"Temos {quantidadeDeVagasCarro} vagas para Carros.");
        Console.WriteLine($"Temos {quantidadeDeVagasMoto} vagas para Motos.");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("--- Vagas de Carro lotadas");
        Console.WriteLine("--- Vagas de Moto lotadas");
        Console.WriteLine("3 - Remover veículo");
        Console.WriteLine("4 - Listar veículos");
        Console.WriteLine("5 - Encerrar");
    }
    else if(quantidadeDeVagasCarro == 0){
        Console.Clear();
        Console.WriteLine($"Temos {quantidadeDeVagasCarro} vagas para Carros.");
        Console.WriteLine($"Temos {quantidadeDeVagasMoto} vagas para Motos.");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("--- Vagas de Carro lotadas");
        Console.WriteLine("2 - Cadastrar Moto");
        Console.WriteLine("3 - Remover veículo");
        Console.WriteLine("4 - Listar veículos");
        Console.WriteLine("5 - Encerrar");       
    } else if(quantidadeDeVagasMoto == 0){
        Console.Clear();
        Console.WriteLine($"Temos {quantidadeDeVagasCarro} vagas para Carros.");
        Console.WriteLine($"Temos {quantidadeDeVagasMoto} vagas para Motos.");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar Carro");
        Console.WriteLine("--- Vagas de Moto lotadas");
        Console.WriteLine("3 - Remover veículo");
        Console.WriteLine("4 - Listar veículos");
        Console.WriteLine("5 - Encerrar");
    }
    

    switch (Console.ReadLine())
    {
        case "1":
            if (quantidadeDeVagasCarro == 0){
                Console.WriteLine("Não temos vagas para carros");
            } else{
                carros.AdicionarVeiculo();
                quantidadeDeVagasCarro--;
            }
             break;
        case "2":
            if (quantidadeDeVagasCarro == 0){
                Console.WriteLine("Não temos vagas para motos");
            } else{
                motos.AdicionarVeiculo();
                quantidadeDeVagasMoto--;
            }
             break;

        case "3":
            bool verificadorDeTipoDeVeiculo = false;
            while(verificadorDeTipoDeVeiculo == false){
                Console.WriteLine("Seu veiculo é carro ou moto?");
                string tipoDeVeiculo = Console.ReadLine().ToUpper();
                if(tipoDeVeiculo == "CARRO"){
                    carros.RemoverVeiculo();
                    quantidadeDeVagasCarro++;
                    verificadorDeTipoDeVeiculo = true;
                } else if(tipoDeVeiculo == "MOTO"){
                    motos.RemoverVeiculo();
                    quantidadeDeVagasMoto++;
                    verificadorDeTipoDeVeiculo = true;
                } else{
                    Console.WriteLine("Por favor digitar informações válidas");
                    verificadorDeTipoDeVeiculo = false;
                }
            }
            break;

        case "4":
            carros.ListarVeiculos();
            motos.ListarVeiculos();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
