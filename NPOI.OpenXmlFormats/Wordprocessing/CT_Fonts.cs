using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200008C RID: 140
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Fonts
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x0000B460 File Offset: 0x00009660
		public CT_Fonts()
		{
			this.hintField = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint.@default;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000B470 File Offset: 0x00009670
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts();
			ct_Fonts.ascii = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:ascii"]);
			ct_Fonts.hAnsi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:hAnsi"]);
			ct_Fonts.eastAsia = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:eastAsia"]);
			ct_Fonts.cs = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cs"]);
			if (node.Attributes["w:hint"] != null)
			{
				ct_Fonts.hint = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint), node.Attributes["w:hint"].Value);
				ct_Fonts.hintFieldSpecified = true;
			}
			if (node.Attributes["w:asciiTheme"] != null)
			{
				ct_Fonts.asciiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?((global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme), node.Attributes["w:asciiTheme"].Value));
			}
			if (node.Attributes["w:hAnsiTheme"] != null)
			{
				ct_Fonts.hAnsiTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?((global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme), node.Attributes["w:hAnsiTheme"].Value));
			}
			if (node.Attributes["w:eastAsiaTheme"] != null)
			{
				ct_Fonts.eastAsiaTheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?((global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme), node.Attributes["w:eastAsiaTheme"].Value));
			}
			if (node.Attributes["w:cstheme"] != null)
			{
				ct_Fonts.cstheme = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme?((global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme), node.Attributes["w:cstheme"].Value));
			}
			return ct_Fonts;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000B658 File Offset: 0x00009858
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.hint != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint.@default || this.hintFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hint", this.hint.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:ascii", this.ascii);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hAnsi", this.hAnsi);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:eastAsia", this.eastAsia);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cs", this.cs);
			if (this.asciiTheme != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:asciiTheme", this.asciiTheme.ToString());
			}
			if (this.eastAsiaTheme != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:eastAsiaTheme", this.eastAsiaTheme.ToString());
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? hAnsiTheme = this.hAnsiTheme;
			global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme st_Theme = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme.majorEastAsia;
			if (!(hAnsiTheme.GetValueOrDefault() == st_Theme & hAnsiTheme != null))
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hAnsiTheme", this.hAnsiTheme.ToString());
			}
			if (this.cstheme != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cstheme", this.cstheme.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000B7BD File Offset: 0x000099BD
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000B7C5 File Offset: 0x000099C5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint hint
		{
			get
			{
				return this.hintField;
			}
			set
			{
				this.hintField = value;
				this.hintFieldSpecified = true;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000B7D5 File Offset: 0x000099D5
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000B7DD File Offset: 0x000099DD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hintSpecified
		{
			get
			{
				return this.hintFieldSpecified;
			}
			set
			{
				this.hintFieldSpecified = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000B7E6 File Offset: 0x000099E6
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000B7EE File Offset: 0x000099EE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string ascii
		{
			get
			{
				return this.asciiField;
			}
			set
			{
				this.asciiField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000B7F7 File Offset: 0x000099F7
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000B7FF File Offset: 0x000099FF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string hAnsi
		{
			get
			{
				return this.hAnsiField;
			}
			set
			{
				this.hAnsiField = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000B808 File Offset: 0x00009A08
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000B810 File Offset: 0x00009A10
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string eastAsia
		{
			get
			{
				return this.eastAsiaField;
			}
			set
			{
				this.eastAsiaField = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000B819 File Offset: 0x00009A19
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000B821 File Offset: 0x00009A21
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000B82A File Offset: 0x00009A2A
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000B832 File Offset: 0x00009A32
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? asciiTheme
		{
			get
			{
				return this.asciiThemeField;
			}
			set
			{
				this.asciiThemeField = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000B83B File Offset: 0x00009A3B
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000B843 File Offset: 0x00009A43
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? hAnsiTheme
		{
			get
			{
				return this.hAnsiThemeField;
			}
			set
			{
				this.hAnsiThemeField = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000B84C File Offset: 0x00009A4C
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000B854 File Offset: 0x00009A54
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? eastAsiaTheme
		{
			get
			{
				return this.eastAsiaThemeField;
			}
			set
			{
				this.eastAsiaThemeField = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000B85D File Offset: 0x00009A5D
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000B865 File Offset: 0x00009A65
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? cstheme
		{
			get
			{
				return this.csthemeField;
			}
			set
			{
				this.csthemeField = value;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000B86E File Offset: 0x00009A6E
		public bool IsSetHAnsi()
		{
			return !string.IsNullOrEmpty(this.hAnsiField);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000B87E File Offset: 0x00009A7E
		public bool IsSetCs()
		{
			return !string.IsNullOrEmpty(this.csField);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000B88E File Offset: 0x00009A8E
		public bool IsSetEastAsia()
		{
			return !string.IsNullOrEmpty(this.eastAsiaField);
		}

		// Token: 0x04000377 RID: 887
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint hintField;

		// Token: 0x04000378 RID: 888
		private bool hintFieldSpecified;

		// Token: 0x04000379 RID: 889
		private string asciiField;

		// Token: 0x0400037A RID: 890
		private string hAnsiField;

		// Token: 0x0400037B RID: 891
		private string eastAsiaField;

		// Token: 0x0400037C RID: 892
		private string csField;

		// Token: 0x0400037D RID: 893
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? asciiThemeField;

		// Token: 0x0400037E RID: 894
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? hAnsiThemeField;

		// Token: 0x0400037F RID: 895
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? eastAsiaThemeField;

		// Token: 0x04000380 RID: 896
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Theme? csthemeField;
	}
}
