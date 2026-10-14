using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000011 RID: 17
	public class DateFormatConverter
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x000031AC File Offset: 0x000013AC
		private static global::System.Collections.Generic.Dictionary<string, string> PrepareTokenConversions()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"EEEE",
					"dddd"
				},
				{
					"EEE",
					"ddd"
				},
				{
					"EE",
					"ddd"
				},
				{
					"E",
					"d"
				},
				{
					"Z",
					""
				},
				{
					"z",
					""
				},
				{
					"a",
					"am/pm"
				},
				{
					"A",
					"AM/PM"
				},
				{
					"K",
					"H"
				},
				{
					"KK",
					"HH"
				},
				{
					"k",
					"h"
				},
				{
					"kk",
					"hh"
				},
				{
					"S",
					"0"
				},
				{
					"SS",
					"00"
				},
				{
					"SSS",
					"000"
				}
			};
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000032B0 File Offset: 0x000014B0
		private static global::System.Collections.Generic.Dictionary<string, string> PrepareLocalePrefixes()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"af",
					"[$-0436]"
				},
				{
					"am",
					"[$-45E]"
				},
				{
					"ar-ae",
					"[$-3801]"
				},
				{
					"ar-bh",
					"[$-3C01]"
				},
				{
					"ar-dz",
					"[$-1401]"
				},
				{
					"ar-eg",
					"[$-C01]"
				},
				{
					"ar-iq",
					"[$-0801]"
				},
				{
					"ar-jo",
					"[$-2C01]"
				},
				{
					"ar-kw",
					"[$-3401]"
				},
				{
					"ar-lb",
					"[$-3001]"
				},
				{
					"ar-ly",
					"[$-1001]"
				},
				{
					"ar-ma",
					"[$-1801]"
				},
				{
					"ar-om",
					"[$-2001]"
				},
				{
					"ar-qa",
					"[$-4001]"
				},
				{
					"ar-sa",
					"[$-0401]"
				},
				{
					"ar-sy",
					"[$-2801]"
				},
				{
					"ar-tn",
					"[$-1C01]"
				},
				{
					"ar-ye",
					"[$-2401]"
				},
				{
					"as",
					"[$-44D]"
				},
				{
					"az-az",
					"[$-82C]"
				},
				{
					"be",
					"[$-0423]"
				},
				{
					"bg",
					"[$-0402]"
				},
				{
					"bn",
					"[$-0845]"
				},
				{
					"bo",
					"[$-0451]"
				},
				{
					"bs",
					"[$-141A]"
				},
				{
					"ca",
					"[$-0403]"
				},
				{
					"cs",
					"[$-0405]"
				},
				{
					"cy",
					"[$-0452]"
				},
				{
					"da",
					"[$-0406]"
				},
				{
					"de-at",
					"[$-C07]"
				},
				{
					"de-ch",
					"[$-0807]"
				},
				{
					"de-de",
					"[$-0407]"
				},
				{
					"de-li",
					"[$-1407]"
				},
				{
					"de-lu",
					"[$-1007]"
				},
				{
					"dv",
					"[$-0465]"
				},
				{
					"el",
					"[$-0408]"
				},
				{
					"en-au",
					"[$-C09]"
				},
				{
					"en-bz",
					"[$-2809]"
				},
				{
					"en-ca",
					"[$-1009]"
				},
				{
					"en-cb",
					"[$-2409]"
				},
				{
					"en-gb",
					"[$-0809]"
				},
				{
					"en-ie",
					"[$-1809]"
				},
				{
					"en-in",
					"[$-4009]"
				},
				{
					"en-jm",
					"[$-2009]"
				},
				{
					"en-nz",
					"[$-1409]"
				},
				{
					"en-ph",
					"[$-3409]"
				},
				{
					"en-tt",
					"[$-2C09]"
				},
				{
					"en-us",
					"[$-0409]"
				},
				{
					"en-za",
					"[$-1C09]"
				},
				{
					"es-ar",
					"[$-2C0A]"
				},
				{
					"es-bo",
					"[$-400A]"
				},
				{
					"es-cl",
					"[$-340A]"
				},
				{
					"es-co",
					"[$-240A]"
				},
				{
					"es-cr",
					"[$-140A]"
				},
				{
					"es-do",
					"[$-1C0A]"
				},
				{
					"es-ec",
					"[$-300A]"
				},
				{
					"es-es",
					"[$-40A]"
				},
				{
					"es-gt",
					"[$-100A]"
				},
				{
					"es-hn",
					"[$-480A]"
				},
				{
					"es-mx",
					"[$-80A]"
				},
				{
					"es-ni",
					"[$-4C0A]"
				},
				{
					"es-pa",
					"[$-180A]"
				},
				{
					"es-pe",
					"[$-280A]"
				},
				{
					"es-pr",
					"[$-500A]"
				},
				{
					"es-py",
					"[$-3C0A]"
				},
				{
					"es-sv",
					"[$-440A]"
				},
				{
					"es-uy",
					"[$-380A]"
				},
				{
					"es-ve",
					"[$-200A]"
				},
				{
					"et",
					"[$-0425]"
				},
				{
					"eu",
					"[$-42D]"
				},
				{
					"fa",
					"[$-0429]"
				},
				{
					"fi",
					"[$-40B]"
				},
				{
					"fo",
					"[$-0438]"
				},
				{
					"fr-be",
					"[$-80C]"
				},
				{
					"fr-ca",
					"[$-C0C]"
				},
				{
					"fr-ch",
					"[$-100C]"
				},
				{
					"fr-fr",
					"[$-40C]"
				},
				{
					"fr-lu",
					"[$-140C]"
				},
				{
					"gd",
					"[$-43C]"
				},
				{
					"gd-ie",
					"[$-83C]"
				},
				{
					"gn",
					"[$-0474]"
				},
				{
					"gu",
					"[$-0447]"
				},
				{
					"he",
					"[$-40D]"
				},
				{
					"hi",
					"[$-0439]"
				},
				{
					"hr",
					"[$-41A]"
				},
				{
					"hu",
					"[$-40E]"
				},
				{
					"hy",
					"[$-42B]"
				},
				{
					"id",
					"[$-0421]"
				},
				{
					"is",
					"[$-40F]"
				},
				{
					"it-ch",
					"[$-0810]"
				},
				{
					"it-it",
					"[$-0410]"
				},
				{
					"ja",
					"[$-0411]"
				},
				{
					"kk",
					"[$-43F]"
				},
				{
					"km",
					"[$-0453]"
				},
				{
					"kn",
					"[$-44B]"
				},
				{
					"ko",
					"[$-0412]"
				},
				{
					"ks",
					"[$-0460]"
				},
				{
					"la",
					"[$-0476]"
				},
				{
					"lo",
					"[$-0454]"
				},
				{
					"lt",
					"[$-0427]"
				},
				{
					"lv",
					"[$-0426]"
				},
				{
					"mi",
					"[$-0481]"
				},
				{
					"mk",
					"[$-42F]"
				},
				{
					"ml",
					"[$-44C]"
				},
				{
					"mn",
					"[$-0850]"
				},
				{
					"mr",
					"[$-44E]"
				},
				{
					"ms-bn",
					"[$-83E]"
				},
				{
					"ms-my",
					"[$-43E]"
				},
				{
					"mt",
					"[$-43A]"
				},
				{
					"my",
					"[$-0455]"
				},
				{
					"ne",
					"[$-0461]"
				},
				{
					"nl-be",
					"[$-0813]"
				},
				{
					"nl-nl",
					"[$-0413]"
				},
				{
					"no-no",
					"[$-0814]"
				},
				{
					"or",
					"[$-0448]"
				},
				{
					"pa",
					"[$-0446]"
				},
				{
					"pl",
					"[$-0415]"
				},
				{
					"pt-br",
					"[$-0416]"
				},
				{
					"pt-pt",
					"[$-0816]"
				},
				{
					"rm",
					"[$-0417]"
				},
				{
					"ro",
					"[$-0418]"
				},
				{
					"ro-mo",
					"[$-0818]"
				},
				{
					"ru",
					"[$-0419]"
				},
				{
					"ru-mo",
					"[$-0819]"
				},
				{
					"sa",
					"[$-44F]"
				},
				{
					"sb",
					"[$-42E]"
				},
				{
					"sd",
					"[$-0459]"
				},
				{
					"si",
					"[$-45B]"
				},
				{
					"sk",
					"[$-41B]"
				},
				{
					"sl",
					"[$-0424]"
				},
				{
					"so",
					"[$-0477]"
				},
				{
					"sq",
					"[$-41C]"
				},
				{
					"sr-sp",
					"[$-C1A]"
				},
				{
					"sv-fi",
					"[$-81D]"
				},
				{
					"sv-se",
					"[$-41D]"
				},
				{
					"sw",
					"[$-0441]"
				},
				{
					"ta",
					"[$-0449]"
				},
				{
					"te",
					"[$-44A]"
				},
				{
					"tg",
					"[$-0428]"
				},
				{
					"th",
					"[$-41E]"
				},
				{
					"tk",
					"[$-0442]"
				},
				{
					"tn",
					"[$-0432]"
				},
				{
					"tr",
					"[$-41F]"
				},
				{
					"ts",
					"[$-0431]"
				},
				{
					"tt",
					"[$-0444]"
				},
				{
					"uk",
					"[$-0422]"
				},
				{
					"ur",
					"[$-0420]"
				},
				{
					"UTF-8",
					"[$-0000]"
				},
				{
					"uz-uz",
					"[$-0843]"
				},
				{
					"vi",
					"[$-42A]"
				},
				{
					"xh",
					"[$-0434]"
				},
				{
					"yi",
					"[$-43D]"
				},
				{
					"zh-cn",
					"[$-0804]"
				},
				{
					"zh-hk",
					"[$-C04]"
				},
				{
					"zh-mo",
					"[$-1404]"
				},
				{
					"zh-sg",
					"[$-1004]"
				},
				{
					"zh-tw",
					"[$-0404]"
				},
				{
					"zu",
					"[$-0435]"
				},
				{
					"ar",
					"[$-0401]"
				},
				{
					"de",
					"[$-0407]"
				},
				{
					"en",
					"[$-0409]"
				},
				{
					"es",
					"[$-40A]"
				},
				{
					"fr",
					"[$-40C]"
				},
				{
					"it",
					"[$-0410]"
				},
				{
					"ms",
					"[$-43E]"
				},
				{
					"nl",
					"[$-0413]"
				},
				{
					"nn",
					"[$-0814]"
				},
				{
					"no",
					"[$-0414]"
				},
				{
					"pt",
					"[$-0816]"
				},
				{
					"sr",
					"[$-C1A]"
				},
				{
					"sv",
					"[$-41D]"
				},
				{
					"uz",
					"[$-0843]"
				},
				{
					"zh",
					"[$-0804]"
				},
				{
					"ga",
					"[$-43C]"
				},
				{
					"ga-ie",
					"[$-83C]"
				},
				{
					"in",
					"[$-0421]"
				},
				{
					"iw",
					"[$-40D]"
				}
			};
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public static string GetPrefixForLocale(global::System.Globalization.CultureInfo locale)
		{
			string text = locale.ToString().ToLower();
			string result;
			if (!global::NPOI.SS.Util.DateFormatConverter.localePrefixes.ContainsKey(text))
			{
				string text2 = (text.IndexOf("-") > 0) ? text.Substring(0, text.IndexOf("-")) : text;
				if (!global::NPOI.SS.Util.DateFormatConverter.localePrefixes.ContainsKey(text2))
				{
					global::System.Globalization.CultureInfo cultureInfo = global::System.Globalization.CultureInfo.GetCultureInfo(text2);
					global::NPOI.SS.Util.DateFormatConverter.logger.Log(7, string.Concat(new string[]
					{
						"Unable to find prefix for ",
						(locale != null) ? locale.ToString() : null,
						"(",
						locale.DisplayName,
						") or ",
						text2,
						"(",
						cultureInfo.DisplayName,
						")"
					}));
					return "";
				}
				result = global::NPOI.SS.Util.DateFormatConverter.localePrefixes[text2];
			}
			else
			{
				result = global::NPOI.SS.Util.DateFormatConverter.localePrefixes[text];
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003EBD File Offset: 0x000020BD
		public static string Convert(global::System.Globalization.CultureInfo locale, global::NPOI.SS.Util.DateFormat df)
		{
			throw new global::System.NotImplementedException("DateFormatConverter.Convert with DateFormat is not implemented");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003ECC File Offset: 0x000020CC
		public static string Convert(global::System.Globalization.CultureInfo locale, string format)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(global::NPOI.SS.Util.DateFormatConverter.GetPrefixForLocale(locale));
			global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer dateFormatTokenizer = new global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer(format);
			string nextToken;
			while ((nextToken = dateFormatTokenizer.GetNextToken()) != null)
			{
				if (nextToken.StartsWith("'"))
				{
					stringBuilder.Append(nextToken.Replace("'", "\""));
				}
				else if (!char.IsLetter(nextToken[0]))
				{
					stringBuilder.Append(nextToken);
				}
				else if (!global::NPOI.SS.Util.DateFormatConverter.tokenConversions.ContainsKey(nextToken))
				{
					stringBuilder.Append(nextToken);
				}
				else
				{
					string value = global::NPOI.SS.Util.DateFormatConverter.tokenConversions[nextToken];
					stringBuilder.Append(value);
				}
			}
			stringBuilder.Append(";@");
			return stringBuilder.ToString().Trim();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003F7F File Offset: 0x0000217F
		public static string GetDatePattern(int style, global::System.Globalization.CultureInfo locale)
		{
			return global::NPOI.SS.Util.DateFormat.GetDatePattern(style, locale);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003F88 File Offset: 0x00002188
		public static string GetTimePattern(int style, global::System.Globalization.CultureInfo locale)
		{
			return global::NPOI.SS.Util.DateFormat.GetTimePattern(style, locale);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003F91 File Offset: 0x00002191
		public static string GetDateTimePattern(int style, global::System.Globalization.CultureInfo locale)
		{
			return global::NPOI.SS.Util.DateFormat.GetDateTimePattern(style, style, locale);
		}

		// Token: 0x04000024 RID: 36
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.SS.Util.DateFormatConverter));

		// Token: 0x04000025 RID: 37
		private static global::System.Collections.Generic.Dictionary<string, string> tokenConversions = global::NPOI.SS.Util.DateFormatConverter.PrepareTokenConversions();

		// Token: 0x04000026 RID: 38
		private static global::System.Collections.Generic.Dictionary<string, string> localePrefixes = global::NPOI.SS.Util.DateFormatConverter.PrepareLocalePrefixes();

		// Token: 0x02000551 RID: 1361
		public class DateFormatTokenizer
		{
			// Token: 0x06003364 RID: 13156 RVA: 0x000A0E20 File Offset: 0x0009F020
			public DateFormatTokenizer(string format)
			{
				this.format = format;
			}

			// Token: 0x06003365 RID: 13157 RVA: 0x000A0E30 File Offset: 0x0009F030
			public string GetNextToken()
			{
				if (this.pos >= this.format.Length)
				{
					return null;
				}
				int num = this.pos;
				char c = this.format[this.pos];
				this.pos++;
				if (c == '\'')
				{
					while (this.pos < this.format.Length && this.format[this.pos] != '\'')
					{
						this.pos++;
					}
					if (this.pos < this.format.Length)
					{
						this.pos++;
					}
				}
				else
				{
					char c2 = c;
					while (this.pos < this.format.Length && this.format[this.pos] == c2)
					{
						this.pos++;
					}
				}
				return this.format.Substring(num, this.pos - num);
			}

			// Token: 0x06003366 RID: 13158 RVA: 0x000A0F2C File Offset: 0x0009F12C
			public static string[] Tokenize(string format)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer dateFormatTokenizer = new global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer(format);
				string nextToken;
				while ((nextToken = dateFormatTokenizer.GetNextToken()) != null)
				{
					list.Add(nextToken);
				}
				return list.ToArray();
			}

			// Token: 0x06003367 RID: 13159 RVA: 0x000A0F60 File Offset: 0x0009F160
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer dateFormatTokenizer = new global::NPOI.SS.Util.DateFormatConverter.DateFormatTokenizer(this.format);
				string nextToken;
				while ((nextToken = dateFormatTokenizer.GetNextToken()) != null)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append("[").Append(nextToken).Append("]");
				}
				return stringBuilder.ToString();
			}

			// Token: 0x04001861 RID: 6241
			private string format;

			// Token: 0x04001862 RID: 6242
			private int pos;
		}
	}
}
