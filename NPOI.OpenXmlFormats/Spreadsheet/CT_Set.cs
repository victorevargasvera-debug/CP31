using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A9 RID: 1193
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Set
	{
		// Token: 0x060030D5 RID: 12501 RVA: 0x0007A680 File Offset: 0x00078880
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set ct_Set = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Set();
			if (node.Attributes["count"] != null)
			{
				ct_Set.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			if (node.Attributes["maxRank"] != null)
			{
				ct_Set.maxRank = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["maxRank"]);
			}
			ct_Set.setDefinition = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["setDefinition"]);
			if (node.Attributes["sortType"] != null)
			{
				ct_Set.sortType = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType), node.Attributes["sortType"].Value);
			}
			if (node.Attributes["queryFailed"] != null)
			{
				ct_Set.queryFailed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["queryFailed"]);
			}
			ct_Set.tpls = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sortByTuple")
				{
					ct_Set.sortByTuple = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tpls")
				{
					ct_Set.tpls.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Set;
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0007A814 File Offset: 0x00078A14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxRank", this.maxRank);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "setDefinition", this.setDefinition);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sortType", this.sortType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "queryFailed", this.queryFailed);
			sw.Write(">");
			if (this.sortByTuple != null)
			{
				this.sortByTuple.Write(sw, "sortByTuple");
			}
			if (this.tpls != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples ct_Tuples in this.tpls)
				{
					ct_Tuples.Write(sw, "tpls");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0007A91C File Offset: 0x00078B1C
		public CT_Set()
		{
			this.sortByTupleField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples();
			this.tplsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			this.sortTypeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType.none;
			this.queryFailedField = false;
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x0007A948 File Offset: 0x00078B48
		// (set) Token: 0x060030D9 RID: 12505 RVA: 0x0007A950 File Offset: 0x00078B50
		[global::System.Xml.Serialization.XmlElement("tpls", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tpls
		{
			get
			{
				return this.tplsField;
			}
			set
			{
				this.tplsField = value;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x0007A959 File Offset: 0x00078B59
		// (set) Token: 0x060030DB RID: 12507 RVA: 0x0007A961 File Offset: 0x00078B61
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples sortByTuple
		{
			get
			{
				return this.sortByTupleField;
			}
			set
			{
				this.sortByTupleField = value;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x0007A96A File Offset: 0x00078B6A
		// (set) Token: 0x060030DD RID: 12509 RVA: 0x0007A972 File Offset: 0x00078B72
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

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x0007A97B File Offset: 0x00078B7B
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x0007A983 File Offset: 0x00078B83
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

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x0007A98C File Offset: 0x00078B8C
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x0007A994 File Offset: 0x00078B94
		[global::System.Xml.Serialization.XmlAttribute]
		public int maxRank
		{
			get
			{
				return this.maxRankField;
			}
			set
			{
				this.maxRankField = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0007A99D File Offset: 0x00078B9D
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x0007A9A5 File Offset: 0x00078BA5
		[global::System.Xml.Serialization.XmlAttribute]
		public string setDefinition
		{
			get
			{
				return this.setDefinitionField;
			}
			set
			{
				this.setDefinitionField = value;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x0007A9AE File Offset: 0x00078BAE
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x0007A9B6 File Offset: 0x00078BB6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType sortType
		{
			get
			{
				return this.sortTypeField;
			}
			set
			{
				this.sortTypeField = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0007A9BF File Offset: 0x00078BBF
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x0007A9C7 File Offset: 0x00078BC7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool queryFailed
		{
			get
			{
				return this.queryFailedField;
			}
			set
			{
				this.queryFailedField = value;
			}
		}

		// Token: 0x04002112 RID: 8466
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tplsField;

		// Token: 0x04002113 RID: 8467
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples sortByTupleField;

		// Token: 0x04002114 RID: 8468
		private uint countField;

		// Token: 0x04002115 RID: 8469
		private bool countFieldSpecified;

		// Token: 0x04002116 RID: 8470
		private int maxRankField;

		// Token: 0x04002117 RID: 8471
		private string setDefinitionField;

		// Token: 0x04002118 RID: 8472
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_SortType sortTypeField;

		// Token: 0x04002119 RID: 8473
		private bool queryFailedField;
	}
}
