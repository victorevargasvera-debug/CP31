using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058C RID: 1420
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Scenario
	{
		// Token: 0x06003E57 RID: 15959 RVA: 0x000972F2 File Offset: 0x000954F2
		public CT_Scenario()
		{
			this.lockedField = false;
			this.hiddenField = false;
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x00097308 File Offset: 0x00095508
		// (set) Token: 0x06003E59 RID: 15961 RVA: 0x00097310 File Offset: 0x00095510
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells> inputCells
		{
			get
			{
				return this.inputCellsField;
			}
			set
			{
				this.inputCellsField = value;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x00097319 File Offset: 0x00095519
		// (set) Token: 0x06003E5B RID: 15963 RVA: 0x00097321 File Offset: 0x00095521
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x0009732A File Offset: 0x0009552A
		// (set) Token: 0x06003E5D RID: 15965 RVA: 0x00097332 File Offset: 0x00095532
		[global::System.ComponentModel.DefaultValue(false)]
		public bool locked
		{
			get
			{
				return this.lockedField;
			}
			set
			{
				this.lockedField = value;
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x0009733B File Offset: 0x0009553B
		// (set) Token: 0x06003E5F RID: 15967 RVA: 0x00097343 File Offset: 0x00095543
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x0009734C File Offset: 0x0009554C
		// (set) Token: 0x06003E61 RID: 15969 RVA: 0x00097354 File Offset: 0x00095554
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

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x0009735D File Offset: 0x0009555D
		// (set) Token: 0x06003E63 RID: 15971 RVA: 0x00097365 File Offset: 0x00095565
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

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x0009736E File Offset: 0x0009556E
		// (set) Token: 0x06003E65 RID: 15973 RVA: 0x00097376 File Offset: 0x00095576
		public string user
		{
			get
			{
				return this.userField;
			}
			set
			{
				this.userField = value;
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x0009737F File Offset: 0x0009557F
		// (set) Token: 0x06003E67 RID: 15975 RVA: 0x00097387 File Offset: 0x00095587
		public string comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00097390 File Offset: 0x00095590
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario ct_Scenario = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Scenario();
			ct_Scenario.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			ct_Scenario.locked = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["locked"]);
			ct_Scenario.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			ct_Scenario.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_Scenario.user = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["user"]);
			ct_Scenario.comment = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["comment"]);
			ct_Scenario.inputCells = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "inputCells")
				{
					ct_Scenario.inputCells.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Scenario;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x000974C0 File Offset: 0x000956C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "locked", this.locked);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "user", this.user);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "comment", this.comment);
			if (this.inputCells != null)
			{
				sw.Write(">");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells ct_InputCells in this.inputCells)
				{
					ct_InputCells.Write(sw, "inputCells");
				}
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x0400279E RID: 10142
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_InputCells> inputCellsField;

		// Token: 0x0400279F RID: 10143
		private string nameField;

		// Token: 0x040027A0 RID: 10144
		private bool lockedField;

		// Token: 0x040027A1 RID: 10145
		private bool hiddenField;

		// Token: 0x040027A2 RID: 10146
		private uint countField;

		// Token: 0x040027A3 RID: 10147
		private bool countFieldSpecified;

		// Token: 0x040027A4 RID: 10148
		private string userField;

		// Token: 0x040027A5 RID: 10149
		private string commentField;
	}
}
