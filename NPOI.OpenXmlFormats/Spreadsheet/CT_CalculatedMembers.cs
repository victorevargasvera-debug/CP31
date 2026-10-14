using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B1 RID: 1201
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CalculatedMembers
	{
		// Token: 0x0600311E RID: 12574 RVA: 0x0007B2AC File Offset: 0x000794AC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers ct_CalculatedMembers = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMembers();
			if (node.Attributes["count"] != null)
			{
				ct_CalculatedMembers.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_CalculatedMembers.calculatedMember = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "calculatedMember")
				{
					ct_CalculatedMembers.calculatedMember.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CalculatedMembers;
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0007B368 File Offset: 0x00079568
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.calculatedMember != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember ct_CalculatedMember in this.calculatedMember)
				{
					ct_CalculatedMember.Write(sw, "calculatedMember");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0007B408 File Offset: 0x00079608
		public CT_CalculatedMembers()
		{
			this.calculatedMemberField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember>();
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x0007B41B File Offset: 0x0007961B
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x0007B423 File Offset: 0x00079623
		[global::System.Xml.Serialization.XmlElement("calculatedMember", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember> calculatedMember
		{
			get
			{
				return this.calculatedMemberField;
			}
			set
			{
				this.calculatedMemberField = value;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0007B42C File Offset: 0x0007962C
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x0007B434 File Offset: 0x00079634
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x0007B43D File Offset: 0x0007963D
		// (set) Token: 0x06003126 RID: 12582 RVA: 0x0007B445 File Offset: 0x00079645
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

		// Token: 0x04002134 RID: 8500
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedMember> calculatedMemberField;

		// Token: 0x04002135 RID: 8501
		private uint countField;

		// Token: 0x04002136 RID: 8502
		private bool countFieldSpecified;
	}
}
