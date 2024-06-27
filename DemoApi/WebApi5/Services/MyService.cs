using Microsoft.Extensions.Logging;
using System;

namespace WebApi5.Services
{
    public class MyService : IMyService
    {
        private readonly ILogger logger;

        public MyService(ILogger<MyService> logger) 
        {
            this.logger = logger;
        }
        public string GetToday()
        {
            this.logger.LogInformation("Demande de date");
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
