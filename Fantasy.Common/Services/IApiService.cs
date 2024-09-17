

using Fantasy.Common.Models;

namespace Fantasy.Common.Services;

public interface IApiService
{
    Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
    Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);
    Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);
}
