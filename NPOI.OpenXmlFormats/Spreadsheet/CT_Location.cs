using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BA RID: 1210
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Location
	{
		// Token: 0x06003237 RID: 12855 RVA: 0x0007DC28 File Offset: 0x0007BE28
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location ct_Location = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Location();
			ct_Location.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			if (node.Attributes["firstHeaderRow"] != null)
			{
				ct_Location.firstHeaderRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstHeaderRow"]);
			}
			if (node.Attributes["firstDataRow"] != null)
			{
				ct_Location.firstDataRow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstDataRow"]);
			}
			if (node.Attributes["firstDataCol"] != null)
			{
				ct_Location.firstDataCol = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["firstDataCol"]);
			}
			if (node.Attributes["rowPageCount"] != null)
			{
				ct_Location.rowPageCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["rowPageCount"]);
			}
			if (node.Attributes["colPageCount"] != null)
			{
				ct_Location.colPageCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["colPageCount"]);
			}
			return ct_Location;
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x0007DD40 File Offset: 0x0007BF40
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstHeaderRow", this.firstHeaderRow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstDataRow", this.firstDataRow, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "firstDataCol", this.firstDataCol, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rowPageCount", this.rowPageCount, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "colPageCount", this.colPageCount, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x0007DDE5 File Offset: 0x0007BFE5
		public CT_Location()
		{
			this.rowPageCountField = 0U;
			this.colPageCountField = 0U;
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x0007DDFB File Offset: 0x0007BFFB
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x0007DE03 File Offset: 0x0007C003
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x0007DE0C File Offset: 0x0007C00C
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x0007DE14 File Offset: 0x0007C014
		[global::System.Xml.Serialization.XmlAttribute]
		public uint firstHeaderRow
		{
			get
			{
				return this.firstHeaderRowField;
			}
			set
			{
				this.firstHeaderRowField = value;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x0007DE1D File Offset: 0x0007C01D
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x0007DE25 File Offset: 0x0007C025
		[global::System.Xml.Serialization.XmlAttribute]
		public uint firstDataRow
		{
			get
			{
				return this.firstDataRowField;
			}
			set
			{
				this.firstDataRowField = value;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x0007DE2E File Offset: 0x0007C02E
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x0007DE36 File Offset: 0x0007C036
		[global::System.Xml.Serialization.XmlAttribute]
		public uint firstDataCol
		{
			get
			{
				return this.firstDataColField;
			}
			set
			{
				this.firstDataColField = value;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x0007DE3F File Offset: 0x0007C03F
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x0007DE47 File Offset: 0x0007C047
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint rowPageCount
		{
			get
			{
				return this.rowPageCountField;
			}
			set
			{
				this.rowPageCountField = value;
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x0007DE50 File Offset: 0x0007C050
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x0007DE58 File Offset: 0x0007C058
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint colPageCount
		{
			get
			{
				return this.colPageCountField;
			}
			set
			{
				this.colPageCountField = value;
			}
		}

		// Token: 0x040021AF RID: 8623
		private string refField;

		// Token: 0x040021B0 RID: 8624
		private uint firstHeaderRowField;

		// Token: 0x040021B1 RID: 8625
		private uint firstDataRowField;

		// Token: 0x040021B2 RID: 8626
		private uint firstDataColField;

		// Token: 0x040021B3 RID: 8627
		private uint rowPageCountField;

		// Token: 0x040021B4 RID: 8628
		private uint colPageCountField;
	}
}
