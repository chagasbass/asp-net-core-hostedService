using BackgroundServices.Domain.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundServices.API.HostedServices
{
    public class QueueHostedService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly IPessoaQueueService _PessoaQueueService;

        public QueueHostedService(ILogger<QueueHostedService> logger,IPessoaQueueService pessoaQueueService)
        {
            _logger = logger;
            _PessoaQueueService = pessoaQueueService;
        }

        /// <summary>
        /// Chamado assim que a aplicação inicia
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _ = new Timer(ExecuteProcess, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }
 
        private void ExecuteProcess(object state)
        {
            _logger.LogInformation("### Processo sendo executado ###");
            var pessoa = _PessoaQueueService.LerDaFila().Result;
            _logger.LogInformation($"Dado Recuperado da fila - ID:{pessoa.Id} - NOME: {pessoa.Nome}");
            _logger.LogInformation($"{DateTime.Now}");
        }

        /// <summary>
        /// Chamado quando a aplicação está parando a execução.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("### Processo finalizado ###");
            _logger.LogInformation($"{DateTime.Now}");

            return Task.CompletedTask;
        }
    }
}
