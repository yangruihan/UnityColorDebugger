using System;
using UnityEngine;

public static class ColorDebug
{
    public enum DebugLevel
    {
        Log = 0,
        Warning,
        Error,
        None,
    };

    private static DebugLevel _level = DebugLevel.Log;
    public static DebugLevel Level
    {
        set { _level = value; }
        get { return _level; }
    }

    private static string _defaultFormat = "<color=\"{0}\">[{1}] {2}</color>";

    public static string GetRandomColor()
    {
        var r = UnityEngine.Random.Range(0, 1f);
        var g = UnityEngine.Random.Range(0, 1f);
        var b = UnityEngine.Random.Range(0, 1f);
        return string.Format("#{0}", ColorUtility.ToHtmlStringRGB(new Color(r, g, b)));
    }

    public static void Log(object obj = null, string color = DebugColor.Default)
    {
        if (Level <= DebugLevel.Log)
        {
            Debug.Log(string.Format(_defaultFormat, color, Time.frameCount, obj));
        }
    }

    public static void LogWarning(object obj = null, string color = DebugColor.Default)
    {
        if (Level <= DebugLevel.Warning)
        {
            Debug.LogWarning(string.Format(_defaultFormat, color, Time.frameCount, obj));
        }
    }

    public static void LogError(object obj = null, string color = DebugColor.Default)
    {
        if (Level <= DebugLevel.Error)
        {
            Debug.LogError(string.Format(_defaultFormat, color, Time.frameCount, obj));
        }
    }

    public static void LogException(Exception obj = null)
    {
        if (Level <= DebugLevel.Error)
        {
            Debug.LogException(obj);
        }
    }

    public static class DebugColor
    {
        public const string Default = "#000000";

