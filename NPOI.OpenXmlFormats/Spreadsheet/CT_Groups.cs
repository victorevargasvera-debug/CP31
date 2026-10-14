using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049F RID: 1183
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Groups
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x00078CD0 File Offset: 0x00076ED0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups ct_Groups = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Groups();
			if (node.Attributes["count"] != null)
			{
				ct_Groups.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Groups.group = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "group")
				{
					ct_Groups.group.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Groups;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00078D8C File Offset: 0x00076F8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.group != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup ct_LevelGroup in this.group)
				{
					ct_LevelGroup.Write(sw, "group");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x00078E2C File Offset: 0x0007702C
		public CT_Groups()
		{
			this.groupField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup>();
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x00078E3F File Offset: 0x0007703F
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x00078E47 File Offset: 0x00077047
		[global::System.Xml.Serialization.XmlElement("group", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup> group
		{
			get
			{
				return this.groupField;
			}
			set
			{
				this.groupField = value;
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x00078E50 File Offset: 0x00077050
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x00078E58 File Offset: 0x00077058
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

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x00078E61 File Offset: 0x00077061
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x00078E69 File Offset: 0x00077069
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

		// Token: 0x040020CD RID: 8397
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_LevelGroup> groupField;

		// Token: 0x040020CE RID: 8398
		private uint countField;

		// Token: 0x040020CF RID: 8399
		private bool countFieldSpecified;
	}
}
