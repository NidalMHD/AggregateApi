using Refit;

namespace Shared
{
    public interface IFirstClientService
    {
        [Get("/Values")]
        Task<List<string>> GetValues();
    }
}
