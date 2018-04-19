using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using System.Net.Http.Headers;
using ExemploLibrary.Entidades;
using Newtonsoft.Json;

namespace ExemploConsole
{
    public class ViewContatos
    {
        /// <summary>
        /// Ilustra um fluxo básico para acessar uma Web Api com HttpClient
        /// </summary>
        public async void ObterContatos()
        {
            try
            {
                // Define o cliente para acesso da WebApi
                HttpClient cliente = new HttpClient { BaseAddress = new Uri("http://localhost:4242/") };

                // Define o content-type do header da requisição: trata-o como JSON
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Lê a resposta
                HttpResponseMessage resp = await cliente.GetAsync("/api/contatos");
                var dados = await resp.Content.ReadAsStringAsync();

                // Além do get:
                // cliente.PostAsync(...)
                //cliente.PutAsync(...)
                //cliente.DeleteAsync(...)

                // Deserializa a string, para obter uma lista de objetos contatos
                var contatos = JsonConvert.DeserializeObject<List<Contato>>(dados);

                // Exibe os dados
                foreach (var contato in contatos)
                {
                    Console.WriteLine(contato.Nome);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
