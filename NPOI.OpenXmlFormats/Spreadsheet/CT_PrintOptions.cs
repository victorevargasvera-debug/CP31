using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000595 RID: 1429
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PrintOptions
	{
		// Token: 0x06003EFF RID: 16127 RVA: 0x00098AF4 File Offset: 0x00096CF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions
			{
				horizontalCentered = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["horizontalCentered"]),
				verticalCentered = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["verticalCentered"]),
				headings = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["headings"]),
				gridLines = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["gridLines"]),
				gridLinesSet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["gridLinesSet"], true)
			};
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00098B94 File Offset: 0x00096D94
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.horizontalCentered)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "horizontalCentered", this.horizontalCentered);
			}
			if (this.verticalCentered)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "verticalCentered", this.verticalCentered);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "headings", this.headings, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gridLines", this.gridLines, false);
			if (!this.gridLinesSet)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gridLinesSet", this.gridLinesSet);
			}
			sw.Write("/>");
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x00098C2C File Offset: 0x00096E2C
		public CT_PrintOptions()
		{
			this.horizontalCenteredField = false;
			this.verticalCenteredField = false;
			this.headingsField = false;
			this.gridLinesField = false;
			this.gridLinesSetField = true;
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x00098C57 File Offset: 0x00096E57
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x00098C5F File Offset: 0x00096E5F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool horizontalCentered
		{
			get
			{
				return this.horizontalCenteredField;
			}
			set
			{
				this.horizontalCenteredField = value;
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x00098C68 File Offset: 0x00096E68
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x00098C70 File Offset: 0x00096E70
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool verticalCentered
		{
			get
			{
				return this.verticalCenteredField;
			}
			set
			{
				this.verticalCenteredField = value;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x00098C79 File Offset: 0x00096E79
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x00098C81 File Offset: 0x00096E81
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool headings
		{
			get
			{
				return this.headingsField;
			}
			set
			{
				this.headingsField = value;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x00098C8A File Offset: 0x00096E8A
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x00098C92 File Offset: 0x00096E92
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool gridLines
		{
			get
			{
				return this.gridLinesField;
			}
			set
			{
				this.gridLinesField = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x00098C9B File Offset: 0x00096E9B
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x00098CA3 File Offset: 0x00096EA3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool gridLinesSet
		{
			get
			{
				return this.gridLinesSetField;
			}
			set
			{
				this.gridLinesSetField = value;
			}
		}

		// Token: 0x040027E4 RID: 10212
		private bool horizontalCenteredField;

		// Token: 0x040027E5 RID: 10213
		private bool verticalCenteredField;

		// Token: 0x040027E6 RID: 10214
		private bool headingsField;

		// Token: 0x040027E7 RID: 10215
		private bool gridLinesField;

		// Token: 0x040027E8 RID: 10216
		private bool gridLinesSetField;
	}
}
