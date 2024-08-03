using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.Spectator;

public class ObserverDto
{
    [JsonPropertyName("encryptionKey")]
    public string EncryptionKey { get; set; } = null!;
}