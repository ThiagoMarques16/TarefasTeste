using System.Globalization;
using ToDoList.Entities;


namespace ToDoListTeste
{
    public class TarefaTeste
    {

        private Tarefa _tarefa;

        public TarefaTeste()
        {
            _tarefa = new Tarefa();
        }

        [Theory]
        [InlineData(1, "Lavar a casa", "Realizar pela manha", "Concluido")]
        [InlineData(2, "Lavar a louca", "lavar a louca do almoco", "Pendente")]
        public void VerifcarSeAListaContemInformacoesInsedirdas(int id, string nome, string descricao, string status)
        {
            var tarefaAdiconada = _tarefa.CadastrarTarefa(id, nome, descricao, status);

            var listarTarefa = _tarefa.tarefas.ToList();

            Assert.Contains(tarefaAdiconada, listarTarefa);


        }

        [Theory]
        [InlineData(3, "Lavar a casa", "Realizar pela manha", "Concluido")]
        [InlineData(4, "Jogar bola", "Somente apos lavar a louça", "Pendente")]

        public void VerificarSeAsInformacoesForamRemovidas(int id, string nome, string descricao, string status)
        {
            _tarefa.CadastrarTarefa(id, nome, descricao, status);

            var tarefasARemover = _tarefa.Removertarefa(id);
            var listarTarefas = _tarefa.tarefas.ToList();

            Assert.DoesNotContain(tarefasARemover, listarTarefas);
        }

       
    }
}