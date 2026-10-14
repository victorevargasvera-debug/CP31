using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200014F RID: 335
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shd
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x00020D0D File Offset: 0x0001EF0D
		public CT_Shd()
		{
			this.themeColorField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
			this.themeFillField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00020D24 File Offset: 0x0001EF24
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd();
			if (node.Attributes["w:val"] != null)
			{
				ct_Shd.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd), node.Attributes["w:val"].Value);
			}
			ct_Shd.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:color"]);
			if (node.Attributes["w:themeColor"] != null)
			{
				ct_Shd.themeColor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeColor"].Value);
			}
			ct_Shd.themeTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeTint"]);
			ct_Shd.themeShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeShade"]);
			ct_Shd.fill = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:fill"]);
			if (node.Attributes["w:themeFill"] != null)
			{
				ct_Shd.themeFill = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeFill"].Value);
			}
			ct_Shd.themeFillTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeFillTint"]);
			ct_Shd.themeFillShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeFillShade"]);
			return ct_Shd;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00020EA4 File Offset: 0x0001F0A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:color", this.color);
			if (this.themeColor != global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeColor", this.themeColor.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeTint", this.themeTint);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeShade", this.themeShade);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:fill", this.fill);
			if (this.themeFill != global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeFill", this.themeFill.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeFillTint", this.themeFillTint);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeFillShade", this.themeFillShade);
			sw.Write("/>");
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00020FB1 File Offset: 0x0001F1B1
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00020FB9 File Offset: 0x0001F1B9
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00020FC2 File Offset: 0x0001F1C2
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00020FCA File Offset: 0x0001F1CA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColor
		{
			get
			{
				return this.themeColorField;
			}
			set
			{
				this.themeColorField = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00020FD3 File Offset: 0x0001F1D3
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00020FDB File Offset: 0x0001F1DB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool themeColorSpecified
		{
			get
			{
				return this.themeColorFieldSpecified;
			}
			set
			{
				this.themeColorFieldSpecified = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00020FEC File Offset: 0x0001F1EC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeTint
		{
			get
			{
				return this.themeTintField;
			}
			set
			{
				this.themeTintField = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00020FF5 File Offset: 0x0001F1F5
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00020FFD File Offset: 0x0001F1FD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeShade
		{
			get
			{
				return this.themeShadeField;
			}
			set
			{
				this.themeShadeField = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00021006 File Offset: 0x0001F206
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0002100E File Offset: 0x0001F20E
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00021017 File Offset: 0x0001F217
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0002101F File Offset: 0x0001F21F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeFill
		{
			get
			{
				return this.themeFillField;
			}
			set
			{
				this.themeFillField = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00021028 File Offset: 0x0001F228
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00021030 File Offset: 0x0001F230
		[global::System.Xml.Serialization.XmlIgnore]
		public bool themeFillSpecified
		{
			get
			{
				return this.themeFillFieldSpecified;
			}
			set
			{
				this.themeFillFieldSpecified = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00021039 File Offset: 0x0001F239
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00021041 File Offset: 0x0001F241
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeFillTint
		{
			get
			{
				return this.themeFillTintField;
			}
			set
			{
				this.themeFillTintField = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002104A File Offset: 0x0001F24A
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00021052 File Offset: 0x0001F252
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] themeFillShade
		{
			get
			{
				return this.themeFillShadeField;
			}
			set
			{
				this.themeFillShadeField = value;
			}
		}

		// Token: 0x0400085E RID: 2142
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd valField;

		// Token: 0x0400085F RID: 2143
		private string colorField;

		// Token: 0x04000860 RID: 2144
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColorField;

		// Token: 0x04000861 RID: 2145
		private bool themeColorFieldSpecified;

		// Token: 0x04000862 RID: 2146
		private byte[] themeTintField;

		// Token: 0x04000863 RID: 2147
		private byte[] themeShadeField;

		// Token: 0x04000864 RID: 2148
		private string fillField;

		// Token: 0x04000865 RID: 2149
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeFillField;

		// Token: 0x04000866 RID: 2150
		private bool themeFillFieldSpecified;

		// Token: 0x04000867 RID: 2151
		private byte[] themeFillTintField;

		// Token: 0x04000868 RID: 2152
		private byte[] themeFillShadeField;
	}
}
