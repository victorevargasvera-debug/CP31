using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A1 RID: 1185
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_GroupMembers
	{
		// Token: 0x06003047 RID: 12359 RVA: 0x000790C0 File Offset: 0x000772C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers ct_GroupMembers = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMembers();
			if (node.Attributes["count"] != null)
			{
				ct_GroupMembers.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_GroupMembers.groupMember = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "groupMember")
				{
					ct_GroupMembers.groupMember.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_GroupMembers;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0007917C File Offset: 0x0007737C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.groupMember != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember ct_GroupMember in this.groupMember)
				{
					ct_GroupMember.Write(sw, "groupMember");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0007921C File Offset: 0x0007741C
		public CT_GroupMembers()
		{
			this.groupMemberField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember>();
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x0007922F File Offset: 0x0007742F
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00079237 File Offset: 0x00077437
		[global::System.Xml.Serialization.XmlElement("groupMember", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember> groupMember
		{
			get
			{
				return this.groupMemberField;
			}
			set
			{
				this.groupMemberField = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x00079240 File Offset: 0x00077440
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00079248 File Offset: 0x00077448
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

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x00079251 File Offset: 0x00077451
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x00079259 File Offset: 0x00077459
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

		// Token: 0x040020D7 RID: 8407
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupMember> groupMemberField;

		// Token: 0x040020D8 RID: 8408
		private uint countField;

		// Token: 0x040020D9 RID: 8409
		private bool countFieldSpecified;
	}
}
