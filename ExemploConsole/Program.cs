using System;

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
           var view = new ViewContatos();
            view.ObterContatos();
            Console.ReadKey();
        }
    }
}
