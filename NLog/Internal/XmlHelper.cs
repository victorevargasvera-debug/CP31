using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace NLog.Internal
{
	// Token: 0x02000133 RID: 307
	public static class XmlHelper
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00023534 File Offset: 0x00021734
		private static string RemoveInvalidXmlChars(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			for (int i = 0; i < text.Length; i++)
			{
				if (!global::System.Xml.XmlConvert.IsXmlChar(text[i]))
				{
					return global::NLog.Internal.XmlHelper.CreateValidXmlString(text);
				}
			}
			return text;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00023578 File Offset: 0x00021778
		private static string CreateValidXmlString(string text)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length);
			foreach (char c in text)
			{
				if (global::System.Xml.XmlConvert.IsXmlChar(c))
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000235C0 File Offset: 0x000217C0
		internal static string XmlConvertToStringSafe(object value)
		{
			return global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(global::NLog.Internal.XmlHelper.XmlConvertToString(value));
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000235D0 File Offset: 0x000217D0
		internal static string XmlConvertToString(object value)
		{
			global::System.TypeCode typeCode = global::System.Convert.GetTypeCode(value);
			return global::NLog.Internal.XmlHelper.XmlConvertToString(value, typeCode);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000235EC File Offset: 0x000217EC
		internal static string XmlConvertToString(object value, global::System.TypeCode objTypeCode)
		{
			if (value == null)
			{
				return "null";
			}
			switch (objTypeCode)
			{
			case global::System.TypeCode.Boolean:
				return global::System.Xml.XmlConvert.ToString((bool)value);
			case global::System.TypeCode.Char:
				return global::System.Xml.XmlConvert.ToString((char)value);
			case global::System.TypeCode.SByte:
				return global::System.Xml.XmlConvert.ToString((sbyte)value);
			case global::System.TypeCode.Byte:
				return global::System.Xml.XmlConvert.ToString((byte)value);
			case global::System.TypeCode.Int16:
				return global::System.Xml.XmlConvert.ToString((short)value);
			case global::System.TypeCode.UInt16:
				return global::System.Xml.XmlConvert.ToString((ushort)value);
			case global::System.TypeCode.Int32:
				return global::System.Xml.XmlConvert.ToString((int)value);
			case global::System.TypeCode.UInt32:
				return global::System.Xml.XmlConvert.ToString((uint)value);
			case global::System.TypeCode.Int64:
				return global::System.Xml.XmlConvert.ToString((long)value);
			case global::System.TypeCode.UInt64:
				return global::System.Xml.XmlConvert.ToString((ulong)value);
			case global::System.TypeCode.Single:
			{
				float num = (float)value;
				if (float.IsInfinity(num))
				{
					return global::System.Convert.ToString(num, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				return global::System.Xml.XmlConvert.ToString(num);
			}
			case global::System.TypeCode.Double:
			{
				double num2 = (double)value;
				if (double.IsInfinity(num2))
				{
					return global::System.Convert.ToString(num2, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				return global::System.Xml.XmlConvert.ToString(num2);
			}
			case global::System.TypeCode.Decimal:
				return global::System.Xml.XmlConvert.ToString((decimal)value);
			case global::System.TypeCode.DateTime:
				return global::System.Xml.XmlConvert.ToString((global::System.DateTime)value, global::System.Xml.XmlDateTimeSerializationMode.Utc);
			case global::System.TypeCode.String:
				return (string)value;
			}
			string result;
			try
			{
				result = global::System.Convert.ToString(value, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00023750 File Offset: 0x00021950
		public static void WriteAttributeSafeString(this global::System.Xml.XmlWriter writer, string prefix, string localName, string ns, string value)
		{
			writer.WriteAttributeString(global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(prefix), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(localName), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(ns), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(value));
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00023771 File Offset: 0x00021971
		public static void WriteAttributeSafeString(this global::System.Xml.XmlWriter writer, string thread, string localName)
		{
			writer.WriteAttributeString(global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(thread), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(localName));
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00023785 File Offset: 0x00021985
		public static void WriteElementSafeString(this global::System.Xml.XmlWriter writer, string prefix, string localName, string ns, string value)
		{
			writer.WriteElementString(global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(prefix), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(localName), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(ns), global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(value));
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000237A6 File Offset: 0x000219A6
		public static void WriteSafeCData(this global::System.Xml.XmlWriter writer, string text)
		{
			writer.WriteCData(global::NLog.Internal.XmlHelper.RemoveInvalidXmlChars(text));
		}

		// Token: 0x040003DB RID: 987
		private static readonly global::System.Text.RegularExpressions.Regex InvalidXmlChars = new global::System.Text.RegularExpressions.Regex("(?<![\\uD800-\\uDBFF])[\\uDC00-\\uDFFF]|[\\uD800-\\uDBFF](?![\\uDC00-\\uDFFF])|[\\x00-\\x08\\x0B\\x0C\\x0E-\\x1F\\x7F-\\x9F\\uFEFF\\uFFFE\\uFFFF]", global::System.Text.RegularExpressions.RegexOptions.Compiled);
	}
}
