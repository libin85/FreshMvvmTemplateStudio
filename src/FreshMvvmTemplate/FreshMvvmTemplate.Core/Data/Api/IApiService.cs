using Fusillade;

namespace FreshMvvmTemplate.Core.Services.Rest
{
    public interface IApiService<T>
    {
        T GetApi(Priority priority);
    }
}
