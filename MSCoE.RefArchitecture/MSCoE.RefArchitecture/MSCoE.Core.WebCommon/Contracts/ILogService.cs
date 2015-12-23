using log4net;

namespace Application.Common.Contracts
{
    public interface ILogService
    {
        ILog Logger();
    }
}
