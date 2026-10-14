using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E4 RID: 1252
	public class CT_Dxfs
	{
		// Token: 0x06003461 RID: 13409 RVA: 0x0008361C File Offset: 0x0008181C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs ct_Dxfs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxfs();
			ct_Dxfs.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_Dxfs.dxfField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dxf")
				{
					ct_Dxfs.dxf.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Dxfs;
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x000836C4 File Offset: 0x000818C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, true);
			if (this.dxf.Count > 0)
			{
				sw.Write(">");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf ct_Dxf in this.dxf)
				{
					ct_Dxf.Write(sw, "dxf");
				}
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00083774 File Offset: 0x00081974
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x0008377C File Offset: 0x0008197C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf> dxf
		{
			get
			{
				return this.dxfField;
			}
			set
			{
				this.dxfField = value;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x00083785 File Offset: 0x00081985
		// (set) Token: 0x06003467 RID: 13415 RVA: 0x0008378D File Offset: 0x0008198D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x00083796 File Offset: 0x00081996
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x0008379E File Offset: 0x0008199E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x040022F6 RID: 8950
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf> dxfField;

		// Token: 0x040022F7 RID: 8951
		private uint countField;

		// Token: 0x040022F8 RID: 8952
		private bool countFieldSpecified;
	}
}
