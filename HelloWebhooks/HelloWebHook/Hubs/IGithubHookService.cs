using System.Threading.Tasks;

namespace HelloWebHook.Hubs
{
    public interface IGithubHookService
    {
        Task BroadcastMessage(string url);
    }
}
