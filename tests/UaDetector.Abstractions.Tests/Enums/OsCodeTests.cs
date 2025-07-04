using Shouldly;
using UaDetector.Abstractions.Enums;

namespace UaDetector.Abstractions.Tests.Enums;

public class OsCodeTests
{
    [Test]
    public void OsCode_ValuesShouldBeSequential()
    {
        var values = Enum.GetValues<OsCode>().Cast<int>().ToList();

        for (int i = 0; i < values.Count; i++)
        {
            values[i].ShouldBe(i);
        }
    }

    [Test]
    public void OsCode_HasExpectedValues()
    {
        var expectedValues = new Dictionary<OsCode, int>
        {
            { OsCode.Aix, 0 },
            { OsCode.Android, 1 },
            { OsCode.AndroidTv, 2 },
            { OsCode.AlpineLinux, 3 },
            { OsCode.AmazonLinux, 4 },
            { OsCode.AmigaOs, 5 },
            { OsCode.ArmadilloOs, 6 },
            { OsCode.Aros, 7 },
            { OsCode.TvOs, 8 },
            { OsCode.ArchLinux, 9 },
            { OsCode.AoscOs, 10 },
            { OsCode.AspLinux, 11 },
            { OsCode.AzureLinux, 12 },
            { OsCode.BackTrack, 13 },
            { OsCode.Bada, 14 },
            { OsCode.BaiduYi, 15 },
            { OsCode.BeOs, 16 },
            { OsCode.BlackBerryOs, 17 },
            { OsCode.BlackBerryTabletOs, 18 },
            { OsCode.BlackPantherOs, 19 },
            { OsCode.BlissOs, 20 },
            { OsCode.Brew, 21 },
            { OsCode.BrightSignOs, 22 },
            { OsCode.CaixaMagica, 23 },
            { OsCode.CentOs, 24 },
            { OsCode.CentOsStream, 25 },
            { OsCode.ClearLinuxOs, 26 },
            { OsCode.ClearOsMobile, 27 },
            { OsCode.ChromeOs, 28 },
            { OsCode.ChromiumOs, 29 },
            { OsCode.ChinaOs, 30 },
            { OsCode.CoolitaOs, 31 },
            { OsCode.CyanogenMod, 32 },
            { OsCode.Debian, 33 },
            { OsCode.Deepin, 34 },
            { OsCode.DragonFly, 35 },
            { OsCode.DvkBuntu, 36 },
            { OsCode.ElectroBsd, 37 },
            { OsCode.EulerOs, 38 },
            { OsCode.Fedora, 39 },
            { OsCode.Fenix, 40 },
            { OsCode.FirefoxOs, 41 },
            { OsCode.FireOs, 42 },
            { OsCode.ForesightLinux, 43 },
            { OsCode.Freebox, 44 },
            { OsCode.FreeBsd, 45 },
            { OsCode.FritzOs, 46 },
            { OsCode.FydeOs, 47 },
            { OsCode.Fuchsia, 48 },
            { OsCode.Gentoo, 49 },
            { OsCode.Genix, 50 },
            { OsCode.Geos, 51 },
            { OsCode.GNewSense, 52 },
            { OsCode.GridOs, 53 },
            { OsCode.GoogleTv, 54 },
            { OsCode.HpUx, 55 },
            { OsCode.HaikuOs, 56 },
            { OsCode.IPadOs, 57 },
            { OsCode.HarmonyOs, 58 },
            { OsCode.HasCodingOs, 59 },
            { OsCode.HelixOs, 60 },
            { OsCode.Irix, 61 },
            { OsCode.Inferno, 62 },
            { OsCode.JavaMe, 63 },
            { OsCode.JoliOs, 64 },
            { OsCode.KaiOs, 65 },
            { OsCode.Kali, 66 },
            { OsCode.Kanotix, 67 },
            { OsCode.KinOs, 68 },
            { OsCode.Knoppix, 69 },
            { OsCode.KreaTv, 70 },
            { OsCode.Kubuntu, 71 },
            { OsCode.GnuLinux, 72 },
            { OsCode.LeafOs, 73 },
            { OsCode.LindowsOs, 74 },
            { OsCode.Linspire, 75 },
            { OsCode.LineageOs, 76 },
            { OsCode.LiriOs, 77 },
            { OsCode.Loongnix, 78 },
            { OsCode.Lubuntu, 79 },
            { OsCode.LuminOs, 80 },
            { OsCode.LuneOs, 81 },
            { OsCode.VectorLinux, 82 },
            { OsCode.Mac, 83 },
            { OsCode.Maemo, 84 },
            { OsCode.Mageia, 85 },
            { OsCode.Mandriva, 86 },
            { OsCode.MeeGo, 87 },
            { OsCode.MetaHorizon, 88 },
            { OsCode.MocorDroid, 89 },
            { OsCode.MoonOs, 90 },
            { OsCode.MotorolaEzx, 91 },
            { OsCode.Mint, 92 },
            { OsCode.MildWild, 93 },
            { OsCode.MorphOs, 94 },
            { OsCode.NetBsd, 95 },
            { OsCode.MtkNucleus, 96 },
            { OsCode.Mre, 97 },
            { OsCode.NextStep, 98 },
            { OsCode.NewsOs, 99 },
            { OsCode.Nintendo, 100 },
            { OsCode.NintendoMobile, 101 },
            { OsCode.Nova, 102 },
            { OsCode.Os2, 103 },
            { OsCode.Osf1, 104 },
            { OsCode.OpenBsd, 105 },
            { OsCode.OpenVms, 106 },
            { OsCode.OpenVz, 107 },
            { OsCode.OpenWrt, 108 },
            { OsCode.OperaTv, 109 },
            { OsCode.OracleLinux, 110 },
            { OsCode.Ordissimo, 111 },
            { OsCode.Pardus, 112 },
            { OsCode.PcLinuxOs, 113 },
            { OsCode.PicoOs, 114 },
            { OsCode.PlasmaMobile, 115 },
            { OsCode.PlayStationPortable, 116 },
            { OsCode.PlayStation, 117 },
            { OsCode.ProxmoxVe, 118 },
            { OsCode.PuffinOs, 119 },
            { OsCode.PureOs, 120 },
            { OsCode.Qtopia, 121 },
            { OsCode.RaspberryPiOs, 122 },
            { OsCode.Raspbian, 123 },
            { OsCode.RedHat, 124 },
            { OsCode.RedStar, 125 },
            { OsCode.RedOs, 126 },
            { OsCode.RevengeOs, 127 },
            { OsCode.RisingOs, 128 },
            { OsCode.RiscOs, 129 },
            { OsCode.RockyLinux, 130 },
            { OsCode.RokuOs, 131 },
            { OsCode.Rosa, 132 },
            { OsCode.RouterOs, 133 },
            { OsCode.RemixOs, 134 },
            { OsCode.ResurrectionRemixOs, 135 },
            { OsCode.Rex, 136 },
            { OsCode.RazoDroid, 137 },
            { OsCode.RtosAndNext, 138 },
            { OsCode.Sabayon, 139 },
            { OsCode.Suse, 140 },
            { OsCode.SailfishOs, 141 },
            { OsCode.ScientificLinux, 142 },
            { OsCode.SeewoOs, 143 },
            { OsCode.SerenityOs, 144 },
            { OsCode.SirinOs, 145 },
            { OsCode.Slackware, 146 },
            { OsCode.Solaris, 147 },
            { OsCode.StarBladeOs, 148 },
            { OsCode.Syllable, 149 },
            { OsCode.Symbian, 150 },
            { OsCode.SymbianOs, 151 },
            { OsCode.SymbianOsSeries40, 152 },
            { OsCode.SymbianOsSeries60, 153 },
            { OsCode.Symbian3, 154 },
            { OsCode.TencentOs, 155 },
            { OsCode.ThreadX, 156 },
            { OsCode.Tizen, 157 },
            { OsCode.TiVoOs, 158 },
            { OsCode.TmaxOs, 159 },
            { OsCode.Turbolinux, 160 },
            { OsCode.Ubuntu, 161 },
            { OsCode.Ultrix, 162 },
            { OsCode.Uos, 163 },
            { OsCode.Vidaa, 164 },
            { OsCode.ViziOs, 165 },
            { OsCode.WatchOs, 166 },
            { OsCode.WearOs, 167 },
            { OsCode.WebTv, 168 },
            { OsCode.WhaleOs, 169 },
            { OsCode.Windows, 170 },
            { OsCode.WindowsCe, 171 },
            { OsCode.WindowsIoT, 172 },
            { OsCode.WindowsMobile, 173 },
            { OsCode.WindowsPhone, 174 },
            { OsCode.WindowsRt, 175 },
            { OsCode.WoPhone, 176 },
            { OsCode.Xbox, 177 },
            { OsCode.Xubuntu, 178 },
            { OsCode.YunOs, 179 },
            { OsCode.Zenwalk, 180 },
            { OsCode.ZorinOs, 181 },
            { OsCode.IOs, 182 },
            { OsCode.PalmOs, 183 },
            { OsCode.Webian, 184 },
            { OsCode.WebOs, 185 },
        };

        expectedValues.Count.ShouldBe(Enum.GetValues<OsCode>().Length);

        foreach (var osCode in Enum.GetValues<OsCode>())
        {
            ((int)osCode).ShouldBe(expectedValues[osCode]);
        }
    }
}
