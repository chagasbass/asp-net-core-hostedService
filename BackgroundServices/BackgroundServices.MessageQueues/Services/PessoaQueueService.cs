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
            throw new NotImplementedException();
        }

        public Task<Pessoa> LerDaFila()
        {
            throw new NotImplementedException();
        }
    }
}
