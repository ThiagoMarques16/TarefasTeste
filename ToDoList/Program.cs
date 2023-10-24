using ToDoList.Entities;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Tarefa tarefa = new Tarefa();
                int opcao;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao Tarefas!!");
                Console.WriteLine("");
                Console.WriteLine("--- Informe a opção ---");
                Console.WriteLine("1 - Listar tarefas");
                Console.WriteLine("2 - Adicionar tarefas");
                Console.WriteLine("3 - Remover tarefas");
                Console.WriteLine("4 - Encerrar programa");
                Console.Write("Opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcao)
                {
                    case 1:
                        var tarefas = tarefa.ListarTarefa();
                        foreach(var t in tarefas)
                        {
                            Console.WriteLine($"Id: {t.Id}");
                            Console.WriteLine($"Nome: {t.Nome}");
                            Console.WriteLine($"Descricao: {t.Descricao}");
                            Console.WriteLine($"Status: {t.Status}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Informe as informacoes");
                        Console.WriteLine("");

                        Console.Write("Informe o Id: ");
                        int idAdicionar = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Descricao: ");
                        string descricao = Console.ReadLine();

                        Console.Write("Status (Concluido/ Pendente): ");
                        string status = Console.ReadLine();
                                              
                        var novaTarefa = tarefa.CadastrarTarefa(idAdicionar, nome, descricao, status);
                        break;

                    case 3:
                        Console.Write("Informe o id a ser removido: ");
                        int idRemover = int.Parse(Console.ReadLine());

                        var tarefaRemovida= tarefa.Removertarefa(idRemover);

                        if(tarefaRemovida != null)
                        {
                            Console.WriteLine("Tarefa removida");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa não encontrada"); 
                        }

                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa");
                        break;

                    default:
                        Console.WriteLine("Opção incorreta");
                        break;
                }

            } while (opcao != 4);
        }
    }
}