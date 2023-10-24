using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public List<Tarefa> tarefas { get; set; }

        public Tarefa()
        {
            tarefas = new List<Tarefa>();
        }


        public Tarefa CadastrarTarefa(int id, string nome, string descricao, string status)
        {
            Tarefa novatarefa = new Tarefa
            {
                Id = id,
                Nome = nome,
                Descricao = descricao,
                Status = status
            };


            tarefas.Add(novatarefa);
            return novatarefa;
        }

        public Tarefa Removertarefa(int id)
        {
            Tarefa remocaoTarefa = tarefas.Find(x => x.Id == id);

            if(remocaoTarefa != null)
            {
                tarefas.Remove(remocaoTarefa);
            }

            return remocaoTarefa;
        }

        public List<Tarefa> ListarTarefa()
        {
            return tarefas.ToList();
        }

    }
}
