using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000593 RID: 1427
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Break
	{
		// Token: 0x06003EE3 RID: 16099 RVA: 0x00098788 File Offset: 0x00096988
		public CT_Break()
		{
			this.idField = 0U;
			this.minField = 0U;
			this.maxField = 0U;
			this.manField = false;
			this.ptField = false;
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x000987B3 File Offset: 0x000969B3
		// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x000987BB File Offset: 0x000969BB
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint id
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

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x000987C4 File Offset: 0x000969C4
		// (set) Token: 0x06003EE7 RID: 16103 RVA: 0x000987CC File Offset: 0x000969CC
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint min
		{
			get
			{
				return this.minField;
			}
			set
			{
				this.minField = value;
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x000987D5 File Offset: 0x000969D5
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x000987DD File Offset: 0x000969DD
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x000987E6 File Offset: 0x000969E6
		// (set) Token: 0x06003EEB RID: 16107 RVA: 0x000987EE File Offset: 0x000969EE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool man
		{
			get
			{
				return this.manField;
			}
			set
			{
				this.manField = value;
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x000987F7 File Offset: 0x000969F7
		// (set) Token: 0x06003EED RID: 16109 RVA: 0x000987FF File Offset: 0x000969FF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool pt
		{
			get
			{
				return this.ptField;
			}
			set
			{
				this.ptField = value;
			}
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00098808 File Offset: 0x00096A08
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Break
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]),
				min = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["min"]),
				max = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["max"]),
				man = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["man"]),
				pt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["pt"])
			};
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x000988A8 File Offset: 0x00096AA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "min", this.min, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "max", this.max, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "man", this.man);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "pt", this.pt);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027D9 RID: 10201
		private uint idField;

		// Token: 0x040027DA RID: 10202
		private uint minField;

		// Token: 0x040027DB RID: 10203
		private uint maxField;

		// Token: 0x040027DC RID: 10204
		private bool manField;

		// Token: 0x040027DD RID: 10205
		private bool ptField;
	}
}
