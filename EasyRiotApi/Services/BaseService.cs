using System.Text.Json;
using EasyRiotApi.Models;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal abstract class BaseService(IHttpClientFactory httpClientFactory, ILogger<BaseService> logger)
{
    private readonly HttpClient _client = httpClientFactory.CreateClient("RiotApiClient");
    private JsonSerializerOptions options = new(JsonSerializerDefaults.Web);
    protected async Task<RiotApiResult<T>> GetAsync<T>(string url)
    {
        try
        {
            var response = await _client.GetAsync(url);
            return await HandleResponseAsync<T>(response);
        }
        catch (HttpRequestException ex)
        {
            logger.LogError("Error while sending request to {Url}: {Message}", url, ex.Message);
            return new RiotApiResult<T>()
            {
                ErrorMessage = ex.Message,
                StatusCode = ex.StatusCode
            };
        }
    }

    private async Task<RiotApiResult<T>> HandleResponseAsync<T>(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return new RiotApiResult<T>()
            {
                Data = JsonSerializer.Deserialize<T>(content, options),
                StatusCode = response.StatusCode
            };
        }

        logger.LogError("Retrieved {StatusCode} status code from Riot API with message content: {}", response.StatusCode, response.Content.ReadAsStringAsync());
        return new RiotApiResult<T>()
        {
            ErrorMessage = response.ReasonPhrase,
            StatusCode = response.StatusCode,
        };
    }
}