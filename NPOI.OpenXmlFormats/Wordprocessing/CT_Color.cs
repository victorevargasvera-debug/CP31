using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000153 RID: 339
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Color
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x0002119A File Offset: 0x0001F39A
		public CT_Color()
		{
			this.themeColorField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000211AC File Offset: 0x0001F3AC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color ct_Color = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color();
			ct_Color.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]);
			if (node.Attributes["w:themeColor"] != null)
			{
				ct_Color.themeColor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeColor"].Value);
			}
			ct_Color.themeTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeTint"]);
			ct_Color.themeShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeShade"]);
			return ct_Color;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00021258 File Offset: 0x0001F458
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val, true);
			if (this.themeColorField != global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeColor", this.themeColor.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeTint", this.themeTint);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeShade", this.themeShade);
			sw.Write("/>");
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000212DC File Offset: 0x0001F4DC
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000212E4 File Offset: 0x0001F4E4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string val
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000212ED File Offset: 0x0001F4ED
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000212F5 File Offset: 0x0001F4F5
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000212FE File Offset: 0x0001F4FE
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00021306 File Offset: 0x0001F506
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002130F File Offset: 0x0001F50F
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00021317 File Offset: 0x0001F517
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00021320 File Offset: 0x0001F520
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00021328 File Offset: 0x0001F528
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

		// Token: 0x04000892 RID: 2194
		private string valField;

		// Token: 0x04000893 RID: 2195
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColorField;

		// Token: 0x04000894 RID: 2196
		private bool themeColorFieldSpecified;

		// Token: 0x04000895 RID: 2197
		private byte[] themeTintField;

		// Token: 0x04000896 RID: 2198
		private byte[] themeShadeField;
	}
}
