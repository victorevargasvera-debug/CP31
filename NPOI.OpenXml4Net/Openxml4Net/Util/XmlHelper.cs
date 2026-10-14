using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXml4Net.Util
{
	// Token: 0x02000008 RID: 8
	public static class XmlHelper
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000021F8 File Offset: 0x000003F8
		public static T ReadEnum<T>(global::System.Xml.XmlAttribute attr)
		{
			if (attr != null)
			{
				return (T)((object)global::System.Enum.Parse(typeof(T), attr.Value));
			}
			return default(T);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000222C File Offset: 0x0000042C
		public static string GetEnumValue(global::System.Enum e)
		{
			global::System.Reflection.FieldInfo field = e.GetType().GetField(e.ToString("G"));
			if (!field.IsDefined(typeof(global::System.Xml.Serialization.XmlEnumAttribute), false))
			{
				return e.ToString("G");
			}
			return ((global::System.Xml.Serialization.XmlEnumAttribute)field.GetCustomAttributes(typeof(global::System.Xml.Serialization.XmlEnumAttribute), false)[0]).Name;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000228C File Offset: 0x0000048C
		public static string GetXmlAttrNameFromEnumValue<T>(T pEnumVal)
		{
			return ((global::System.Xml.Serialization.XmlEnumAttribute)pEnumVal.GetType().GetField(global::System.Enum.GetName(typeof(T), pEnumVal)).GetCustomAttributes(typeof(global::System.Xml.Serialization.XmlEnumAttribute), false)[0]).Name;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022DC File Offset: 0x000004DC
		public static T GetEnumValueFromString<T>(string value)
		{
			foreach (object obj in global::System.Enum.GetValues(typeof(T)))
			{
				if (global::NPOI.OpenXml4Net.Util.XmlHelper.GetXmlAttrNameFromEnumValue<T>((T)((object)obj)).Equals(value, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return (T)((object)obj);
				}
			}
			throw new global::System.ArgumentException("No XmlEnumAttribute code exists for type " + typeof(T).ToString() + " corresponding to value of " + value);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002378 File Offset: 0x00000578
		public static int ReadInt(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0;
			}
			int result;
			if (int.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000239C File Offset: 0x0000059C
		public static long ReadLong(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0L;
			}
			long result;
			if (long.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0L;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023C4 File Offset: 0x000005C4
		public static int? ReadIntNull(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return null;
			}
			string value = attr.Value;
			int value2;
			if (value != "" && int.TryParse(value, out value2))
			{
				return new int?(value2);
			}
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000240C File Offset: 0x0000060C
		public static string ReadString(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return null;
			}
			return attr.Value;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000241C File Offset: 0x0000061C
		public static decimal ReadDecimal(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0m;
			}
			decimal result;
			if (decimal.TryParse(attr.Value, global::System.Globalization.NumberStyles.Any, global::System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				return result;
			}
			return 0m;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002454 File Offset: 0x00000654
		public static uint ReadUInt(global::System.Xml.XmlAttribute attr, uint defaultValue)
		{
			if (attr == null)
			{
				return defaultValue;
			}
			uint result;
			if (uint.TryParse(attr.Value, out result))
			{
				return result;
			}
			return defaultValue;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002478 File Offset: 0x00000678
		public static uint ReadUInt(global::System.Xml.XmlAttribute attr)
		{
			return global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(attr, 0U);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002484 File Offset: 0x00000684
		public static ulong ReadULong(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0UL;
			}
			ulong result;
			if (ulong.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0UL;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024AA File Offset: 0x000006AA
		public static bool ReadBool(global::System.Xml.XmlAttribute attr)
		{
			return global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(attr, false);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024B4 File Offset: 0x000006B4
		public static double ReadDouble(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0.0;
			}
			string value = attr.Value;
			if (value == "")
			{
				return 0.0;
			}
			double result;
			if (double.TryParse(value, global::System.Globalization.NumberStyles.Number, global::System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				return result;
			}
			return 0.0;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002508 File Offset: 0x00000708
		public static double? ReadDoubleNull(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return null;
			}
			string value = attr.Value;
			if (value == "")
			{
				return null;
			}
			double value2;
			if (double.TryParse(value, global::System.Globalization.NumberStyles.Number, global::System.Globalization.CultureInfo.InvariantCulture, out value2))
			{
				return new double?(value2);
			}
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002564 File Offset: 0x00000764
		public static bool ReadBool(global::System.Xml.XmlAttribute attr, bool blankValue)
		{
			if (attr == null)
			{
				return blankValue;
			}
			string value = attr.Value;
			return value == "1" || value == "-1" || value.ToLower() == "true" || value.ToLower() == "on" || (string.IsNullOrEmpty(value) && blankValue);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025C8 File Offset: 0x000007C8
		public static global::System.DateTime? ReadDateTime(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return null;
			}
			return new global::System.DateTime?(global::System.DateTime.Parse(attr.Value));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025F4 File Offset: 0x000007F4
		public static string ExcelEncodeString(string t)
		{
			global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter();
			for (int i = 0; i < t.Length; i++)
			{
				if (t[i] <= '\u001f' && t[i] != '\t' && t[i] != '\n' && t[i] != '\r')
				{
					stringWriter.Write('?');
				}
				else if (t[i] == '￾')
				{
					stringWriter.Write('?');
				}
				else
				{
					stringWriter.Write(t[i]);
				}
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000267C File Offset: 0x0000087C
		public static string ExcelDecodeString(string t)
		{
			global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(t, "(_x005F|_x[0-9A-F]{4,4}_)");
			if (!match.Success)
			{
				return t;
			}
			bool flag = false;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			while (match.Success)
			{
				if (num < match.Index)
				{
					stringBuilder.Append(t.Substring(num, match.Index - num));
				}
				if (!flag && match.Value == "_x005F")
				{
					flag = true;
				}
				else if (flag)
				{
					stringBuilder.Append(match.Value);
					flag = false;
				}
				else
				{
					stringBuilder.Append((char)int.Parse(match.Value.Substring(2, 4)));
				}
				num = match.Index + match.Length;
				match = match.NextMatch();
			}
			stringBuilder.Append(t.Substring(num, t.Length - num));
			return stringBuilder.ToString();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000274D File Offset: 0x0000094D
		public static string EncodeXml(string xml)
		{
			return xml.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000278C File Offset: 0x0000098C
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, bool value)
		{
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value, true);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002797 File Offset: 0x00000997
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, bool value, bool writeIfBlank)
		{
			if (!value && !writeIfBlank)
			{
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value ? "1" : "0");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000027B6 File Offset: 0x000009B6
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, double value)
		{
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000027C1 File Offset: 0x000009C1
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, double value, bool writeIfBlank)
		{
			if (value == 0.0 && !writeIfBlank)
			{
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, (value == 0.0) ? "0" : value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000027F9 File Offset: 0x000009F9
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, int value, bool writeIfBlank)
		{
			if (value == 0 && !writeIfBlank)
			{
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002815 File Offset: 0x00000A15
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, int value)
		{
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002820 File Offset: 0x00000A20
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, string value)
		{
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000282B File Offset: 0x00000A2B
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, string value, bool writeIfBlank)
		{
			if (string.IsNullOrEmpty(value) && !writeIfBlank)
			{
				return;
			}
			sw.Write(string.Format(" {0}=\"{1}\"", attributeName, (value == null) ? string.Empty : global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(value)));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000285A File Offset: 0x00000A5A
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, byte[] value)
		{
			if (value == null)
			{
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, global::System.BitConverter.ToString(value).Replace("-", ""), false);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000287D File Offset: 0x00000A7D
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, uint value, uint defaultValue, bool writeIfBlank = false)
		{
			if (value != defaultValue)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, (int)value, true);
				return;
			}
			if (writeIfBlank)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, (int)value, writeIfBlank);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000289B File Offset: 0x00000A9B
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, uint value, bool writeIfBlank = false)
		{
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, (int)value, writeIfBlank);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000028A6 File Offset: 0x00000AA6
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::System.DateTime? value)
		{
			if (value == null)
			{
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, value.ToString(), false);
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028CC File Offset: 0x00000ACC
		public static void LoadXmlSafe(global::System.Xml.XmlDocument xmlDoc, global::System.IO.Stream stream)
		{
			global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(stream, new global::System.Xml.XmlReaderSettings
			{
				XmlResolver = null,
				ProhibitDtd = true
			});
			xmlDoc.Load(reader);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028FC File Offset: 0x00000AFC
		public static void LoadXmlSafe(global::System.Xml.XmlDocument xmlDoc, string xml, global::System.Text.Encoding encoding)
		{
			global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream(encoding.GetBytes(xml));
			global::NPOI.OpenXml4Net.Util.XmlHelper.LoadXmlSafe(xmlDoc, stream);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002920 File Offset: 0x00000B20
		public static byte[] ReadBytes(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null || string.IsNullOrEmpty(attr.Value))
			{
				return null;
			}
			int length = attr.Value.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = global::System.Convert.ToByte(attr.Value.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000297C File Offset: 0x00000B7C
		public static sbyte ReadSByte(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0;
			}
			sbyte result;
			if (sbyte.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029A0 File Offset: 0x00000BA0
		public static ushort ReadUShort(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0;
			}
			ushort result;
			if (ushort.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static byte ReadByte(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return 0;
			}
			byte result;
			if (byte.TryParse(attr.Value, out result))
			{
				return result;
			}
			return 0;
		}
	}
}
