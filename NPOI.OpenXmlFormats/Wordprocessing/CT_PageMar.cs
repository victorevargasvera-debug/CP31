using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C5 RID: 197
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PageMar
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PageMar
			{
				top = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:top"]),
				right = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:right"]),
				bottom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:bottom"]),
				left = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:left"]),
				header = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:header"]),
				footer = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:footer"]),
				gutter = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:gutter"])
			};
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:top", this.top);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:right", this.right);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:bottom", this.bottom);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:left", this.left);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:header", this.header);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:footer", this.footer);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:gutter", this.gutter, true);
			sw.Write("/>");
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000FA7B File Offset: 0x0000DC7B
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0000FA83 File Offset: 0x0000DC83
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0000FA8C File Offset: 0x0000DC8C
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000FA94 File Offset: 0x0000DC94
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000FA9D File Offset: 0x0000DC9D
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000FAA5 File Offset: 0x0000DCA5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000FAAE File Offset: 0x0000DCAE
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0000FAB6 File Offset: 0x0000DCB6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000FABF File Offset: 0x0000DCBF
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0000FAC7 File Offset: 0x0000DCC7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong header
		{
			get
			{
				return this.headerField;
			}
			set
			{
				this.headerField = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong footer
		{
			get
			{
				return this.footerField;
			}
			set
			{
				this.footerField = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		public ulong gutter
		{
			get
			{
				return this.gutterField;
			}
			set
			{
				this.gutterField = value;
			}
		}

		// Token: 0x040004C6 RID: 1222
		private string topField;

		// Token: 0x040004C7 RID: 1223
		private ulong rightField;

		// Token: 0x040004C8 RID: 1224
		private string bottomField;

		// Token: 0x040004C9 RID: 1225
		private ulong leftField;

		// Token: 0x040004CA RID: 1226
		private ulong headerField;

		// Token: 0x040004CB RID: 1227
		private ulong footerField;

		// Token: 0x040004CC RID: 1228
		private ulong gutterField;
	}
}
