using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000072 RID: 114
	public static class ColorConverter
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00018AF0 File Offset: 0x00016CF0
		static ColorConverter()
		{
			global::Infragistics.ColorConverter.standardColors.Add("aliceblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 240,
				G = 248,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("antiquewhite", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 250,
				G = 235,
				B = 215
			});
			global::Infragistics.ColorConverter.standardColors.Add("aqua", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = byte.MaxValue,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("aquamarine", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 127,
				G = byte.MaxValue,
				B = 212
			});
			global::Infragistics.ColorConverter.standardColors.Add("azure", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 240,
				G = byte.MaxValue,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("beige", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 245,
				G = 245,
				B = 220
			});
			global::Infragistics.ColorConverter.standardColors.Add("bisque", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 228,
				B = 196
			});
			global::Infragistics.ColorConverter.standardColors.Add("black", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 0,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("blanchedalmond", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 235,
				B = 205
			});
			global::Infragistics.ColorConverter.standardColors.Add("blue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 0,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("blueviolet", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 138,
				G = 43,
				B = 226
			});
			global::Infragistics.ColorConverter.standardColors.Add("brown", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 165,
				G = 42,
				B = 42
			});
			global::Infragistics.ColorConverter.standardColors.Add("burgesswood", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 222,
				G = 184,
				B = 135
			});
			global::Infragistics.ColorConverter.standardColors.Add("cadetblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 95,
				G = 158,
				B = 160
			});
			global::Infragistics.ColorConverter.standardColors.Add("chartreuse", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 127,
				G = byte.MaxValue,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("chocolate", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 210,
				G = 105,
				B = 30
			});
			global::Infragistics.ColorConverter.standardColors.Add("coral", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 127,
				B = 80
			});
			global::Infragistics.ColorConverter.standardColors.Add("cornflowerblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 100,
				G = 149,
				B = 237
			});
			global::Infragistics.ColorConverter.standardColors.Add("cornsilk", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 248,
				B = 220
			});
			global::Infragistics.ColorConverter.standardColors.Add("crimson", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 220,
				G = 20,
				B = 60
			});
			global::Infragistics.ColorConverter.standardColors.Add("cyan", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = byte.MaxValue,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 0,
				B = 139
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkcyan", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 139,
				B = 139
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkgoldenrod", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 184,
				G = 134,
				B = 11
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkgray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 169,
				G = 169,
				B = 169
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 100,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkkhaki", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 189,
				G = 183,
				B = 107
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkmagenta", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 139,
				G = 0,
				B = 139
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkolivegreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 85,
				G = 107,
				B = 47
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkorange", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 140,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkorchid", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 153,
				G = 50,
				B = 204
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkred", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 139,
				G = 0,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("darksalmon", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 233,
				G = 150,
				B = 122
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkseagreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 143,
				G = 188,
				B = 143
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkslateblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 72,
				G = 61,
				B = 139
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkslategray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 47,
				G = 79,
				B = 79
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkturquoise", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 206,
				B = 209
			});
			global::Infragistics.ColorConverter.standardColors.Add("darkviolet", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 148,
				G = 0,
				B = 211
			});
			global::Infragistics.ColorConverter.standardColors.Add("deeppink", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 20,
				B = 147
			});
			global::Infragistics.ColorConverter.standardColors.Add("deepskyblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 191,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("dimgray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 105,
				G = 105,
				B = 105
			});
			global::Infragistics.ColorConverter.standardColors.Add("dodgerblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 30,
				G = 144,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("firebrick", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 178,
				G = 34,
				B = 34
			});
			global::Infragistics.ColorConverter.standardColors.Add("floralwhite", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 250,
				B = 240
			});
			global::Infragistics.ColorConverter.standardColors.Add("forestgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 34,
				G = 139,
				B = 34
			});
			global::Infragistics.ColorConverter.standardColors.Add("fuchsia", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 0,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("gainsboro", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 220,
				G = 220,
				B = 220
			});
			global::Infragistics.ColorConverter.standardColors.Add("ghostwhite", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 248,
				G = 248,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("gold", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 215,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("goldenrod", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 218,
				G = 165,
				B = 32
			});
			global::Infragistics.ColorConverter.standardColors.Add("gray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 128,
				G = 128,
				B = 128
			});
			global::Infragistics.ColorConverter.standardColors.Add("green", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 128,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("greenyellow", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 173,
				G = byte.MaxValue,
				B = 47
			});
			global::Infragistics.ColorConverter.standardColors.Add("honeydew", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 240,
				G = byte.MaxValue,
				B = 240
			});
			global::Infragistics.ColorConverter.standardColors.Add("hotpink", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 105,
				B = 180
			});
			global::Infragistics.ColorConverter.standardColors.Add("indianred", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 205,
				G = 92,
				B = 92
			});
			global::Infragistics.ColorConverter.standardColors.Add("indigo", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 75,
				G = 0,
				B = 130
			});
			global::Infragistics.ColorConverter.standardColors.Add("ivory", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = byte.MaxValue,
				B = 240
			});
			global::Infragistics.ColorConverter.standardColors.Add("khaki", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 240,
				G = 230,
				B = 140
			});
			global::Infragistics.ColorConverter.standardColors.Add("lavender", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 230,
				G = 230,
				B = 250
			});
			global::Infragistics.ColorConverter.standardColors.Add("lavenderblush", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 240,
				B = 245
			});
			global::Infragistics.ColorConverter.standardColors.Add("lawngreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 124,
				G = 252,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("lemonchiffon", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 250,
				B = 205
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 173,
				G = 216,
				B = 230
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightcoral", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 240,
				G = 128,
				B = 128
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightcyan", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 224,
				G = byte.MaxValue,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightgoldenrodyellow", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 250,
				G = 250,
				B = 210
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 144,
				G = 238,
				B = 144
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightgrey", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 211,
				G = 211,
				B = 211
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightpink", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 182,
				B = 193
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightsalmon", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 160,
				B = 122
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightseagreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 32,
				G = 178,
				B = 170
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightskyblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 135,
				G = 206,
				B = 250
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightslategray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 119,
				G = 136,
				B = 153
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightsteelblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 176,
				G = 196,
				B = 222
			});
			global::Infragistics.ColorConverter.standardColors.Add("lightyellow", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = byte.MaxValue,
				B = 224
			});
			global::Infragistics.ColorConverter.standardColors.Add("lime", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = byte.MaxValue,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("limegreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 50,
				G = 205,
				B = 50
			});
			global::Infragistics.ColorConverter.standardColors.Add("linen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 250,
				G = 240,
				B = 230
			});
			global::Infragistics.ColorConverter.standardColors.Add("magenta", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 0,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("maroon", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 128,
				G = 0,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumaquamarine", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 102,
				G = 205,
				B = 170
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 0,
				B = 205
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumorchid", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 186,
				G = 85,
				B = 211
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumpurple", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 147,
				G = 112,
				B = 219
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumseagreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 60,
				G = 179,
				B = 113
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumslateblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 123,
				G = 104,
				B = 238
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumspringgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 250,
				B = 154
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumturquoise", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 72,
				G = 209,
				B = 204
			});
			global::Infragistics.ColorConverter.standardColors.Add("mediumvioletred", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 199,
				G = 21,
				B = 133
			});
			global::Infragistics.ColorConverter.standardColors.Add("midnightblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 25,
				G = 25,
				B = 112
			});
			global::Infragistics.ColorConverter.standardColors.Add("mintcream", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 245,
				G = byte.MaxValue,
				B = 250
			});
			global::Infragistics.ColorConverter.standardColors.Add("mistyrose", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 228,
				B = 225
			});
			global::Infragistics.ColorConverter.standardColors.Add("moccasin", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 228,
				B = 181
			});
			global::Infragistics.ColorConverter.standardColors.Add("navajowhite", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 222,
				B = 173
			});
			global::Infragistics.ColorConverter.standardColors.Add("navy", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 0,
				B = 128
			});
			global::Infragistics.ColorConverter.standardColors.Add("oldlace", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 253,
				G = 245,
				B = 230
			});
			global::Infragistics.ColorConverter.standardColors.Add("olive", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 128,
				G = 128,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("olivedrab", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 107,
				G = 142,
				B = 35
			});
			global::Infragistics.ColorConverter.standardColors.Add("orange", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 165,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("orangered", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 69,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("orchid", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 218,
				G = 112,
				B = 214
			});
			global::Infragistics.ColorConverter.standardColors.Add("palegoldenrod", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 238,
				G = 232,
				B = 170
			});
			global::Infragistics.ColorConverter.standardColors.Add("palegreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 152,
				G = 251,
				B = 152
			});
			global::Infragistics.ColorConverter.standardColors.Add("paleturquoise", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 175,
				G = 238,
				B = 238
			});
			global::Infragistics.ColorConverter.standardColors.Add("palevioletred", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 219,
				G = 112,
				B = 147
			});
			global::Infragistics.ColorConverter.standardColors.Add("papayawhip", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 239,
				B = 213
			});
			global::Infragistics.ColorConverter.standardColors.Add("peachpuff", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 218,
				B = 185
			});
			global::Infragistics.ColorConverter.standardColors.Add("peru", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 205,
				G = 133,
				B = 63
			});
			global::Infragistics.ColorConverter.standardColors.Add("pink", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 192,
				B = 203
			});
			global::Infragistics.ColorConverter.standardColors.Add("plum", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 221,
				G = 160,
				B = 221
			});
			global::Infragistics.ColorConverter.standardColors.Add("powderblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 176,
				G = 224,
				B = 230
			});
			global::Infragistics.ColorConverter.standardColors.Add("purple", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 128,
				G = 0,
				B = 128
			});
			global::Infragistics.ColorConverter.standardColors.Add("purwablue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 155,
				G = 225,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("red", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 0,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("rosybrown", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 188,
				G = 143,
				B = 143
			});
			global::Infragistics.ColorConverter.standardColors.Add("royalblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 65,
				G = 105,
				B = 225
			});
			global::Infragistics.ColorConverter.standardColors.Add("saddlebrown", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 139,
				G = 69,
				B = 19
			});
			global::Infragistics.ColorConverter.standardColors.Add("salmon", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 250,
				G = 128,
				B = 114
			});
			global::Infragistics.ColorConverter.standardColors.Add("sandybrown", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 244,
				G = 164,
				B = 96
			});
			global::Infragistics.ColorConverter.standardColors.Add("seagreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 46,
				G = 139,
				B = 87
			});
			global::Infragistics.ColorConverter.standardColors.Add("seashell", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 245,
				B = 238
			});
			global::Infragistics.ColorConverter.standardColors.Add("sienna", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 160,
				G = 82,
				B = 45
			});
			global::Infragistics.ColorConverter.standardColors.Add("silver", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 192,
				G = 192,
				B = 192
			});
			global::Infragistics.ColorConverter.standardColors.Add("skyblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 135,
				G = 206,
				B = 235
			});
			global::Infragistics.ColorConverter.standardColors.Add("slateblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 106,
				G = 90,
				B = 205
			});
			global::Infragistics.ColorConverter.standardColors.Add("slategray", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 112,
				G = 128,
				B = 144
			});
			global::Infragistics.ColorConverter.standardColors.Add("snow", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 250,
				B = 250
			});
			global::Infragistics.ColorConverter.standardColors.Add("springgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = byte.MaxValue,
				B = 127
			});
			global::Infragistics.ColorConverter.standardColors.Add("steelblue", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 70,
				G = 130,
				B = 180
			});
			global::Infragistics.ColorConverter.standardColors.Add("tan", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 210,
				G = 180,
				B = 140
			});
			global::Infragistics.ColorConverter.standardColors.Add("teal", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 0,
				G = 128,
				B = 128
			});
			global::Infragistics.ColorConverter.standardColors.Add("thistle", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 216,
				G = 191,
				B = 216
			});
			global::Infragistics.ColorConverter.standardColors.Add("tomato", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = 99,
				B = 71
			});
			global::Infragistics.ColorConverter.standardColors.Add("turquoise", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 64,
				G = 224,
				B = 208
			});
			global::Infragistics.ColorConverter.standardColors.Add("violet", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 238,
				G = 130,
				B = 238
			});
			global::Infragistics.ColorConverter.standardColors.Add("wheat", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 245,
				G = 222,
				B = 179
			});
			global::Infragistics.ColorConverter.standardColors.Add("white", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = byte.MaxValue,
				B = byte.MaxValue
			});
			global::Infragistics.ColorConverter.standardColors.Add("whitesmoke", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 245,
				G = 245,
				B = 245
			});
			global::Infragistics.ColorConverter.standardColors.Add("yellow", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = byte.MaxValue,
				G = byte.MaxValue,
				B = 0
			});
			global::Infragistics.ColorConverter.standardColors.Add("yellowgreen", new global::System.Windows.Media.Color
			{
				A = byte.MaxValue,
				R = 154,
				G = 205,
				B = 50
			});
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001B188 File Offset: 0x00019388
		private static bool IsHexits(string value)
		{
			if (value == null)
			{
				return false;
			}
			bool flag = true;
			char[] array = value.ToLower(global::System.Globalization.CultureInfo.InvariantCulture).ToCharArray();
			foreach (char c in array)
			{
				flag &= (char.IsDigit(c) || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f');
			}
			return flag;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001B1F4 File Offset: 0x000193F4
		public static global::System.Windows.Media.Color FromString(string value)
		{
			if (value == null)
			{
				return global::System.Windows.Media.Colors.Transparent;
			}
			string key = value.ToLower(global::System.Globalization.CultureInfo.InvariantCulture);
			if (global::Infragistics.ColorConverter.standardColors.ContainsKey(key))
			{
				return global::Infragistics.ColorConverter.standardColors[key];
			}
			if (value[0] == '#')
			{
				value = value.Remove(0, 1);
			}
			global::System.Windows.Media.Color result;
			if (global::Infragistics.ColorConverter.FromHexitsString(value, out result))
			{
				return result;
			}
			if (global::Infragistics.ColorConverter.FromTokenizedString(value, out result))
			{
				return result;
			}
			global::System.Reflection.PropertyInfo property = typeof(global::System.Windows.Media.Colors).GetProperty(value, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty);
			if (property != null)
			{
				object value2 = property.GetValue(null, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty, null, null, global::System.Globalization.CultureInfo.InvariantCulture);
				if (value2 is global::System.Windows.Media.Color)
				{
					return (global::System.Windows.Media.Color)value2;
				}
			}
			return global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001B2A4 File Offset: 0x000194A4
		private static bool FromHexitsString(string value, out global::System.Windows.Media.Color color)
		{
			if (global::Infragistics.ColorConverter.IsHexits(value))
			{
				if (value.Length == 8)
				{
					color = global::System.Windows.Media.Color.FromArgb(byte.Parse(value.Substring(0, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(value.Substring(2, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(value.Substring(4, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(value.Substring(6, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture));
					return true;
				}
				if (value.Length == 6)
				{
					color = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.Parse(value.Substring(0, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(value.Substring(2, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(value.Substring(4, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture));
					return true;
				}
			}
			color = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 0, 0, 0);
			return false;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001B3A4 File Offset: 0x000195A4
		private static bool FromTokenizedString(string value, out global::System.Windows.Media.Color color)
		{
			string[] array = value.Split(new char[]
			{
				','
			});
			if (array != null)
			{
				if (array.Length == 4)
				{
					color = global::System.Windows.Media.Color.FromArgb(byte.Parse(array[0], global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(array[1], global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(array[2], global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(array[3], global::System.Globalization.CultureInfo.InvariantCulture));
					return true;
				}
				if (array.Length == 3)
				{
					color = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.Parse(array[0], global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(array[1], global::System.Globalization.CultureInfo.InvariantCulture), byte.Parse(array[2], global::System.Globalization.CultureInfo.InvariantCulture));
					return true;
				}
			}
			color = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 0, 0, 0);
			return false;
		}

		// Token: 0x04000275 RID: 629
		private static global::System.Collections.Generic.Dictionary<string, global::System.Windows.Media.Color> standardColors = new global::System.Collections.Generic.Dictionary<string, global::System.Windows.Media.Color>();
	}
}
