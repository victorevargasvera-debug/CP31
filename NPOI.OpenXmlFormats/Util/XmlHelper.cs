using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Vml;
using NPOI.OpenXmlFormats.Vml.Office;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Util
{
	// Token: 0x0200003E RID: 62
	public static class XmlHelper
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00003C44 File Offset: 0x00001E44
		public static global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank ReadTrueFalseBlank(string attrValue)
		{
			if (string.IsNullOrEmpty(attrValue))
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
			if (string.IsNullOrEmpty(attrValue))
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
			string a = attrValue.ToLower();
			if (a == "t" || a == "true")
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true;
			}
			return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00003C8C File Offset: 0x00001E8C
		public static global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank ReadTrueFalseBlank(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
			if (string.IsNullOrEmpty(attr.Value))
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE;
			}
			string a = attr.Value.ToLower();
			if (a == "t" || a == "true")
			{
				return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true;
			}
			return global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public static global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse ReadTrueFalse(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;
			}
			if (string.IsNullOrEmpty(attr.Value))
			{
				return global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;
			}
			string a = attr.Value.ToLower();
			if (a == "t" || a == "true")
			{
				return global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@true;
			}
			return global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003D24 File Offset: 0x00001F24
		public static global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow ReadBorderShadow(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@false;
			}
			if (string.IsNullOrEmpty(attr.Value))
			{
				return global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@false;
			}
			string a = attr.Value.ToLower();
			if (a == "t" || a == "true")
			{
				return global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@true;
			}
			return global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003D70 File Offset: 0x00001F70
		public static global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse ReadTrueFalse2(global::System.Xml.XmlAttribute attr)
		{
			if (attr == null)
			{
				return global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@false;
			}
			if (string.IsNullOrEmpty(attr.Value))
			{
				return global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@false;
			}
			string a = attr.Value.ToLower();
			if (a == "t" || a == "true")
			{
				return global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@true;
			}
			return global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@false;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003DBA File Offset: 0x00001FBA
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse value)
		{
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse value, bool defaultValue)
		{
			if (defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.t || value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@true))
			{
				return;
			}
			if (!defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.f || value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false))
			{
				return;
			}
			if (value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.t || value == global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse.@true)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003DFF File Offset: 0x00001FFF
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow value)
		{
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003E0A File Offset: 0x0000200A
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow value, bool defaultValue)
		{
			if (defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.t || value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@true))
			{
				return;
			}
			if (!defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.f || value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@false))
			{
				return;
			}
			if (value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.t || value == global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow.@true)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003E43 File Offset: 0x00002043
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse value)
		{
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, attributeName, value, false);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse value, bool defaultValue)
		{
			if (defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t || value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@true))
			{
				return;
			}
			if (!defaultValue && (value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.f || value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@false))
			{
				return;
			}
			if (value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t || value == global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.@true)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00003E50 File Offset: 0x00002050
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank value)
		{
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, attributeName, value, null);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003E70 File Offset: 0x00002070
		public static void WriteAttribute(global::System.IO.StreamWriter sw, string attributeName, global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank value, bool? defaultValue)
		{
			if (defaultValue == null && value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.NONE)
			{
				return;
			}
			bool? flag = defaultValue;
			bool flag2 = true;
			if ((flag.GetValueOrDefault() == flag2 & flag != null) && (value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t || value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true))
			{
				return;
			}
			flag = defaultValue;
			flag2 = false;
			if ((flag.GetValueOrDefault() == flag2 & flag != null) && (value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.f || value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false))
			{
				return;
			}
			if (value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.t || value == global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
				return;
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
		}
	}
}
