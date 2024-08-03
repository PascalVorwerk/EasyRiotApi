using System.Text;

namespace EasyRiotApi.Models.LoL.Match;

public class MatchQuery
{
    public long? StartTime { get; set; }
    public long? EndTime { get; set; }
    public int? Queue { get; set; }
    public string? Type { get; set; }
    public int Start { get; set; } = 0;
    public int Count { get; set; } = 20;
    
    public string ToQueryString(MatchQuery query)
    {
        var queryString = new StringBuilder();
        queryString.Append($"start={query.Start}");
        queryString.Append($"&count={query.Count}");
        
        if (query.StartTime.HasValue)
        {
            queryString.Append($"&startTime={query.StartTime.Value}");
        }
        if (query.EndTime.HasValue)
        {
            queryString.Append($"&endTime={query.EndTime.Value}");
        }
        if (query.Queue.HasValue)
        {
            queryString.Append($"&queue={query.Queue.Value}");
        }
        if (!string.IsNullOrEmpty(query.Type))
        {
            queryString.Append($"&type={query.Type}");
        }
        return queryString.ToString();
    }
}