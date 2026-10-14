using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000154 RID: 340
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Underline
	{
		// Token: 0x06000985 RID: 2437 RVA: 0x00021331 File Offset: 0x0001F531
		public CT_Underline()
		{
			this.themeColorField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor.none;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00021340 File Offset: 0x0001F540
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline ct_Underline = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline();
			if (node.Attributes["w:val"] != null)
			{
				ct_Underline.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline), node.Attributes["w:val"].Value);
			}
			ct_Underline.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:color"]);
			if (node.Attributes["w:themeColor"] != null)
			{
				ct_Underline.themeColor = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor), node.Attributes["w:themeColor"].Value);
			}
			ct_Underline.themeTint = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeTint"]);
			ct_Underline.themeShade = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:themeShade"]);
			return ct_Underline;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002142C File Offset: 0x0001F62C
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
			sw.Write("/>");
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000214CE File Offset: 0x0001F6CE
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x000214D6 File Offset: 0x0001F6D6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline val
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000214DF File Offset: 0x0001F6DF
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000214E7 File Offset: 0x0001F6E7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000214F0 File Offset: 0x0001F6F0
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000214F8 File Offset: 0x0001F6F8
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00021501 File Offset: 0x0001F701
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00021509 File Offset: 0x0001F709
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00021512 File Offset: 0x0001F712
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0002151A File Offset: 0x0001F71A
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00021523 File Offset: 0x0001F723
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0002152B File Offset: 0x0001F72B
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00021534 File Offset: 0x0001F734
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0002153C File Offset: 0x0001F73C
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

		// Token: 0x04000897 RID: 2199
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline valField;

		// Token: 0x04000898 RID: 2200
		private bool valFieldSpecified;

		// Token: 0x04000899 RID: 2201
		private string colorField;

		// Token: 0x0400089A RID: 2202
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ThemeColor themeColorField;

		// Token: 0x0400089B RID: 2203
		private bool themeColorFieldSpecified;

		// Token: 0x0400089C RID: 2204
		private byte[] themeTintField;

		// Token: 0x0400089D RID: 2205
		private byte[] themeShadeField;
	}
}
