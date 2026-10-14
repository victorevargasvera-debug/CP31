using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004C RID: 76
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class DateTimeUtils
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0001273C File Offset: 0x0001093C
		public static global::System.TimeSpan GetUtcOffset(this global::System.DateTime d)
		{
			return global::System.TimeZoneInfo.Local.GetUtcOffset(d);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00012749 File Offset: 0x00010949
		public static global::System.Xml.XmlDateTimeSerializationMode ToSerializationMode(global::System.DateTimeKind kind)
		{
			switch (kind)
			{
			case global::System.DateTimeKind.Unspecified:
				return global::System.Xml.XmlDateTimeSerializationMode.Unspecified;
			case global::System.DateTimeKind.Utc:
				return global::System.Xml.XmlDateTimeSerializationMode.Utc;
			case global::System.DateTimeKind.Local:
				return global::System.Xml.XmlDateTimeSerializationMode.Local;
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("kind", kind, "Unexpected DateTimeKind value.");
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001277C File Offset: 0x0001097C
		internal static global::System.DateTime EnsureDateTime(global::System.DateTime value, global::Newtonsoft.Json.DateTimeZoneHandling timeZone)
		{
			switch (timeZone)
			{
			case global::Newtonsoft.Json.DateTimeZoneHandling.Local:
				value = global::Newtonsoft.Json.Utilities.DateTimeUtils.SwitchToLocalTime(value);
				break;
			case global::Newtonsoft.Json.DateTimeZoneHandling.Utc:
				value = global::Newtonsoft.Json.Utilities.DateTimeUtils.SwitchToUtcTime(value);
				break;
			case global::Newtonsoft.Json.DateTimeZoneHandling.Unspecified:
				value = new global::System.DateTime(value.Ticks, global::System.DateTimeKind.Unspecified);
				break;
			case global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind:
				break;
			default:
				throw new global::System.ArgumentException("Invalid date time handling value.");
			}
			return value;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000127D4 File Offset: 0x000109D4
		private static global::System.DateTime SwitchToLocalTime(global::System.DateTime value)
		{
			switch (value.Kind)
			{
			case global::System.DateTimeKind.Unspecified:
				return new global::System.DateTime(value.Ticks, global::System.DateTimeKind.Local);
			case global::System.DateTimeKind.Utc:
				return value.ToLocalTime();
			case global::System.DateTimeKind.Local:
				return value;
			default:
				return value;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00012818 File Offset: 0x00010A18
		private static global::System.DateTime SwitchToUtcTime(global::System.DateTime value)
		{
			switch (value.Kind)
			{
			case global::System.DateTimeKind.Unspecified:
				return new global::System.DateTime(value.Ticks, global::System.DateTimeKind.Utc);
			case global::System.DateTimeKind.Utc:
				return value;
			case global::System.DateTimeKind.Local:
				return value.ToUniversalTime();
			default:
				return value;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001285A File Offset: 0x00010A5A
		private static long ToUniversalTicks(global::System.DateTime dateTime)
		{
			if (dateTime.Kind == global::System.DateTimeKind.Utc)
			{
				return dateTime.Ticks;
			}
			return global::Newtonsoft.Json.Utilities.DateTimeUtils.ToUniversalTicks(dateTime, dateTime.GetUtcOffset());
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001287C File Offset: 0x00010A7C
		private static long ToUniversalTicks(global::System.DateTime dateTime, global::System.TimeSpan offset)
		{
			if (dateTime.Kind == global::System.DateTimeKind.Utc || dateTime == global::System.DateTime.MaxValue || dateTime == global::System.DateTime.MinValue)
			{
				return dateTime.Ticks;
			}
			long num = dateTime.Ticks - offset.Ticks;
			if (num > 3155378975999999999L)
			{
				return 3155378975999999999L;
			}
			if (num < 0L)
			{
				return 0L;
			}
			return num;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000128E4 File Offset: 0x00010AE4
		internal static long ConvertDateTimeToJavaScriptTicks(global::System.DateTime dateTime, global::System.TimeSpan offset)
		{
			return global::Newtonsoft.Json.Utilities.DateTimeUtils.UniversalTicksToJavaScriptTicks(global::Newtonsoft.Json.Utilities.DateTimeUtils.ToUniversalTicks(dateTime, offset));
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000128F2 File Offset: 0x00010AF2
		internal static long ConvertDateTimeToJavaScriptTicks(global::System.DateTime dateTime)
		{
			return global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, true);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000128FB File Offset: 0x00010AFB
		internal static long ConvertDateTimeToJavaScriptTicks(global::System.DateTime dateTime, bool convertToUtc)
		{
			return global::Newtonsoft.Json.Utilities.DateTimeUtils.UniversalTicksToJavaScriptTicks(convertToUtc ? global::Newtonsoft.Json.Utilities.DateTimeUtils.ToUniversalTicks(dateTime) : dateTime.Ticks);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00012914 File Offset: 0x00010B14
		private static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			return (universalTicks - global::Newtonsoft.Json.Utilities.DateTimeUtils.InitialJavaScriptDateTicks) / 10000L;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00012924 File Offset: 0x00010B24
		internal static global::System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return new global::System.DateTime(javaScriptTicks * 10000L + global::Newtonsoft.Json.Utilities.DateTimeUtils.InitialJavaScriptDateTicks, global::System.DateTimeKind.Utc);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001293C File Offset: 0x00010B3C
		internal static bool TryParseDateTimeIso(global::Newtonsoft.Json.Utilities.StringReference text, global::Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, out global::System.DateTime dt)
		{
			global::Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser = default(global::Newtonsoft.Json.Utilities.DateTimeParser);
			if (!dateTimeParser.Parse(text.Chars, text.StartIndex, text.Length))
			{
				dt = default(global::System.DateTime);
				return false;
			}
			global::System.DateTime dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.CreateDateTime(dateTimeParser);
			switch (dateTimeParser.Zone)
			{
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.Utc:
				dateTime = new global::System.DateTime(dateTime.Ticks, global::System.DateTimeKind.Utc);
				break;
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.LocalWestOfUtc:
			{
				global::System.TimeSpan timeSpan = new global::System.TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
				long num = dateTime.Ticks + timeSpan.Ticks;
				if (num <= global::System.DateTime.MaxValue.Ticks)
				{
					dateTime = new global::System.DateTime(num, global::System.DateTimeKind.Utc).ToLocalTime();
				}
				else
				{
					num += dateTime.GetUtcOffset().Ticks;
					if (num > global::System.DateTime.MaxValue.Ticks)
					{
						num = global::System.DateTime.MaxValue.Ticks;
					}
					dateTime = new global::System.DateTime(num, global::System.DateTimeKind.Local);
				}
				break;
			}
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.LocalEastOfUtc:
			{
				global::System.TimeSpan timeSpan2 = new global::System.TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
				long num = dateTime.Ticks - timeSpan2.Ticks;
				if (num >= global::System.DateTime.MinValue.Ticks)
				{
					dateTime = new global::System.DateTime(num, global::System.DateTimeKind.Utc).ToLocalTime();
				}
				else
				{
					num += dateTime.GetUtcOffset().Ticks;
					if (num < global::System.DateTime.MinValue.Ticks)
					{
						num = global::System.DateTime.MinValue.Ticks;
					}
					dateTime = new global::System.DateTime(num, global::System.DateTimeKind.Local);
				}
				break;
			}
			}
			dt = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling);
			return true;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00012AD0 File Offset: 0x00010CD0
		internal static bool TryParseDateTimeOffsetIso(global::Newtonsoft.Json.Utilities.StringReference text, out global::System.DateTimeOffset dt)
		{
			global::Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser = default(global::Newtonsoft.Json.Utilities.DateTimeParser);
			if (!dateTimeParser.Parse(text.Chars, text.StartIndex, text.Length))
			{
				dt = default(global::System.DateTimeOffset);
				return false;
			}
			global::System.DateTime dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.CreateDateTime(dateTimeParser);
			global::System.TimeSpan utcOffset;
			switch (dateTimeParser.Zone)
			{
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.Utc:
				utcOffset = new global::System.TimeSpan(0L);
				break;
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.LocalWestOfUtc:
				utcOffset = new global::System.TimeSpan(-dateTimeParser.ZoneHour, -dateTimeParser.ZoneMinute, 0);
				break;
			case global::Newtonsoft.Json.Utilities.ParserTimeZone.LocalEastOfUtc:
				utcOffset = new global::System.TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
				break;
			default:
				utcOffset = global::System.TimeZoneInfo.Local.GetUtcOffset(dateTime);
				break;
			}
			long num = dateTime.Ticks - utcOffset.Ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				dt = default(global::System.DateTimeOffset);
				return false;
			}
			dt = new global::System.DateTimeOffset(dateTime, utcOffset);
			return true;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00012BB0 File Offset: 0x00010DB0
		private static global::System.DateTime CreateDateTime(global::Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser)
		{
			bool flag;
			if (dateTimeParser.Hour == 24)
			{
				flag = true;
				dateTimeParser.Hour = 0;
			}
			else
			{
				flag = false;
			}
			global::System.DateTime result = new global::System.DateTime(dateTimeParser.Year, dateTimeParser.Month, dateTimeParser.Day, dateTimeParser.Hour, dateTimeParser.Minute, dateTimeParser.Second);
			result = result.AddTicks((long)dateTimeParser.Fraction);
			if (flag)
			{
				result = result.AddDays(1.0);
			}
			return result;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00012C24 File Offset: 0x00010E24
		internal static bool TryParseDateTime(global::Newtonsoft.Json.Utilities.StringReference s, global::Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, [global::System.Runtime.CompilerServices.Nullable(2)] string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTime dt)
		{
			if (s.Length > 0)
			{
				int startIndex = s.StartIndex;
				if (s[startIndex] == '/')
				{
					if (s.Length >= 9 && s.StartsWith("/Date(") && s.EndsWith(")/") && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeMicrosoft(s, dateTimeZoneHandling, out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[startIndex]) && s[startIndex + 10] == 'T' && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeIso(s, dateTimeZoneHandling, out dt))
				{
					return true;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(dateFormatString) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeExact(s.ToString(), dateTimeZoneHandling, dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = default(global::System.DateTime);
			return false;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00012CF4 File Offset: 0x00010EF4
		internal static bool TryParseDateTime(string s, global::Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, [global::System.Runtime.CompilerServices.Nullable(2)] string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTime dt)
		{
			if (s.Length > 0)
			{
				if (s[0] == '/')
				{
					if (s.Length >= 9 && s.StartsWith("/Date(", global::System.StringComparison.Ordinal) && s.EndsWith(")/", global::System.StringComparison.Ordinal) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeMicrosoft(new global::Newtonsoft.Json.Utilities.StringReference(s.ToCharArray(), 0, s.Length), dateTimeZoneHandling, out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[0]) && s[10] == 'T' && global::System.DateTime.TryParseExact(s, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dt))
				{
					dt = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dt, dateTimeZoneHandling);
					return true;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(dateFormatString) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeExact(s, dateTimeZoneHandling, dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = default(global::System.DateTime);
			return false;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00012DE0 File Offset: 0x00010FE0
		internal static bool TryParseDateTimeOffset(global::Newtonsoft.Json.Utilities.StringReference s, [global::System.Runtime.CompilerServices.Nullable(2)] string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTimeOffset dt)
		{
			if (s.Length > 0)
			{
				int startIndex = s.StartIndex;
				if (s[startIndex] == '/')
				{
					if (s.Length >= 9 && s.StartsWith("/Date(") && s.EndsWith(")/") && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetMicrosoft(s, out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[startIndex]) && s[startIndex + 10] == 'T' && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetIso(s, out dt))
				{
					return true;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(dateFormatString) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetExact(s.ToString(), dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = default(global::System.DateTimeOffset);
			return false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00012EA8 File Offset: 0x000110A8
		internal static bool TryParseDateTimeOffset(string s, [global::System.Runtime.CompilerServices.Nullable(2)] string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTimeOffset dt)
		{
			if (s.Length > 0)
			{
				if (s[0] == '/')
				{
					if (s.Length >= 9 && s.StartsWith("/Date(", global::System.StringComparison.Ordinal) && s.EndsWith(")/", global::System.StringComparison.Ordinal) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetMicrosoft(new global::Newtonsoft.Json.Utilities.StringReference(s.ToCharArray(), 0, s.Length), out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[0]) && s[10] == 'T' && global::System.DateTimeOffset.TryParseExact(s, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dt) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetIso(new global::Newtonsoft.Json.Utilities.StringReference(s.ToCharArray(), 0, s.Length), out dt))
				{
					return true;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(dateFormatString) && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffsetExact(s, dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = default(global::System.DateTimeOffset);
			return false;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00012F94 File Offset: 0x00011194
		private static bool TryParseMicrosoftDate(global::Newtonsoft.Json.Utilities.StringReference text, out long ticks, out global::System.TimeSpan offset, out global::System.DateTimeKind kind)
		{
			kind = global::System.DateTimeKind.Utc;
			int num = text.IndexOf('+', 7, text.Length - 8);
			if (num == -1)
			{
				num = text.IndexOf('-', 7, text.Length - 8);
			}
			if (num != -1)
			{
				kind = global::System.DateTimeKind.Local;
				if (!global::Newtonsoft.Json.Utilities.DateTimeUtils.TryReadOffset(text, num + text.StartIndex, out offset))
				{
					ticks = 0L;
					return false;
				}
			}
			else
			{
				offset = global::System.TimeSpan.Zero;
				num = text.Length - 2;
			}
			return global::Newtonsoft.Json.Utilities.ConvertUtils.Int64TryParse(text.Chars, 6 + text.StartIndex, num - 6, out ticks) == global::Newtonsoft.Json.Utilities.ParseResult.Success;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00013020 File Offset: 0x00011220
		private static bool TryParseDateTimeMicrosoft(global::Newtonsoft.Json.Utilities.StringReference text, global::Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, out global::System.DateTime dt)
		{
			long javaScriptTicks;
			global::System.TimeSpan timeSpan;
			global::System.DateTimeKind dateTimeKind;
			if (!global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseMicrosoftDate(text, out javaScriptTicks, out timeSpan, out dateTimeKind))
			{
				dt = default(global::System.DateTime);
				return false;
			}
			global::System.DateTime dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
			if (dateTimeKind != global::System.DateTimeKind.Unspecified)
			{
				if (dateTimeKind != global::System.DateTimeKind.Local)
				{
					dt = dateTime;
				}
				else
				{
					dt = dateTime.ToLocalTime();
				}
			}
			else
			{
				dt = global::System.DateTime.SpecifyKind(dateTime.ToLocalTime(), global::System.DateTimeKind.Unspecified);
			}
			dt = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dt, dateTimeZoneHandling);
			return true;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00013094 File Offset: 0x00011294
		private static bool TryParseDateTimeExact(string text, global::Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTime dt)
		{
			global::System.DateTime dateTime;
			if (global::System.DateTime.TryParseExact(text, dateFormatString, culture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dateTime))
			{
				dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling);
				dt = dateTime;
				return true;
			}
			dt = default(global::System.DateTime);
			return false;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000130D0 File Offset: 0x000112D0
		private static bool TryParseDateTimeOffsetMicrosoft(global::Newtonsoft.Json.Utilities.StringReference text, out global::System.DateTimeOffset dt)
		{
			long javaScriptTicks;
			global::System.TimeSpan timeSpan;
			global::System.DateTimeKind dateTimeKind;
			if (!global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseMicrosoftDate(text, out javaScriptTicks, out timeSpan, out dateTimeKind))
			{
				dt = default(global::System.DateTime);
				return false;
			}
			dt = new global::System.DateTimeOffset(global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks).Add(timeSpan).Ticks, timeSpan);
			return true;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00013128 File Offset: 0x00011328
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, global::System.Globalization.CultureInfo culture, out global::System.DateTimeOffset dt)
		{
			global::System.DateTimeOffset dateTimeOffset;
			if (global::System.DateTimeOffset.TryParseExact(text, dateFormatString, culture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dateTimeOffset))
			{
				dt = dateTimeOffset;
				return true;
			}
			dt = default(global::System.DateTimeOffset);
			return false;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00013158 File Offset: 0x00011358
		private static bool TryReadOffset(global::Newtonsoft.Json.Utilities.StringReference offsetText, int startIndex, out global::System.TimeSpan offset)
		{
			bool flag = offsetText[startIndex] == '-';
			int num;
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.Int32TryParse(offsetText.Chars, startIndex + 1, 2, out num) != global::Newtonsoft.Json.Utilities.ParseResult.Success)
			{
				offset = default(global::System.TimeSpan);
				return false;
			}
			int num2 = 0;
			if (offsetText.Length - startIndex > 5 && global::Newtonsoft.Json.Utilities.ConvertUtils.Int32TryParse(offsetText.Chars, startIndex + 3, 2, out num2) != global::Newtonsoft.Json.Utilities.ParseResult.Success)
			{
				offset = default(global::System.TimeSpan);
				return false;
			}
			offset = global::System.TimeSpan.FromHours((double)num) + global::System.TimeSpan.FromMinutes((double)num2);
			if (flag)
			{
				offset = offset.Negate();
			}
			return true;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000131E8 File Offset: 0x000113E8
		internal static void WriteDateTimeString(global::System.IO.TextWriter writer, global::System.DateTime value, global::Newtonsoft.Json.DateFormatHandling format, [global::System.Runtime.CompilerServices.Nullable(2)] string formatString, global::System.Globalization.CultureInfo culture)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(formatString))
			{
				char[] array = new char[64];
				int count = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(array, 0, value, null, value.Kind, format);
				writer.Write(array, 0, count);
				return;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001323C File Offset: 0x0001143C
		internal static int WriteDateTimeString(char[] chars, int start, global::System.DateTime value, global::System.TimeSpan? offset, global::System.DateTimeKind kind, global::Newtonsoft.Json.DateFormatHandling format)
		{
			int num2;
			if (format == global::Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat)
			{
				global::System.TimeSpan offset2 = offset ?? value.GetUtcOffset();
				long num = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(value, offset2);
				"\\/Date(".CopyTo(0, chars, start, 7);
				num2 = start + 7;
				string text = num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				text.CopyTo(0, chars, num2, text.Length);
				num2 += text.Length;
				if (kind != global::System.DateTimeKind.Unspecified)
				{
					if (kind == global::System.DateTimeKind.Local)
					{
						num2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffset(chars, num2, offset2, format);
					}
				}
				else if (value != global::System.DateTime.MaxValue && value != global::System.DateTime.MinValue)
				{
					num2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffset(chars, num2, offset2, format);
				}
				")\\/".CopyTo(0, chars, num2, 3);
				num2 += 3;
			}
			else
			{
				num2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDefaultIsoDate(chars, start, value);
				if (kind != global::System.DateTimeKind.Utc)
				{
					if (kind == global::System.DateTimeKind.Local)
					{
						num2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffset(chars, num2, offset ?? value.GetUtcOffset(), format);
					}
				}
				else
				{
					chars[num2++] = 'Z';
				}
			}
			return num2;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00013344 File Offset: 0x00011544
		internal static int WriteDefaultIsoDate(char[] chars, int start, global::System.DateTime dt)
		{
			int num = 19;
			int value;
			int value2;
			int value3;
			global::Newtonsoft.Json.Utilities.DateTimeUtils.GetDateValues(dt, out value, out value2, out value3);
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start, value, 4);
			chars[start + 4] = '-';
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 5, value2, 2);
			chars[start + 7] = '-';
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 8, value3, 2);
			chars[start + 10] = 'T';
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 11, dt.Hour, 2);
			chars[start + 13] = ':';
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 14, dt.Minute, 2);
			chars[start + 16] = ':';
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 17, dt.Second, 2);
			int num2 = (int)(dt.Ticks % 10000000L);
			if (num2 != 0)
			{
				int num3 = 7;
				while (num2 % 10 == 0)
				{
					num3--;
					num2 /= 10;
				}
				chars[start + 19] = '.';
				global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start + 20, num2, num3);
				num += num3 + 1;
			}
			return start + num;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00013429 File Offset: 0x00011629
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
			while (digits-- != 0)
			{
				chars[start + digits] = (char)(value % 10 + 48);
				value /= 10;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00013448 File Offset: 0x00011648
		internal static int WriteDateTimeOffset(char[] chars, int start, global::System.TimeSpan offset, global::Newtonsoft.Json.DateFormatHandling format)
		{
			chars[start++] = ((offset.Ticks >= 0L) ? '+' : '-');
			int value = global::System.Math.Abs(offset.Hours);
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start, value, 2);
			start += 2;
			if (format == global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat)
			{
				chars[start++] = ':';
			}
			int value2 = global::System.Math.Abs(offset.Minutes);
			global::Newtonsoft.Json.Utilities.DateTimeUtils.CopyIntToCharArray(chars, start, value2, 2);
			start += 2;
			return start;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000134B4 File Offset: 0x000116B4
		internal static void WriteDateTimeOffsetString(global::System.IO.TextWriter writer, global::System.DateTimeOffset value, global::Newtonsoft.Json.DateFormatHandling format, [global::System.Runtime.CompilerServices.Nullable(2)] string formatString, global::System.Globalization.CultureInfo culture)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(formatString))
			{
				char[] array = new char[64];
				int count = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(array, 0, (format == global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat) ? value.DateTime : value.UtcDateTime, new global::System.TimeSpan?(value.Offset), global::System.DateTimeKind.Local, format);
				writer.Write(array, 0, count);
				return;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00013514 File Offset: 0x00011714
		private static void GetDateValues(global::System.DateTime td, out int year, out int month, out int day)
		{
			int i = (int)(td.Ticks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			year = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			i -= num4 * 365;
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? global::Newtonsoft.Json.Utilities.DateTimeUtils.DaysToMonth366 : global::Newtonsoft.Json.Utilities.DateTimeUtils.DaysToMonth365;
			int num5 = i >> 6;
			while (i >= array[num5])
			{
				num5++;
			}
			month = num5;
			day = i - array[num5 - 1] + 1;
		}

		// Token: 0x040001B0 RID: 432
		internal static readonly long InitialJavaScriptDateTicks = 621355968000000000L;

		// Token: 0x040001B1 RID: 433
		private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";

		// Token: 0x040001B2 RID: 434
		private const int DaysPer100Years = 36524;

		// Token: 0x040001B3 RID: 435
		private const int DaysPer400Years = 146097;

		// Token: 0x040001B4 RID: 436
		private const int DaysPer4Years = 1461;

		// Token: 0x040001B5 RID: 437
		private const int DaysPerYear = 365;

		// Token: 0x040001B6 RID: 438
		private const long TicksPerDay = 864000000000L;

		// Token: 0x040001B7 RID: 439
		private static readonly int[] DaysToMonth365 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x040001B8 RID: 440
		private static readonly int[] DaysToMonth366 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};
	}
}
