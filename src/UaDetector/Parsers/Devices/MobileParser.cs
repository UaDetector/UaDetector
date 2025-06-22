using System.Diagnostics.CodeAnalysis;
using UaDetector.Regexes.Models;
using UaDetector.Results;
using UaDetector.Utilities;

namespace UaDetector.Parsers.Devices;

internal sealed class MobileParser : DeviceParserBase
{
    private const string ResourceName = "Regexes.Resources.Devices.mobiles.json";
    private static readonly IReadOnlyList<Device> Mobiles;

    static MobileParser()
    {
        Mobiles = RegexLoader.LoadRegexes<Device>(ResourceName);
    }

    public override bool TryParse(
        string userAgent,
        [NotNullWhen(true)] out DeviceInfoInternal? result
    )
    {
        return TryParse(userAgent, Mobiles, out result);
    }
}
