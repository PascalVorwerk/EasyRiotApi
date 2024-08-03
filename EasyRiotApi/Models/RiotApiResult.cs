using System.Net;

namespace EasyRiotApi.Models;

public class RiotApiResult<T>
{
    public T? Data { get; set; }
    public HttpStatusCode? StatusCode { get; set; }
    public string? ErrorMessage { get; set; }
    public bool IsSuccess => ErrorMessage == null;
}