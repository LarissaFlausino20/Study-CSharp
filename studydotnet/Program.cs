int opcao = 0;
string txtopcao;

while(opcao != 5) {
    Console.Clear();
    Console.WriteLine("SISTEMA DE CADASTRO VINCIT");
    Console.WriteLine("1. CADASTRAR CLIENTE");
    Console.WriteLine("2. EDITAR CLIENTE");
    Console.WriteLine("3. REMOVER CLIENTE");
    Console.WriteLine("4. LISTAR CLIENTE");
    Console.WriteLine("5. SAIR");

    Console.WriteLine("Digite a opção: ");
    //opcao = int.Parse(Console.ReadLine());

    txtopcao = Console.ReadLine();
    if (int.TryParse(txtopcao, out opcao) == false) {
        Console.WriteLine("O recurso solicitado não foi encontrado.");
        Console.ReadKey();
    }
}

