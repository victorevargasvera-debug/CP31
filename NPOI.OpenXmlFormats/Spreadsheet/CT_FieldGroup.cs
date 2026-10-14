using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000496 RID: 1174
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_FieldGroup
	{
		// Token: 0x06002FC9 RID: 12233 RVA: 0x00077C4C File Offset: 0x00075E4C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup ct_FieldGroup = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldGroup();
			if (node.Attributes["par"] != null)
			{
				ct_FieldGroup.par = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["par"]);
			}
			if (node.Attributes["base"] != null)
			{
				ct_FieldGroup.@base = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["base"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rangePr")
				{
					ct_FieldGroup.rangePr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "discretePr")
				{
					ct_FieldGroup.discretePr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "groupItems")
				{
					ct_FieldGroup.groupItems = global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FieldGroup;
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00077D68 File Offset: 0x00075F68
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "par", this.par, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "base", this.@base, false);
			sw.Write(">");
			if (this.rangePr != null)
			{
				this.rangePr.Write(sw, "rangePr");
			}
			if (this.discretePr != null)
			{
				this.discretePr.Write(sw, "discretePr");
			}
			if (this.groupItems != null)
			{
				this.groupItems.Write(sw, "groupItems");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00077E11 File Offset: 0x00076011
		public CT_FieldGroup()
		{
			this.groupItemsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems();
			this.discretePrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr();
			this.rangePrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr();
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x00077E3A File Offset: 0x0007603A
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00077E42 File Offset: 0x00076042
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr rangePr
		{
			get
			{
				return this.rangePrField;
			}
			set
			{
				this.rangePrField = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x00077E4B File Offset: 0x0007604B
		// (set) Token: 0x06002FCF RID: 12239 RVA: 0x00077E53 File Offset: 0x00076053
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr discretePr
		{
			get
			{
				return this.discretePrField;
			}
			set
			{
				this.discretePrField = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x00077E5C File Offset: 0x0007605C
		// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x00077E64 File Offset: 0x00076064
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems groupItems
		{
			get
			{
				return this.groupItemsField;
			}
			set
			{
				this.groupItemsField = value;
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x00077E6D File Offset: 0x0007606D
		// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x00077E75 File Offset: 0x00076075
		[global::System.Xml.Serialization.XmlAttribute]
		public uint par
		{
			get
			{
				return this.parField;
			}
			set
			{
				this.parField = value;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x00077E7E File Offset: 0x0007607E
		// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x00077E86 File Offset: 0x00076086
		[global::System.Xml.Serialization.XmlIgnore]
		public bool parSpecified
		{
			get
			{
				return this.parFieldSpecified;
			}
			set
			{
				this.parFieldSpecified = value;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x00077E8F File Offset: 0x0007608F
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x00077E97 File Offset: 0x00076097
		[global::System.Xml.Serialization.XmlAttribute]
		public uint @base
		{
			get
			{
				return this.baseField;
			}
			set
			{
				this.baseField = value;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x00077EA0 File Offset: 0x000760A0
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x00077EA8 File Offset: 0x000760A8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool baseSpecified
		{
			get
			{
				return this.baseFieldSpecified;
			}
			set
			{
				this.baseFieldSpecified = value;
			}
		}

		// Token: 0x0400209E RID: 8350
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangePr rangePrField;

		// Token: 0x0400209F RID: 8351
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DiscretePr discretePrField;

		// Token: 0x040020A0 RID: 8352
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems groupItemsField;

		// Token: 0x040020A1 RID: 8353
		private uint parField;

		// Token: 0x040020A2 RID: 8354
		private bool parFieldSpecified;

		// Token: 0x040020A3 RID: 8355
		private uint baseField;

		// Token: 0x040020A4 RID: 8356
		private bool baseFieldSpecified;
	}
}
