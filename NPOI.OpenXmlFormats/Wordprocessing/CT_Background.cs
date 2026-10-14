using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012D RID: 301
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Background : global::NPOI.OpenXmlFormats.Wordprocessing.CT_PictureBase
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x0001B948 File Offset: 0x00019B48
		public CT_Background()
		{
			this.themeColorField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001B958 File Offset: 0x00019B58
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background ct_Background = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background();
			ct_Background.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:color"]);
			if (node.Attributes["w:themeColor"] != null)
			{
				ct_Background.themeColor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeColor"].Value);
			}
			ct_Background.themeTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeTint"]);
			ct_Background.themeShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeShade"]);
			return ct_Background;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0001BA04 File Offset: 0x00019C04
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.themeColorField != global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeColor", this.themeColor.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeTint", this.themeTint);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:themeShade", this.themeShade);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:color", this.color);
			sw.Write("/>");
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0001BA87 File Offset: 0x00019C87
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0001BA8F File Offset: 0x00019C8F
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0001BA98 File Offset: 0x00019C98
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0001BAA0 File Offset: 0x00019CA0
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

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0001BAA9 File Offset: 0x00019CA9
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x0001BAB1 File Offset: 0x00019CB1
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0001BABA File Offset: 0x00019CBA
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0001BAC2 File Offset: 0x00019CC2
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

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0001BACB File Offset: 0x00019CCB
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0001BAD3 File Offset: 0x00019CD3
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

		// Token: 0x0400073C RID: 1852
		private string colorField;

		// Token: 0x0400073D RID: 1853
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColorField;

		// Token: 0x0400073E RID: 1854
		private bool themeColorFieldSpecified;

		// Token: 0x0400073F RID: 1855
		private byte[] themeTintField;

		// Token: 0x04000740 RID: 1856
		private byte[] themeShadeField;
	}
}
