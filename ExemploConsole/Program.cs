using System;
using System.Threading.Tasks;

namespace ExemploConsole
{
    class Program
    {
        /// <summary>
        /// É necessário executar o seguinte comando
        /// $ dotnet add package Newtonsoft.Json
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Obtém Contatos");
            var view = new ViewContatos();
            view.ObterContatos();
            

            // Define o repositorio Contatos
            // Esta classe contem metodos para operar sobre a Api
            var repositorio = new ApiRepository("contatos");

            // Método que envia uma requisição GET para a API especificada no repositório
            var contatosTask = repositorio.GetContatosAsync();

            Console.WriteLine("Obtém Contatos");

            // Configura uma continuação
            // O código será executado quando a tarefa assíncrona for concluída
            contatosTask.ContinueWith(task =>
            {
                var contatos = task.Result;
                foreach (var c in contatos)
                {
                    Console.WriteLine($"{c.Id} {c.Nome}.");
                }
            }, 
                // Esta continuação apenas será executada se a tarefa for concluída com êxito
                TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.WriteLine("Digite alguma tecla para sair...");
            Console.ReadKey();
        }
    }
}
