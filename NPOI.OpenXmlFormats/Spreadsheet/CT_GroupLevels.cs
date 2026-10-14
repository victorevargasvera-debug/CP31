using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049D RID: 1181
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_GroupLevels
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x000788B8 File Offset: 0x00076AB8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels ct_GroupLevels = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevels();
			if (node.Attributes["count"] != null)
			{
				ct_GroupLevels.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_GroupLevels.groupLevel = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "groupLevel")
				{
					ct_GroupLevels.groupLevel.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_GroupLevels;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00078974 File Offset: 0x00076B74
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.groupLevel != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel ct_GroupLevel in this.groupLevel)
				{
					ct_GroupLevel.Write(sw, "groupLevel");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00078A14 File Offset: 0x00076C14
		public CT_GroupLevels()
		{
			this.groupLevelField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel>();
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x00078A27 File Offset: 0x00076C27
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00078A2F File Offset: 0x00076C2F
		[global::System.Xml.Serialization.XmlElement("groupLevel", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel> groupLevel
		{
			get
			{
				return this.groupLevelField;
			}
			set
			{
				this.groupLevelField = value;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x00078A38 File Offset: 0x00076C38
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x00078A40 File Offset: 0x00076C40
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x00078A49 File Offset: 0x00076C49
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x00078A51 File Offset: 0x00076C51
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

		// Token: 0x040020C4 RID: 8388
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupLevel> groupLevelField;

		// Token: 0x040020C5 RID: 8389
		private uint countField;

		// Token: 0x040020C6 RID: 8390
		private bool countFieldSpecified;
	}
}
