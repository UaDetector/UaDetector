using System.Text.RegularExpressions;

namespace UaDetector.Models;

internal sealed class OsVersion
{
    public required Regex Regex { get; init; }
    public required string Version { get; init; }
}
