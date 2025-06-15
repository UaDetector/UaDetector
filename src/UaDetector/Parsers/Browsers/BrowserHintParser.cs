using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using UaDetector.Utils;

namespace UaDetector.Parsers.Browsers;

internal static class BrowserHintParser
{
    private const string ResourceName = "Regexes.Resources.Browsers.browser_hints.json";
    internal static readonly FrozenDictionary<string, string> Hints = RegexLoader.LoadHints(
        ResourceName
    );

    public static bool TryParseBrowserName(
        ClientHints clientHints,
        [NotNullWhen(true)] out string? result
    )
    {
        if (clientHints.App is null or { Length: 0 })
        {
            result = null;
        }
        else
        {
            Hints.TryGetValue(clientHints.App, out result);
        }

        return result is not null;
    }
}
