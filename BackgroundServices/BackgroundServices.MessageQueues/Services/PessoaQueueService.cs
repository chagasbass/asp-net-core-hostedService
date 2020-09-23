using BackgroundServices.Domain.Entities;
using BackgroundServices.Domain.Services;
using System;
using System.Threading.Tasks;

namespace BackgroundServices.MessageQueues.Services
{
    public class PessoaQueueService : IPessoaQueueService
    {
        public Task EscreverNaFila(Pessoa pessoa)
        {
            //Simula uma escrita em uma fila.
            throw new NotImplementedException();
        }

        public Task<Pessoa> LerDaFila()
        {
            //Simula uma leitura de uma fila.

            var pessoa =  new Pessoa()
            {
                Id =1,
                Nome = "Teste de Pessoa"
            };

            return Task.FromResult(pessoa);
        }
    }
}