        public static readonly string Snow = "#FFFAFA";
        public static readonly string White = "#FFFFFF";
        public static readonly string Ghostwhite = "#F8F8FF";
        public static readonly string Whitesmoke = "#F5F5F5";
        public static readonly string Floralwhite = "#FFFAF0";
        public static readonly string Linen = "#FAF0E6";
        public static readonly string Antiquewhite = "#FAEBD7";
        public static readonly string Papayawhip = "#FFEFD5";
        public static readonly string Blanchedalmond = "#FFEBCD";
        public static readonly string Bisque = "#FFE4C4";
        public static readonly string Moccasin = "#FFE4B5";
        public static readonly string Navajowhite = "#FFDEAD";
        public static readonly string Peachpuff = "#FFDAB9";
        public static readonly string Mistyrose = "#FFE4E1";
        public static readonly string Lavenderblush = "#FFF0F5";
        public static readonly string Seashell = "#FFF5EE";
        public static readonly string Oldlace = "#FDF5E6";
        public static readonly string Ivory = "#FFFFF0";
        public static readonly string Honeydew = "#F0FFF0";
        public static readonly string Mintcream = "#F5FFFA";
        public static readonly string Azure = "#F0FFFF";
        public static readonly string Aliceblue = "#F0F8FF";
        public static readonly string Lavender = "#E6E6FA";
        public static readonly string Black = "#000000";
        public static readonly string Darkslategray = "#2F4F4F";
        public static readonly string Dimgray = "#696969";
        public static readonly string Gray = "#808080";
        public static readonly string Darkgray = "#A9A9A9";
        public static readonly string Silver = "#C0C0C0";
        public static readonly string Lightgrey = "#D3D3D3";
        public static readonly string Gainsboro = "#DCDCDC";
        public static readonly string Lightslategray = "#778899";
        public static readonly string Slategray = "#708090";
        public static readonly string Lightsteelblue = "#B0C4DE";
        public static readonly string Steelblue = "#4682B4";
        public static readonly string Royalblue = "#4169E1";
        public static readonly string Midnightblue = "#191970";
        public static readonly string Navy = "#000080";
        public static readonly string Darkblue = "#00008B";
        public static readonly string Mediumblue = "#0000CD";
        public static readonly string Blue = "#0000FF";
        public static readonly string Dodgerblue = "#1E90FF";
        public static readonly string Cornflowerblue = "#6495ED";
        public static readonly string Deepskyblue = "#00BFFF";
        public static readonly string Lightskyblue = "#87CEFA";
        public static readonly string Skyblue = "#87CEEB";
        public static readonly string Lightblue = "#ADD8E6";
        public static readonly string Powderblue = "#B0E0E6";
        public static readonly string Paleturquoise = "#AFEEEE";
        public static readonly string Lightcyan = "#E0FFFF";
        public static readonly string Aqua = "#00FFFF";
        public static readonly string Cyan = "#00FFFF";
        public static readonly string Turquoise = "#40E0D0";
        public static readonly string Mediumturquoise = "#48D1CC";
        public static readonly string Darkturquoise = "#00CED1";
        public static readonly string Lightseagreen = "#20B2AA";
        public static readonly string Cadetblue = "#5F9EA0";
        public static readonly string Darkcyan = "#008B8B";
        public static readonly string Teal = "#008080";
        public static readonly string Seagreen = "#2E8B57";
        public static readonly string Darkolivegreen = "#556B2F";
        public static readonly string Darkgreen = "#006400";
        public static readonly string Green = "#008000";
        public static readonly string Forestgreen = "#228B22";
        public static readonly string Mediumseagreen = "#3CB371";
        public static readonly string Darkseagreen = "#8FBC8F";
        public static readonly string Mediumaquamarine = "#66CDAA";
        public static readonly string Aquamarine = "#7FFFD4";
        public static readonly string Palegreen = "#98FB98";
        public static readonly string Lightgreen = "#90EE90";
        public static readonly string Springgreen = "#00FF7F";
        public static readonly string Mediumspringgreen = "#00FA9A";
        public static readonly string Lawngreen = "#7CFC00";
        public static readonly string Chartreuse = "#7FFF00";
        public static readonly string Greenyellow = "#ADFF2F";
        public static readonly string Lime = "#00FF00";
        public static readonly string Limegreen = "#32CD32";
        public static readonly string Yellowgreen = "#9ACD32";
        public static readonly string Olivedrab = "#6B8E23";
        public static readonly string Olive = "#808000";
        public static readonly string Darkkhaki = "#BDB76B";
        public static readonly string Palegoldenrod = "#EEE8AA";
        public static readonly string Cornsilk = "#FFF8DC";
        public static readonly string Beige = "#F5F5DC";
        public static readonly string Lightyellow = "#FFFFE0";
        public static readonly string Lightgoldenrodyellow = "#FAFAD2";
        public static readonly string Lemonchiffon = "#FFFACD";
        public static readonly string Wheat = "#F5DEB3";
        public static readonly string Burlywood = "#DEB887";
        public static readonly string Tan = "#D2B48C";
        public static readonly string Khaki = "#F0E68C";
        public static readonly string Yellow = "#FFFF00";
        public static readonly string Gold = "#FFD700";
        public static readonly string Orange = "#FFA500";
        public static readonly string Sandybrown = "#F4A460";
        public static readonly string Darkorange = "#FF8C00";
        public static readonly string Goldenrod = "#DAA520";
        public static readonly string Peru = "#CD853F";
        public static readonly string Darkgoldenrod = "#B8860B";
        public static readonly string Chocolate = "#D2691E";
        public static readonly string Sienna = "#A0522D";
        public static readonly string Saddlebrown = "#8B4513";
        public static readonly string Maroon = "#800000";
        public static readonly string Darkred = "#8B0000";
        public static readonly string Brown = "#A52A2A";
        public static readonly string Firebrick = "#B22222";
        public static readonly string Indianred = "#CD5C5C";
        public static readonly string Rosybrown = "#BC8F8F";
        public static readonly string Darksalmon = "#E9967A";
        public static readonly string Lightcoral = "#F08080";
        public static readonly string Salmon = "#FA8072";
        public static readonly string Lightsalmon = "#FFA07A";
        public static readonly string Coral = "#FF7F50";
        public static readonly string Tomato = "#FF6347";
        public static readonly string Orangered = "#FF4500";
        public static readonly string Red = "#FF0000";
        public static readonly string Crimson = "#DC143C";
        public static readonly string Mediumvioletred = "#C71585";
        public static readonly string Deeppink = "#FF1493";
        public static readonly string Hotpink = "#FF69B4";
        public static readonly string Palevioletred = "#DB7093";
        public static readonly string Pink = "#FFC0CB";
        public static readonly string Lightpink = "#FFB6C1";
        public static readonly string Thistle = "#D8BFD8";
        public static readonly string Magenta = "#FF00FF";
        public static readonly string Fuchsia = "#FF00FF";
        public static readonly string Violet = "#EE82EE";
        public static readonly string Plum = "#DDA0DD";
        public static readonly string Orchid = "#DA70D6";
        public static readonly string Mediumorchid = "#BA55D3";
        public static readonly string Darkorchid = "#9932CC";
        public static readonly string Darkviolet = "#9400D3";
        public static readonly string Darkmagenta = "#8B008B";
        public static readonly string Purple = "#800080";
        public static readonly string Indigo = "#4B0082";
        public static readonly string Darkslateblue = "#483D8B";
        public static readonly string Blueviolet = "#8A2BE2";
        public static readonly string Mediumpurple = "#9370DB";
        public static readonly string Slateblue = "#6A5ACD";
        public static readonly string Mediumslateblue = "#7B68EE";
    }
}
