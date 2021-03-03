using System.Threading;
using System.Threading.Tasks;

namespace TimeZoneClockIOT.Domain.Ports
{
    public interface IMqttAdapter
    {
        Task SendMessage(string message, string topic);
    }
}
