using System.Text.RegularExpressions;

namespace UaDetector.Models;

internal sealed class Client
{
    public required Regex Regex { get; init; }
    public required string Name { get; init; }
    public string? Version { get; init; }
}
