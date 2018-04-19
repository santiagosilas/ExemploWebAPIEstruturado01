using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ExemploLibrary.Entidades;
using Newtonsoft.Json;

namespace ExemploConsole
{
    public class ApiRepository
    {
        private readonly string _controller;
        readonly HttpClient _cliente = new HttpClient { BaseAddress = new Uri("http://localhost:4242/") };

        public ApiRepository(string controller)
        {
            // Armazena o nome do controller
            this._controller = controller;

            // Define o content-type do header da requisição: trata-o como JSON
            _cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Contato>> GetContatosAsync()
        {
            HttpResponseMessage response = await _cliente.GetAsync($"api/{this._controller}");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Contato>>(dados);
            }

            return new List<Contato>();
        }

        public async void AdicionarContato(Contato contato)
        {
            var serialized = JsonConvert.SerializeObject(contato);
            var conteúdo = new StringContent(serialized, Encoding.UTF8, "application/json");
            var resultado = await _cliente.PostAsync($"api/{this._controller}", conteúdo);
        }

    }
}
