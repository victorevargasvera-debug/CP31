using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000596 RID: 1430
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PageSetup
	{
		// Token: 0x06003F0C RID: 16140 RVA: 0x00098CAC File Offset: 0x00096EAC
		public CT_PageSetup()
		{
			this.paperSizeField = 1U;
			this.scaleField = 100U;
			this.firstPageNumberField = 1U;
			this.fitToWidthField = 1U;
			this.fitToHeightField = 1U;
			this.pageOrderField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder.downThenOver;
			this.orientationField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation.@default;
			this.usePrinterDefaultsField = true;
			this.blackAndWhiteField = false;
			this.draftField = false;
			this.cellCommentsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments.none;
			this.useFirstPageNumberField = false;
			this.errorsField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError.displayed;
			this.horizontalDpiField = 600U;
			this.verticalDpiField = 600U;
			this.copiesField = 1U;
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x00098D38 File Offset: 0x00096F38
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x00098D40 File Offset: 0x00096F40
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x00098D49 File Offset: 0x00096F49
		// (set) Token: 0x06003F10 RID: 16144 RVA: 0x00098D51 File Offset: 0x00096F51
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint scale
		{
			get
			{
				return this.scaleField;
			}
			set
			{
				this.scaleField = value;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x00098D5A File Offset: 0x00096F5A
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x00098D62 File Offset: 0x00096F62
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x00098D6B File Offset: 0x00096F6B
		// (set) Token: 0x06003F14 RID: 16148 RVA: 0x00098D73 File Offset: 0x00096F73
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint fitToWidth
		{
			get
			{
				return this.fitToWidthField;
			}
			set
			{
				this.fitToWidthField = value;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x00098D7C File Offset: 0x00096F7C
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x00098D84 File Offset: 0x00096F84
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint fitToHeight
		{
			get
			{
				return this.fitToHeightField;
			}
			set
			{
				this.fitToHeightField = value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x00098D8D File Offset: 0x00096F8D
		// (set) Token: 0x06003F18 RID: 16152 RVA: 0x00098D95 File Offset: 0x00096F95
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder.downThenOver)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder pageOrder
		{
			get
			{
				return this.pageOrderField;
			}
			set
			{
				this.pageOrderField = value;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06003F19 RID: 16153 RVA: 0x00098D9E File Offset: 0x00096F9E
		// (set) Token: 0x06003F1A RID: 16154 RVA: 0x00098DA6 File Offset: 0x00096FA6
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x00098DAF File Offset: 0x00096FAF
		// (set) Token: 0x06003F1C RID: 16156 RVA: 0x00098DB7 File Offset: 0x00096FB7
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06003F1D RID: 16157 RVA: 0x00098DC0 File Offset: 0x00096FC0
		// (set) Token: 0x06003F1E RID: 16158 RVA: 0x00098DC8 File Offset: 0x00096FC8
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06003F1F RID: 16159 RVA: 0x00098DD1 File Offset: 0x00096FD1
		// (set) Token: 0x06003F20 RID: 16160 RVA: 0x00098DD9 File Offset: 0x00096FD9
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x00098DE2 File Offset: 0x00096FE2
		// (set) Token: 0x06003F22 RID: 16162 RVA: 0x00098DEA File Offset: 0x00096FEA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments cellComments
		{
			get
			{
				return this.cellCommentsField;
			}
			set
			{
				this.cellCommentsField = value;
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x00098DF3 File Offset: 0x00096FF3
		// (set) Token: 0x06003F24 RID: 16164 RVA: 0x00098DFB File Offset: 0x00096FFB
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x00098E04 File Offset: 0x00097004
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x00098E0C File Offset: 0x0009700C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError.displayed)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError errors
		{
			get
			{
				return this.errorsField;
			}
			set
			{
				this.errorsField = value;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x00098E15 File Offset: 0x00097015
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x00098E1D File Offset: 0x0009701D
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x00098E26 File Offset: 0x00097026
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x00098E2E File Offset: 0x0009702E
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x00098E37 File Offset: 0x00097037
		// (set) Token: 0x06003F2C RID: 16172 RVA: 0x00098E3F File Offset: 0x0009703F
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x00098E48 File Offset: 0x00097048
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x00098E50 File Offset: 0x00097050
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

		// Token: 0x06003F2F RID: 16175 RVA: 0x00098E5C File Offset: 0x0009705C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup ct_PageSetup = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup();
			ct_PageSetup.paperSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["paperSize"], 1U);
			ct_PageSetup.scale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["scale"], 100U);
			ct_PageSetup.firstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstPageNumber"], 1U);
			ct_PageSetup.fitToWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fitToWidth"], 1U);
			ct_PageSetup.fitToHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["fitToHeight"], 1U);
			if (node.Attributes["pageOrder"] != null)
			{
				ct_PageSetup.pageOrder = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder), node.Attributes["pageOrder"].Value);
			}
			if (node.Attributes["orientation"] != null)
			{
				ct_PageSetup.orientation = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation), node.Attributes["orientation"].Value);
			}
			ct_PageSetup.usePrinterDefaults = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["usePrinterDefaults"], true);
			ct_PageSetup.blackAndWhite = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["blackAndWhite"]);
			ct_PageSetup.draft = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["draft"]);
			if (node.Attributes["cellComments"] != null)
			{
				ct_PageSetup.cellComments = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments), node.Attributes["cellComments"].Value);
			}
			ct_PageSetup.useFirstPageNumber = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["useFirstPageNumber"]);
			if (node.Attributes["errors"] != null)
			{
				ct_PageSetup.errors = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError), node.Attributes["errors"].Value);
			}
			ct_PageSetup.horizontalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["horizontalDpi"], 600U);
			ct_PageSetup.verticalDpi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["verticalDpi"], 600U);
			ct_PageSetup.copies = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["copies"], 1U);
			ct_PageSetup.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]);
			return ct_PageSetup;
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x000990F0 File Offset: 0x000972F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "paperSize", this.paperSize, 1U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scale", this.scale, 100U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstPageNumber", this.firstPageNumber, 1U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fitToWidth", this.fitToWidth, 1U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fitToHeight", this.fitToHeight, 1U, false);
			if (this.pageOrder != global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder.downThenOver)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pageOrder", this.pageOrder.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "orientation", this.orientation.ToString());
			if (!this.usePrinterDefaults)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "usePrinterDefaults", this.usePrinterDefaults);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blackAndWhite", this.blackAndWhite, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "draft", this.draft, false);
			if (this.cellComments != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cellComments", this.cellComments.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "useFirstPageNumber", this.useFirstPageNumber, false);
			if (this.errors != global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError.displayed)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "errors", this.errors.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horizontalDpi", this.horizontalDpi, 600U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "verticalDpi", this.verticalDpi, 600U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "copies", this.copies, 1U, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write("/>");
		}

		// Token: 0x040027E9 RID: 10217
		private uint paperSizeField;

		// Token: 0x040027EA RID: 10218
		private uint scaleField;

		// Token: 0x040027EB RID: 10219
		private uint firstPageNumberField;

		// Token: 0x040027EC RID: 10220
		private uint fitToWidthField;

		// Token: 0x040027ED RID: 10221
		private uint fitToHeightField;

		// Token: 0x040027EE RID: 10222
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder pageOrderField;

		// Token: 0x040027EF RID: 10223
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation orientationField;

		// Token: 0x040027F0 RID: 10224
		private bool usePrinterDefaultsField;

		// Token: 0x040027F1 RID: 10225
		private bool blackAndWhiteField;

		// Token: 0x040027F2 RID: 10226
		private bool draftField;

		// Token: 0x040027F3 RID: 10227
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments cellCommentsField;

		// Token: 0x040027F4 RID: 10228
		private bool useFirstPageNumberField;

		// Token: 0x040027F5 RID: 10229
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError errorsField;

		// Token: 0x040027F6 RID: 10230
		private uint horizontalDpiField;

		// Token: 0x040027F7 RID: 10231
		private uint verticalDpiField;

		// Token: 0x040027F8 RID: 10232
		private uint copiesField;

		// Token: 0x040027F9 RID: 10233
		private string idField;
	}
}
