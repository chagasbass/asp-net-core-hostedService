using BackgroundServices.Domain.Entities;
using System.Threading.Tasks;

namespace BackgroundServices.Domain.Services
{
    public interface IPessoaQueueService
    {
        Task EscreverNaFila(Pessoa pessoa);
        Task<Pessoa> LerDaFila();
    }
}
