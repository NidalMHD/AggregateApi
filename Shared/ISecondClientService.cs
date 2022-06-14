using Refit;

namespace Shared
{
    public interface ISecondClientService
    {
        [Get("/OtherValues")]
        Task<string> GetOtherVaslues();
    }
}
