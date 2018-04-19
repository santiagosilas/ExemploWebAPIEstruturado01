using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploLibrary.Contextos;
using ExemploLibrary.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Microsoft.EntityFrameworkCore;

namespace ExemploWebApi
{
  public class Startup
  {
      public IConfiguration Configuration { get; }

      public Startup(IConfiguration configuration)
      {
          Configuration = configuration;
      }

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services)
      {

          // Banco de Dados em Memória é injetado no container de serviço
          //services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("LP2Contatos"));

          // Banco de Dados SQL Server  é injetado no container de serviço
          services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LP2Exemplo")));

          services.AddMvc();
          services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
      }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
          if (env.IsDevelopment())
          {
              app.UseDeveloperExceptionPage();
          }

          app.UseMvc();
      }
    }
}
