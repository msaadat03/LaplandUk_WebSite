using System.Threading.Tasks;

namespace Back_end.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body, string from = null);
    }
}
