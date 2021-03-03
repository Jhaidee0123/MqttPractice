using System.Threading.Tasks;

namespace TimeZoneClockIOT.Domain.Ports
{
    public interface ITimeZoneService
    {
        Task<string> GetTimeZoneMessage(string zone);
    }
}
