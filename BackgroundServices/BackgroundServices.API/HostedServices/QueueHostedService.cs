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

        public QueueHostedService(ILogger<QueueHostedService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Chamado assim que a aplicação inicia
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }


        private void ExecuteProcess(object state)
        {
            _logger.LogInformation("### Processo sendo executado ###");
            _logger.LogInformation($"{DateTime.Now}");
        }

        /// <summary>
        /// Chamado quando a aplicação está parando a execução.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
