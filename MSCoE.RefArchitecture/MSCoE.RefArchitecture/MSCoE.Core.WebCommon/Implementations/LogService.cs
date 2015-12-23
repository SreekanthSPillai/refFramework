using Application.Common.Contracts;
using log4net;

namespace Application.Common.Implementations
{
    public class LogService : ILogService
    {
        private ILog logger;
        private bool isConfigured = false;

        public LogService()
        {
            if (!isConfigured)
            {
                logger = LogManager.GetLogger(typeof(LogService));
                log4net.Config.XmlConfigurator.Configure();
            }
        }

        public ILog Logger()
        {
            return logger;
        }

    }
}
