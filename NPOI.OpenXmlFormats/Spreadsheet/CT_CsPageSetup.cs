using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C2 RID: 1474
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CsPageSetup
	{
		// Token: 0x060040E4 RID: 16612 RVA: 0x0009D820 File Offset: 0x0009BA20
		public CT_CsPageSetup()
		{
			this.paperSizeField = 1U;
			this.firstPageNumberField = 1U;
			this.orientationField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation.@default;
			this.usePrinterDefaultsField = true;
			this.blackAndWhiteField = false;
			this.draftField = false;
			this.useFirstPageNumberField = false;
			this.horizontalDpiField = 600U;
			this.verticalDpiField = 600U;
			this.copiesField = 1U;
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x0009D884 File Offset: 0x0009BA84
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup ct_CsPageSetup = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CsPageSetup();
			if (node.Attributes["paperSize"] != null)
			{
				ct_CsPageSetup.paperSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["paperSize"]);
			}
			if (node.Attributes["firstPageNumber"] != null)
			{
				ct_CsPageSetup.firstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstPageNumber"]);
			}
			if (node.Attributes["orientation"] != null)
			{
				ct_CsPageSetup.orientation = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation), node.Attributes["orientation"].Value);
			}
			if (node.Attributes["usePrinterDefaults"] != null)
			{
				ct_CsPageSetup.usePrinterDefaults = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["usePrinterDefaults"]);
			}
			if (node.Attributes["blackAndWhite"] != null)
			{
				ct_CsPageSetup.blackAndWhite = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["blackAndWhite"]);
			}
			if (node.Attributes["draft"] != null)
			{
				ct_CsPageSetup.draft = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["draft"]);
			}
			if (node.Attributes["useFirstPageNumber"] != null)
			{
				ct_CsPageSetup.useFirstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["useFirstPageNumber"]);
			}
			if (node.Attributes["horizontalDpi"] != null)
			{
				ct_CsPageSetup.horizontalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["horizontalDpi"]);
			}
			if (node.Attributes["verticalDpi"] != null)
			{
				ct_CsPageSetup.verticalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["verticalDpi"]);
			}
			if (node.Attributes["copies"] != null)
			{
				ct_CsPageSetup.copies = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["copies"]);
			}
			ct_CsPageSetup.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			return ct_CsPageSetup;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0009DA90 File Offset: 0x0009BC90
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.paperSize != 1U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "paperSize", this.paperSize, false);
			}
			if (this.paperSize != 1U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstPageNumber", this.firstPageNumber, false);
			}
			if (this.orientation != global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation.@default)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "orientation", this.orientation.ToString());
			}
			if (!this.usePrinterDefaults)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "usePrinterDefaults", this.usePrinterDefaults);
			}
			if (this.blackAndWhite)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blackAndWhite", this.blackAndWhite);
			}
			if (this.draft)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "draft", this.draft);
			}
			if (this.useFirstPageNumber)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "useFirstPageNumber", this.useFirstPageNumber);
			}
			if (this.horizontalDpi != 600U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horizontalDpi", this.horizontalDpi, false);
			}
			if (this.verticalDpi != 600U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "verticalDpi", this.verticalDpi, false);
			}
			if (this.copies != 1U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "copies", this.copies, false);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x0009DBF6 File Offset: 0x0009BDF6
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x0009DBFE File Offset: 0x0009BDFE
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint paperSize
		{
			get
			{
				return this.paperSizeField;
			}
			set
			{
				this.paperSizeField = value;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x0009DC07 File Offset: 0x0009BE07
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x0009DC0F File Offset: 0x0009BE0F
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint firstPageNumber
		{
			get
			{
				return this.firstPageNumberField;
			}
			set
			{
				this.firstPageNumberField = value;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x0009DC18 File Offset: 0x0009BE18
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x0009DC20 File Offset: 0x0009BE20
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation.@default)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation orientation
		{
			get
			{
				return this.orientationField;
			}
			set
			{
				this.orientationField = value;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x0009DC29 File Offset: 0x0009BE29
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x0009DC31 File Offset: 0x0009BE31
		[global::System.ComponentModel.DefaultValue(true)]
		public bool usePrinterDefaults
		{
			get
			{
				return this.usePrinterDefaultsField;
			}
			set
			{
				this.usePrinterDefaultsField = value;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x0009DC3A File Offset: 0x0009BE3A
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x0009DC42 File Offset: 0x0009BE42
		[global::System.ComponentModel.DefaultValue(false)]
		public bool blackAndWhite
		{
			get
			{
				return this.blackAndWhiteField;
			}
			set
			{
				this.blackAndWhiteField = value;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x0009DC4B File Offset: 0x0009BE4B
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x0009DC53 File Offset: 0x0009BE53
		[global::System.ComponentModel.DefaultValue(false)]
		public bool draft
		{
			get
			{
				return this.draftField;
			}
			set
			{
				this.draftField = value;
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x0009DC5C File Offset: 0x0009BE5C
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x0009DC64 File Offset: 0x0009BE64
		[global::System.ComponentModel.DefaultValue(false)]
		public bool useFirstPageNumber
		{
			get
			{
				return this.useFirstPageNumberField;
			}
			set
			{
				this.useFirstPageNumberField = value;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x0009DC6D File Offset: 0x0009BE6D
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x0009DC75 File Offset: 0x0009BE75
		[global::System.ComponentModel.DefaultValue(typeof(uint), "600")]
		public uint horizontalDpi
		{
			get
			{
				return this.horizontalDpiField;
			}
			set
			{
				this.horizontalDpiField = value;
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x0009DC7E File Offset: 0x0009BE7E
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x0009DC86 File Offset: 0x0009BE86
		[global::System.ComponentModel.DefaultValue(typeof(uint), "600")]
		public uint verticalDpi
		{
			get
			{
				return this.verticalDpiField;
			}
			set
			{
				this.verticalDpiField = value;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x0009DC8F File Offset: 0x0009BE8F
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x0009DC97 File Offset: 0x0009BE97
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint copies
		{
			get
			{
				return this.copiesField;
			}
			set
			{
				this.copiesField = value;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x0009DCA0 File Offset: 0x0009BEA0
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x0009DCA8 File Offset: 0x0009BEA8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x0400290F RID: 10511
		private uint paperSizeField;

		// Token: 0x04002910 RID: 10512
		private uint firstPageNumberField;

		// Token: 0x04002911 RID: 10513
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation orientationField;

		// Token: 0x04002912 RID: 10514
		private bool usePrinterDefaultsField;

		// Token: 0x04002913 RID: 10515
		private bool blackAndWhiteField;

		// Token: 0x04002914 RID: 10516
		private bool draftField;

		// Token: 0x04002915 RID: 10517
		private bool useFirstPageNumberField;

		// Token: 0x04002916 RID: 10518
		private uint horizontalDpiField;

		// Token: 0x04002917 RID: 10519
		private uint verticalDpiField;

		// Token: 0x04002918 RID: 10520
		private uint copiesField;

		// Token: 0x04002919 RID: 10521
		private string idField;
	}
}
