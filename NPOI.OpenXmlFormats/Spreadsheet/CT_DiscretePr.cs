using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000499 RID: 1177
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_DiscretePr
	{
		// Token: 0x06002FF5 RID: 12277 RVA: 0x00078214 File Offset: 0x00076414
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr ct_DiscretePr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr();
			if (node.Attributes["count"] != null)
			{
				ct_DiscretePr.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_DiscretePr.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "x")
				{
					ct_DiscretePr.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DiscretePr;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000782D0 File Offset: 0x000764D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.x != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index ct_Index in this.x)
				{
					ct_Index.Write(sw, "x");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00078370 File Offset: 0x00076570
		public CT_DiscretePr()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index>();
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x00078383 File Offset: 0x00076583
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x0007838B File Offset: 0x0007658B
		[global::System.Xml.Serialization.XmlElement("x", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index> x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x00078394 File Offset: 0x00076594
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x0007839C File Offset: 0x0007659C
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

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000783A5 File Offset: 0x000765A5
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x000783AD File Offset: 0x000765AD
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

		// Token: 0x040020BA RID: 8378
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index> xField;

		// Token: 0x040020BB RID: 8379
		private uint countField;

		// Token: 0x040020BC RID: 8380
		private bool countFieldSpecified;
	}
}
